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

namespace ProjetoJogoCalc
{

    public partial class ProjetoJogoCalc : Form
    {
        private bool NovoNumeroPrincipal = true;
        private Button[] TeclasCalculadora;
        decimal PrimeiroNumeroTeste = 0;
        string OperadorTeste = "";
        bool NovoNumeroTeste = true;
        public bool JogoConcluido { get; private set; } = false;



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
                    "Resposta correta!",
                    "Parabéns",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                equacaoAtual.Concluida = true;

                EstadoJogo.Dinheiro += EstadoJogo.RecompensaPorQuestao;
                EstadoJogo.EquacaoAtual++;

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
            TeclasCalculadora = new Button[]
            {
               Nmr7, Nmr8, Nmr9, Nmr4, Nmr5, Nmr6, Nmr1, Nmr2, Nmr3, Nmr0,
            };
            

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
       "Tem certeza de que deseja voltar ao menu?\n\nTodo o progresso desta partida será perdido!",
       "Abandonar partida",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning
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
                loja = new FrmLoja();
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
        }
        
    }
}
