namespace ProjetoJogoCalc
{
    partial class FrmCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreditos));
            this.LblCreditos1 = new System.Windows.Forms.Label();
            this.LblCreditos = new System.Windows.Forms.Label();
            this.GbxCreditos = new System.Windows.Forms.GroupBox();
            this.LblCreditos3 = new System.Windows.Forms.Label();
            this.LblTituloConquistas = new System.Windows.Forms.Label();
            this.PicConquista = new System.Windows.Forms.PictureBox();
            this.LblNomeConquista = new System.Windows.Forms.Label();
            this.LblDescricaoConquista = new System.Windows.Forms.Label();
            this.LblStatusConquista = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GbxCreditos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicConquista)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCreditos1
            // 
            this.LblCreditos1.AutoSize = true;
            this.LblCreditos1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LblCreditos1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreditos1.Location = new System.Drawing.Point(5, 16);
            this.LblCreditos1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCreditos1.Name = "LblCreditos1";
            this.LblCreditos1.Size = new System.Drawing.Size(220, 42);
            this.LblCreditos1.TabIndex = 0;
            this.LblCreditos1.Text = "Jogo desenvolvido por:\r\nDiego Parracho e Yuri Bovo";
            this.LblCreditos1.Click += new System.EventHandler(this.LblCreditos1_Click);
            // 
            // LblCreditos
            // 
            this.LblCreditos.AutoSize = true;
            this.LblCreditos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LblCreditos.Location = new System.Drawing.Point(392, 16);
            this.LblCreditos.Name = "LblCreditos";
            this.LblCreditos.Size = new System.Drawing.Size(178, 42);
            this.LblCreditos.TabIndex = 1;
            this.LblCreditos.Text = "Ajuda externa:\r\nVictor Filipini (Música)\r\n";
            this.LblCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GbxCreditos
            // 
            this.GbxCreditos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbxCreditos.Controls.Add(this.panel1);
            this.GbxCreditos.Controls.Add(this.LblCreditos3);
            this.GbxCreditos.Controls.Add(this.LblCreditos1);
            this.GbxCreditos.Controls.Add(this.LblCreditos);
            this.GbxCreditos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxCreditos.Location = new System.Drawing.Point(12, 7);
            this.GbxCreditos.Name = "GbxCreditos";
            this.GbxCreditos.Size = new System.Drawing.Size(576, 347);
            this.GbxCreditos.TabIndex = 2;
            this.GbxCreditos.TabStop = false;
            // 
            // LblCreditos3
            // 
            this.LblCreditos3.AutoSize = true;
            this.LblCreditos3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LblCreditos3.Location = new System.Drawing.Point(6, 302);
            this.LblCreditos3.Name = "LblCreditos3";
            this.LblCreditos3.Size = new System.Drawing.Size(388, 42);
            this.LblCreditos3.TabIndex = 2;
            this.LblCreditos3.Text = "Jogo desenvolvido como trabalho para a matéria \r\nProgramação Visual e Jogos\r\n";
            // 
            // LblTituloConquistas
            // 
            this.LblTituloConquistas.AutoSize = true;
            this.LblTituloConquistas.Location = new System.Drawing.Point(3, 0);
            this.LblTituloConquistas.Name = "LblTituloConquistas";
            this.LblTituloConquistas.Size = new System.Drawing.Size(94, 21);
            this.LblTituloConquistas.TabIndex = 3;
            this.LblTituloConquistas.Text = "Conquistas";
            // 
            // PicConquista
            // 
            this.PicConquista.Image = global::ProjetoJogoCalc.Properties.Resources.calc;
            this.PicConquista.Location = new System.Drawing.Point(7, 51);
            this.PicConquista.Name = "PicConquista";
            this.PicConquista.Size = new System.Drawing.Size(100, 116);
            this.PicConquista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicConquista.TabIndex = 4;
            this.PicConquista.TabStop = false;
            // 
            // LblNomeConquista
            // 
            this.LblNomeConquista.AutoSize = true;
            this.LblNomeConquista.Location = new System.Drawing.Point(113, 51);
            this.LblNomeConquista.Name = "LblNomeConquista";
            this.LblNomeConquista.Size = new System.Drawing.Size(111, 21);
            this.LblNomeConquista.TabIndex = 5;
            this.LblNomeConquista.Text = "Colecionador";
            // 
            // LblDescricaoConquista
            // 
            this.LblDescricaoConquista.AutoSize = true;
            this.LblDescricaoConquista.Location = new System.Drawing.Point(113, 72);
            this.LblDescricaoConquista.Name = "LblDescricaoConquista";
            this.LblDescricaoConquista.Size = new System.Drawing.Size(326, 21);
            this.LblDescricaoConquista.TabIndex = 6;
            this.LblDescricaoConquista.Text = "Compre todos os itens disponíveis na loja";
            // 
            // LblStatusConquista
            // 
            this.LblStatusConquista.AutoSize = true;
            this.LblStatusConquista.Location = new System.Drawing.Point(113, 146);
            this.LblStatusConquista.Name = "LblStatusConquista";
            this.LblStatusConquista.Size = new System.Drawing.Size(91, 21);
            this.LblStatusConquista.TabIndex = 7;
            this.LblStatusConquista.Text = "Bloqueada";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LblTituloConquistas);
            this.panel1.Controls.Add(this.LblStatusConquista);
            this.panel1.Controls.Add(this.PicConquista);
            this.panel1.Controls.Add(this.LblDescricaoConquista);
            this.panel1.Controls.Add(this.LblNomeConquista);
            this.panel1.Location = new System.Drawing.Point(7, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 184);
            this.panel1.TabIndex = 8;
            // 
            // FrmCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.GbxCreditos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créditos";
            this.GbxCreditos.ResumeLayout(false);
            this.GbxCreditos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicConquista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblCreditos1;
        private System.Windows.Forms.Label LblCreditos;
        private System.Windows.Forms.GroupBox GbxCreditos;
        private System.Windows.Forms.Label LblCreditos3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTituloConquistas;
        private System.Windows.Forms.Label LblStatusConquista;
        private System.Windows.Forms.PictureBox PicConquista;
        private System.Windows.Forms.Label LblDescricaoConquista;
        private System.Windows.Forms.Label LblNomeConquista;
    }
}