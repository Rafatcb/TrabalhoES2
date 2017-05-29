namespace TrabalhoES
{
    partial class frmConfronto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMD1 = new System.Windows.Forms.Button();
            this.btnMD3 = new System.Windows.Forms.Button();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMD1
            // 
            this.btnMD1.Location = new System.Drawing.Point(185, 26);
            this.btnMD1.Name = "btnMD1";
            this.btnMD1.Size = new System.Drawing.Size(95, 28);
            this.btnMD1.TabIndex = 0;
            this.btnMD1.Text = "Melhor de 1";
            this.btnMD1.UseVisualStyleBackColor = true;
            // 
            // btnMD3
            // 
            this.btnMD3.Location = new System.Drawing.Point(185, 60);
            this.btnMD3.Name = "btnMD3";
            this.btnMD3.Size = new System.Drawing.Size(95, 28);
            this.btnMD3.TabIndex = 1;
            this.btnMD3.Text = "Melhor de 3";
            this.btnMD3.UseVisualStyleBackColor = true;
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(185, 94);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(95, 28);
            this.btnMD5.TabIndex = 2;
            this.btnMD5.Text = "Melhor de 5";
            this.btnMD5.UseVisualStyleBackColor = true;
            // 
            // frmConfronto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 174);
            this.Controls.Add(this.btnMD5);
            this.Controls.Add(this.btnMD3);
            this.Controls.Add(this.btnMD1);
            this.Name = "frmConfronto";
            this.Text = "Confronto";
            this.Load += new System.EventHandler(this.frmConfronto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMD1;
        private System.Windows.Forms.Button btnMD3;
        private System.Windows.Forms.Button btnMD5;
    }
}

