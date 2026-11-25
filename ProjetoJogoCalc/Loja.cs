using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoJogoCalc
{
    public partial class FrmLoja : Form
    {
        private ProjetoJogoCalc jogoPrincipal;
        private Dictionary<Button, decimal> PrecosBotoes = new Dictionary<Button, decimal>();
        private string[] ItensComercializados =
        {
             "0", "5", "6", "7", "8", "9","+", "-", "X", "/", ","
        };
        private void VerificarConquistaColecionador()
        {
            foreach (string item in ItensComercializados)
            {
                if (!EstadoJogo.TeclasDesbloqueadas.Contains(item))
                {
                    return;
                }
            }

            EstadoJogo.ConquistaColecionador = true;
        }
        public FrmLoja(ProjetoJogoCalc jogo)

        {
            InitializeComponent();
            jogoPrincipal = jogo;
            CarregarItensLoja();
            AtualizarSaldoLoja();
        }

        private void AtualizarSaldoLoja()
        {
            LblSaldoLoja.Text =
                "Saldo: " +
                EstadoJogo.Dinheiro.ToString(
                    "C2",
                    CultureInfo.GetCultureInfo("pt-BR")
                );
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            string tecla = botao.Tag.ToString();

            decimal preco = PrecosBotoes[botao];

            // Verifica se o jogador possui dinheiro suficiente
            if (EstadoJogo.Dinheiro < preco)
            {
                MessageBox.Show(
                    "Dinheiro insuficiente para comprar esta tecla!",
                    "Compra não realizada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            EstadoJogo.Dinheiro -= preco;

            jogoPrincipal.DesbloquearTeclaPorTag(tecla);

            jogoPrincipal.AtualizarSaldo();
            VerificarConquistaColecionador();

            Panel painel = (Panel)botao.Parent;

            foreach (Control controle in painel.Controls)
            {
                if (controle is Label label)
                {
                    label.Text = "VENDIDO";
                }
            }

            botao.Enabled = false;

            AtualizarSaldoLoja();
        }

        private void CriarItemLoja(string tecla, decimal preco)
        {
            Panel painel = new Panel();
            painel.Width = 100;
            painel.Height = 115;
            painel.Margin = new Padding(8);

            Button botao = new Button();
            botao.Width = 90;
            botao.Height = 70;
            botao.Location = new Point(5, 0);
            botao.Text = tecla;
            botao.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            botao.Tag = tecla;

            Label lblPreco = new Label();
            lblPreco.Width = 100;
            lblPreco.Height = 30;
            lblPreco.Location = new Point(0, 75);
            lblPreco.TextAlign = ContentAlignment.MiddleCenter;

            if (EstadoJogo.TeclasDesbloqueadas.Contains(tecla))
            {
                lblPreco.Text = "VENDIDO";
                botao.Enabled = false;
            }
            else
            {
                lblPreco.Text = preco.ToString(
                    "C2",
                    CultureInfo.GetCultureInfo("pt-BR")
                );

                PrecosBotoes.Add(botao, preco);
                botao.Click += BtnComprar_Click;
            }

            painel.Controls.Add(botao);
            painel.Controls.Add(lblPreco);

            FlpItensLoja.Controls.Add(painel);
        }

        private void CarregarItensLoja()
        {
            FlpItensLoja.Controls.Clear();
            PrecosBotoes.Clear();

            CriarItemLoja("0", 10);
            CriarItemLoja("5", 10);
            CriarItemLoja("6", 10);
            CriarItemLoja("7", 10);
            CriarItemLoja("8", 10);
            CriarItemLoja("9", 10);

            CriarItemLoja("+", 25);
            CriarItemLoja("-", 25);
            CriarItemLoja("X", 25);
            CriarItemLoja("/", 25);

            CriarItemLoja(",", 9);
        }
        private void FrmLoja_Load(object sender, EventArgs e)
        {

        }
    }
}
