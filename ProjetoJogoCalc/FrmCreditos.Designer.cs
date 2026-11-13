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
            this.LblCreditosText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblCreditosText
            // 
            this.LblCreditosText.AutoSize = true;
            this.LblCreditosText.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LblCreditosText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreditosText.Location = new System.Drawing.Point(2, 9);
            this.LblCreditosText.Name = "LblCreditosText";
            this.LblCreditosText.Size = new System.Drawing.Size(759, 108);
            this.LblCreditosText.TabIndex = 0;
            this.LblCreditosText.Text = "Jogo desenvolvido por:\r\nDiego Parracho e Yuri Bovo\r\n\r\nJogo desenvolvido como trab" +
    "alho para a matéria Programação Visual e Jogos";
            // 
            // FrmCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblCreditosText);
            this.Name = "FrmCreditos";
            this.Text = "Créditos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCreditosText;
    }
}