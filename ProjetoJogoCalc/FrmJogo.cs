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
    public partial class ProjetoJogoCalc : Form
    {

        public ProjetoJogoCalc()
        {
            InitializeComponent();
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
    }
}
