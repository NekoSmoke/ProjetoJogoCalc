using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoJogoCalc
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            this.Hide();

            ProjetoJogoCalc jogo = new ProjetoJogoCalc();
            jogo.ShowDialog();

            if (!jogo.JogoConcluido)
            {
                this.Show();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
          "Tem certeza de que deseja sair do jogo?",
          "Sair do jogo",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Hand
      );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnCreditos_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmCreditos creditos = new FrmCreditos();
            creditos.ShowDialog();

            this.Show();
        }

        private void BtnComoJogarMenu_Click(object sender, EventArgs e)
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
    }
}
