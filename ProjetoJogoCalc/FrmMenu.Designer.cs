namespace ProjetoJogoCalc
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.LblMenu = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnCreditos = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnComoJogarMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.Location = new System.Drawing.Point(136, 36);
            this.LblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(334, 39);
            this.LblMenu.TabIndex = 0;
            this.LblMenu.Text = "Calculadora (In)Útil";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(224, 101);
            this.BtnIniciar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(138, 59);
            this.BtnIniciar.TabIndex = 1;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnCreditos
            // 
            this.BtnCreditos.Location = new System.Drawing.Point(224, 227);
            this.BtnCreditos.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreditos.Name = "BtnCreditos";
            this.BtnCreditos.Size = new System.Drawing.Size(138, 59);
            this.BtnCreditos.TabIndex = 2;
            this.BtnCreditos.Text = "Créditos";
            this.BtnCreditos.UseVisualStyleBackColor = true;
            this.BtnCreditos.Click += new System.EventHandler(this.BtnCreditos_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(224, 297);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(138, 58);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnComoJogarMenu
            // 
            this.BtnComoJogarMenu.Location = new System.Drawing.Point(224, 164);
            this.BtnComoJogarMenu.Margin = new System.Windows.Forms.Padding(2);
            this.BtnComoJogarMenu.Name = "BtnComoJogarMenu";
            this.BtnComoJogarMenu.Size = new System.Drawing.Size(138, 59);
            this.BtnComoJogarMenu.TabIndex = 4;
            this.BtnComoJogarMenu.Text = "Como Jogar";
            this.BtnComoJogarMenu.UseVisualStyleBackColor = true;
            this.BtnComoJogarMenu.Click += new System.EventHandler(this.BtnComoJogarMenu_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.BtnComoJogarMenu);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnCreditos);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.LblMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnCreditos;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnComoJogarMenu;
    }
}