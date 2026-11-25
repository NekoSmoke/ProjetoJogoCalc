namespace ProjetoJogoCalc
{
    partial class FrmLoja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoja));
            this.LblTituloLoja = new System.Windows.Forms.Label();
            this.LblSaldoLoja = new System.Windows.Forms.Label();
            this.FlpItensLoja = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LblTituloLoja
            // 
            this.LblTituloLoja.AutoSize = true;
            this.LblTituloLoja.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloLoja.Location = new System.Drawing.Point(306, 21);
            this.LblTituloLoja.Name = "LblTituloLoja";
            this.LblTituloLoja.Size = new System.Drawing.Size(205, 34);
            this.LblTituloLoja.TabIndex = 0;
            this.LblTituloLoja.Text = "Lojas Teclando";
            // 
            // LblSaldoLoja
            // 
            this.LblSaldoLoja.AutoSize = true;
            this.LblSaldoLoja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSaldoLoja.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldoLoja.Location = new System.Drawing.Point(12, 31);
            this.LblSaldoLoja.Name = "LblSaldoLoja";
            this.LblSaldoLoja.Size = new System.Drawing.Size(107, 23);
            this.LblSaldoLoja.TabIndex = 1;
            this.LblSaldoLoja.Text = "Saldo: R$0,00";
            // 
            // FlpItensLoja
            // 
            this.FlpItensLoja.AutoScroll = true;
            this.FlpItensLoja.Location = new System.Drawing.Point(12, 58);
            this.FlpItensLoja.Name = "FlpItensLoja";
            this.FlpItensLoja.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FlpItensLoja.Size = new System.Drawing.Size(776, 380);
            this.FlpItensLoja.TabIndex = 2;
            // 
            // FrmLoja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FlpItensLoja);
            this.Controls.Add(this.LblSaldoLoja);
            this.Controls.Add(this.LblTituloLoja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLoja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmLoja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTituloLoja;
        private System.Windows.Forms.Label LblSaldoLoja;
        private System.Windows.Forms.FlowLayoutPanel FlpItensLoja;
    }
}