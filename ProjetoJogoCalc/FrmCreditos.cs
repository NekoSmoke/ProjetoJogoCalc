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
    public partial class FrmCreditos : Form
    {
        public FrmCreditos()
        {
            InitializeComponent();
            AtualizarConquista();
        }
        private void AtualizarConquista()
        {
            LblNomeConquista.Text = "Colecionador";

            LblDescricaoConquista.Text =
                "Compre todos os itens disponíveis na loja.";

            if (EstadoJogo.ConquistaColecionador)
            {
                LblStatusConquista.Text = "DESBLOQUEADA";

                LblStatusConquista.ForeColor = Color.Green;

                LblNomeConquista.ForeColor = Color.Goldenrod;

                PicConquista.Image = Properties.Resources.calc;
            }
            else
            {
                LblStatusConquista.Text = "BLOQUEADA";

                LblStatusConquista.ForeColor = Color.Gray;

                LblNomeConquista.ForeColor = Color.Gray;

                PicConquista.Image = Properties.Resources.lock_001;
            }
        }
        private void LblCreditos1_Click(object sender, EventArgs e)
        {

        }
    }
}
