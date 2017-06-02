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
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.pcbContinuar = new System.Windows.Forms.PictureBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContinuar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
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
            // pcbSair
            // 
            this.pcbSair.BackColor = System.Drawing.Color.Transparent;
            this.pcbSair.Image = global::TrabalhoES.Properties.Resources.Texto_Sair;
            this.pcbSair.Location = new System.Drawing.Point(1163, 661);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(99, 37);
            this.pcbSair.TabIndex = 11;
            this.pcbSair.TabStop = false;
            this.pcbSair.Click += new System.EventHandler(this.pcbSair_Click);
            this.pcbSair.MouseEnter += new System.EventHandler(this.pcbSair_MouseEnter);
            this.pcbSair.MouseLeave += new System.EventHandler(this.pcbSair_MouseLeave);
            // 
            // pcbContinuar
            // 
            this.pcbContinuar.BackColor = System.Drawing.Color.Transparent;
            this.pcbContinuar.Image = global::TrabalhoES.Properties.Resources.Texto_Continuar;
            this.pcbContinuar.Location = new System.Drawing.Point(552, 520);
            this.pcbContinuar.Name = "pcbContinuar";
            this.pcbContinuar.Size = new System.Drawing.Size(261, 51);
            this.pcbContinuar.TabIndex = 10;
            this.pcbContinuar.TabStop = false;
            this.pcbContinuar.Click += new System.EventHandler(this.pcbContinuar_Click);
            this.pcbContinuar.MouseEnter += new System.EventHandler(this.pcbContinuar_MouseEnter);
            this.pcbContinuar.MouseLeave += new System.EventHandler(this.pcbContinuar_MouseLeave);
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.Image = global::TrabalhoES.Properties.Resources.CS_GO_Logo;
            this.pcbLogo.Location = new System.Drawing.Point(410, 50);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(546, 126);
            this.pcbLogo.TabIndex = 12;
            this.pcbLogo.TabStop = false;
            // 
            // frmConfronto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabalhoES.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.pcbSair);
            this.Controls.Add(this.pcbContinuar);
            this.Controls.Add(this.btnMD5);
            this.Controls.Add(this.btnMD3);
            this.Controls.Add(this.btnMD1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfronto";
            this.Text = "Confronto";
            this.Load += new System.EventHandler(this.frmConfronto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContinuar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMD1;
        private System.Windows.Forms.Button btnMD3;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.PictureBox pcbSair;
        private System.Windows.Forms.PictureBox pcbContinuar;
        private System.Windows.Forms.PictureBox pcbLogo;
    }
}

