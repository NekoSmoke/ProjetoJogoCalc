using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using NAudio.Wave;
using System.IO;

namespace ProjetoJogoCalc
{

    public partial class ProjetoJogoCalc : Form
    {
        private AudioFileReader leitorAudio;
        private WaveOutEvent reprodutorAudio;
        private bool musicaAtiva = true;
        private void IniciarMusica()
        {
            string caminhoMusica = Path.Combine(
       Application.StartupPath,
       "Audio",
       "MusicaFini.mpeg"
   );

            leitorAudio = new AudioFileReader(caminhoMusica);
            reprodutorAudio = new WaveOutEvent();

            reprodutorAudio.Init(leitorAudio);

            reprodutorAudio.PlaybackStopped += (s, e) =>
            {
                if (musicaAtiva && reprodutorAudio != null)
                {
                    leitorAudio.Position = 0;
                    reprodutorAudio.Play();
                }
            };

            reprodutorAudio.Play();
        }
        private void PararMusica()
        {
            if (reprodutorAudio != null)
            {
                reprodutorAudio.Stop();
                reprodutorAudio.Dispose();
                reprodutorAudio = null;
            }

            if (leitorAudio != null)
            {
                leitorAudio.Dispose();
                leitorAudio = null;
            }
        }
        private void AtualizarBotaoMusica()
        {
            BtnMusica.Text = musicaAtiva ? "Música: ON" : "Música: OFF";
        }
        private bool NovoNumeroPrincipal = true;
        private Button[] TeclasCalculadora;
        decimal PrimeiroNumeroTeste = 0;
        string OperadorTeste = "";
        bool NovoNumeroTeste = true;
        private void BloquearTecla(Button botao)
        {
            botao.Text = "";
            botao.BackgroundImage = Properties.Resources.lock_001;
            botao.BackgroundImageLayout = ImageLayout.Stretch;
            botao.Enabled = false;
        }
        public bool JogoConcluido { get; private set; } = false;

        private void AtualizarEstadoTeclas()
        {
            foreach (Control controle in ObterControles(this))
            {
                if (controle is Button botao && botao.Tag != null)
                {
                    string tecla = botao.Tag.ToString();

                    if (EstadoJogo.TeclasDesbloqueadas.Contains(tecla))
                    {
                        DesbloquearTecla(botao);
                    }
                    else
                    {
                        BloquearTecla(botao);
                    }
                }
            }
        }
        #region Saldo
        public void AtualizarSaldo()
        {
            LblDinheiroAtual.Text = "Dinheiro atual:\n" + EstadoJogo.Dinheiro.ToString("C2", CultureInfo.GetCultureInfo("pt-BR") );
        }
        #endregion
        #region identificarBotao
        private void BtnNumeroPrincipal_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            string numero = botao.Tag.ToString();

            if (NovoNumeroPrincipal)
            {
                TxtVisorPrincipal.Text = numero;
                NovoNumeroPrincipal = false;
            }
            else if (TxtVisorPrincipal.Text == "0")
            {
                TxtVisorPrincipal.Text = numero;
            }
            else
            {
                TxtVisorPrincipal.Text += numero;
            }
        }
        #endregion
        #region CalcularTeste
        private decimal Calcular(decimal numero1, decimal numero2, string operador)
        {
            switch (operador)
            {
                case "+":
                    return numero1 + numero2;

                case "-":
                    return numero1 - numero2;

                case "X":
                    return numero1 * numero2;

                case "/":
                    if (numero2 == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    return numero1 / numero2;

                default:
                    return numero2;
            }
        }
        #endregion
        #region del deleta
        private void BtnDELPrincipal_Click(object sender, EventArgs e)
        {
            if (NovoNumeroPrincipal)
                return;

            if (TxtVisorPrincipal.Text.Length > 1)
            {
                TxtVisorPrincipal.Text =
                    TxtVisorPrincipal.Text.Substring(
                        0,
                        TxtVisorPrincipal.Text.Length - 1
                    );
            }
            else
            {
                TxtVisorPrincipal.Text = "0";
            }
        }
        #endregion
        #region ac acelta
        private void BtnACPrincipal_Click(object sender, EventArgs e)
        {
            TxtVisorPrincipal.Text = "0";
            NovoNumeroPrincipal = true;
        }
        #endregion
        #region virgula virgula
        private void BtnVirgulaPrincipal_Click(object sender, EventArgs e)
        {
            if (NovoNumeroPrincipal)
            {
                TxtVisorPrincipal.Text = "0,";
                NovoNumeroPrincipal = false;
            }
            else if (!TxtVisorPrincipal.Text.Contains(","))
            {
                TxtVisorPrincipal.Text += ",";
            }
        }
        #endregion
        #region igual iguala
        private void BtnIgualPrincipal_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(
                TxtVisorPrincipal.Text,
                NumberStyles.Number,
                CultureInfo.GetCultureInfo("pt-BR"),
                out decimal respostaJogador))
            {
                return;
            }
            Equacao equacaoAtual =
                EstadoJogo.Etapas[EstadoJogo.EtapaAtual]
                .Equacoes[EstadoJogo.EquacaoAtual];

            if (respostaJogador == equacaoAtual.Resposta)
            {
                MessageBox.Show(
                    "Resposta correta!\n\nVocê ganhou " + EstadoJogo.RecompensaPorQuestao.ToString("C2", CultureInfo.GetCultureInfo("pt-BR")) + "!",
                    "Parabéns",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                equacaoAtual.Concluida = true;

                EstadoJogo.Dinheiro += EstadoJogo.RecompensaPorQuestao;
                EstadoJogo.EquacaoAtual++;
                AtualizarExibicaoEquacoes();
                AtualizarSaldo();

                TxtVisorPrincipal.Text = "0";
                NovoNumeroPrincipal = true;

                if (EstadoJogo.EquacaoAtual >=
                    EstadoJogo.Etapas[EstadoJogo.EtapaAtual].Equacoes.Count)
                {
                    MessageBox.Show(
                        "Você completou todas as equações desta etapa!",
                        "Etapa concluída",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );


                    EstadoJogo.EtapaAtual++;
                    EstadoJogo.EquacaoAtual = 0;
                    AtualizarExibicaoEquacoes();


                    if (EstadoJogo.EtapaAtual >= EstadoJogo.Etapas.Count)
                    {
                        MessageBox.Show(
                            "Parabéns! Você concluiu todas as etapas!",
                            "Vitória!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        JogoConcluido = true;
                        FrmCreditos creditos = new FrmCreditos();
                        creditos.FormClosed += (s, args) =>
                        {
                            Application.OpenForms
                            .OfType<FrmMenu>()
                            .FirstOrDefault()?.Show();
                        };
                        creditos.Show();
                        this.Close();

                        return;
                    }

                    MessageBox.Show(
                        "Você avançou para a etapa " +
                        EstadoJogo.Etapas[EstadoJogo.EtapaAtual].Nome + "!",
                        "Nova etapa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Resposta incorreta. Tente novamente!",
                    "Ops!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                TxtVisorPrincipal.Text = "0";
                NovoNumeroPrincipal = true;
            }
        }
        #endregion
        #region exibir equações
        private void AtualizarExibicaoEquacoes()
        {
            // Limpa as equações exibidas anteriormente
            FlpEquacoes.Controls.Clear();
            if (EstadoJogo.EtapaAtual >= EstadoJogo.Etapas.Count)
            {
                return;
            }

            // Obtém a etapa atual
            Etapa etapaAtual =
                EstadoJogo.Etapas[EstadoJogo.EtapaAtual];

            // Percorre todas as equações da etapa
            for (int i = 0; i < etapaAtual.Equacoes.Count; i++)
            {
                Equacao equacao = etapaAtual.Equacoes[i];

                Label lblEquacao = new Label();

                lblEquacao.Width = FlpEquacoes.ClientSize.Width - 25;
                lblEquacao.Height = 30;

                lblEquacao.Font = new Font(
                    "Segoe UI",
                    12,
                    FontStyle.Regular
                );

                lblEquacao.TextAlign = ContentAlignment.MiddleLeft;

                // Verifica se a equação já foi concluída
                if (equacao.Concluida)
                {
                    lblEquacao.Text =
                        "✓ " + equacao.Enunciado.Replace(
                            "?",
                            equacao.Resposta.ToString(
                                CultureInfo.GetCultureInfo("pt-BR")
                            )
                        );

                    lblEquacao.ForeColor = Color.Green;
                }
                else if (i == EstadoJogo.EquacaoAtual)
                {
                    // Destaca a equação atual
                    lblEquacao.Text = "▶ " + equacao.Enunciado;

                    lblEquacao.BackColor = Color.LightBlue;
                    lblEquacao.Font = new Font(
                        "Segoe UI",
                        12,
                        FontStyle.Bold
                    );
                }
                else
                {
                    // Equações que ainda não foram resolvidas
                    lblEquacao.Text = equacao.Enunciado;
                    lblEquacao.ForeColor = Color.Gray;
                }

                FlpEquacoes.Controls.Add(lblEquacao);
            }
        }
        #endregion
        private void BtnNumero_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            string numero = botao.Text;

            if (NovoNumeroTeste)
            {
                TxtVisorTeste.Text = numero;
                NovoNumeroTeste = false;
            }
            else if (TxtVisorTeste.Text == "0")
            {
                TxtVisorTeste.Text = numero;
            }
            else
            {
                TxtVisorTeste.Text += numero;
            }
        }
        private void BtnOperador_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (!decimal.TryParse(
                TxtVisorTeste.Text,
                System.Globalization.NumberStyles.Number,
                System.Globalization.CultureInfo.GetCultureInfo("pt-BR"),
                out decimal valor))
            {
                return;
            }

            if (OperadorTeste != "" && !NovoNumeroTeste)
            {
                PrimeiroNumeroTeste = Calcular(
                    PrimeiroNumeroTeste,
                    valor,
                    OperadorTeste
                );

                TxtExpressao.Text = PrimeiroNumeroTeste.ToString(
                    System.Globalization.CultureInfo.GetCultureInfo("pt-BR")
                )+ " " + OperadorTeste;
            }
            else
            {
                PrimeiroNumeroTeste = valor;
            }

            OperadorTeste = botao.Text;
            NovoNumeroTeste = true;
        }
        #region esquações real
        public class Equacao // EQUAÇÕES
        {
            public string Enunciado { get; set; }
            public decimal Resposta { get; set; }
            public decimal Recompensa { get; set; }
            public bool Concluida { get; set; } = false;
        }
        #endregion
        #region etapas
        public class Etapa
        {
            public string Nome { get; set; }

            public List<Equacao> Equacoes { get; set; }
        }
        #endregion

        public ProjetoJogoCalc()
        {
            InitializeComponent();
            this.FormClosing += (s, e) =>
            {
                PararMusica();
            };
            IniciarMusica();
            AtualizarBotaoMusica();
            TeclasCalculadora = new Button[]
            {
               Nmr7, Nmr8, Nmr9, Nmr4, Nmr5, Nmr6, Nmr1, Nmr2, Nmr3, Nmr0,
            };
            AtualizarEstadoTeclas();
            AtualizarExibicaoEquacoes();
            AtualizarSaldo();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        

        private void ProjetoJogoCalc_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void BtnVoltarMenu_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
       "Tem certeza de que deseja voltar ao menu?\n\nTodo o progresso desta partida será salvo.",
       "Abandonar partida...",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TestVirgula_Click(object sender, EventArgs e)
        {
            if (NovoNumeroTeste)
            {
                TxtVisorTeste.Text = "0,";
                NovoNumeroTeste = false;
            }
            else if (!TxtVisorTeste.Text.Contains(","))
            {
                TxtVisorTeste.Text += ",";
            }
        }

        private void TesteIgual_Click(object sender, EventArgs e)
        {
            if (OperadorTeste == "")
                return;

            if (!decimal.TryParse(
                TxtVisorTeste.Text,
                System.Globalization.NumberStyles.Number,
                System.Globalization.CultureInfo.GetCultureInfo("pt-BR"),
                out decimal segundoNumero))
            {
                return;
            }

            try
            {
                // Guarda a expressão antes de realizar o cálculo
                string expressao =
                    PrimeiroNumeroTeste.ToString(
                        System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))
                    + " " + OperadorTeste + " " + segundoNumero + " =";

                decimal resultado = Calcular(
                    PrimeiroNumeroTeste,
                    segundoNumero,
                    OperadorTeste
                );

                // Exibe a expressão completa
                TxtExpressao.Text = expressao;

                // Exibe somente o resultado no visor principal
                TxtVisorTeste.Text = resultado.ToString(
                    System.Globalization.CultureInfo.GetCultureInfo("pt-BR")
                );

                OperadorTeste = "";
                NovoNumeroTeste = true;
            }
            catch (DivideByZeroException)
            {
                TxtVisorTeste.Text = "Erro";
                OperadorTeste = "";
                NovoNumeroTeste = true;
            }
        }

        private void TestAC_Click(object sender, EventArgs e)
        {
            TxtVisorTeste.Text = "0";

            PrimeiroNumeroTeste = 0;
            OperadorTeste = "";
            NovoNumeroTeste = true;
            TxtExpressao.Clear();
        }
        private FrmLoja loja;
        private void button1_Click(object sender, EventArgs e)//BOTÃO DA LOJA
        {
            if (loja == null || loja.IsDisposed)
            {
                loja = new FrmLoja(this);
            }

            loja.Show();
            loja.Activate();
        }

        private void BtnRegras_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
       "COMO JOGAR\n\n" +
       "Você possui uma Calculadora que está quebrada." +
       "\n\n1-Conclua operações matemáticas para ganhar dinheiro\n\n2-Utilize esse dinheiro para consertar os botões quebrados\n\n3-Termine o jogo ao concluir todas as operações!",
       "Como jogar!",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information
   );
        }

        private void DesbloquearTecla(Button botao)
        {
            botao.Text = botao.Tag.ToString();
            botao.Image = null;
            botao.Enabled = true;
            botao.BackgroundImage = null;
        }
        public void DesbloquearTeclaPorTag(string tecla)
        {
            foreach (Control controle in ObterControles(this))
            {
                if (controle is Button botao &&
                    botao.Tag != null &&
                    botao.Tag.ToString() == tecla)
                {
                    DesbloquearTecla(botao);
                    EstadoJogo.TeclasDesbloqueadas.Add(tecla);
                    return;
                }
            }
        }

        private IEnumerable<Control> ObterControles(Control controle)
        {
            foreach (Control filho in controle.Controls)
            {
                yield return filho;

                foreach (Control descendente in ObterControles(filho))
                {
                    yield return descendente;
                }
            }
        }

        private void BtnMusica_Click(object sender, EventArgs e)
        {
            musicaAtiva = !musicaAtiva;

            if (musicaAtiva)
            {
                reprodutorAudio.Play();
            }
            else
            {
                reprodutorAudio.Pause();
            }

            AtualizarBotaoMusica();
        }
    }
}
