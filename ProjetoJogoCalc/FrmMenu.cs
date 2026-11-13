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

            this.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCreditos_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmCreditos creditos = new FrmCreditos();
            creditos.ShowDialog();

            this.Show();
        }
    }
}
