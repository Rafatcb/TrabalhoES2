namespace TrabalhoES
{
    partial class frmTimes
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
            this.txtTime1 = new System.Windows.Forms.TextBox();
            this.txtTime2 = new System.Windows.Forms.TextBox();
            this.pcbVS = new System.Windows.Forms.PictureBox();
            this.pcbContinuar = new System.Windows.Forms.PictureBox();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.pcbTime1 = new System.Windows.Forms.PictureBox();
            this.pcbTime2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContinuar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTime2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTime1
            // 
            this.txtTime1.Font = new System.Drawing.Font("Cambria", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime1.Location = new System.Drawing.Point(281, 374);
            this.txtTime1.MaxLength = 10;
            this.txtTime1.Name = "txtTime1";
            this.txtTime1.Size = new System.Drawing.Size(285, 63);
            this.txtTime1.TabIndex = 0;
            this.txtTime1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtTime1_PreviewKeyDown);
            // 
            // txtTime2
            // 
            this.txtTime2.Font = new System.Drawing.Font("Cambria", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime2.Location = new System.Drawing.Point(798, 374);
            this.txtTime2.Name = "txtTime2";
            this.txtTime2.Size = new System.Drawing.Size(284, 63);
            this.txtTime2.TabIndex = 1;
            this.txtTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtTime2_PreviewKeyDown);
            // 
            // pcbVS
            // 
            this.pcbVS.BackColor = System.Drawing.Color.Transparent;
            this.pcbVS.Image = global::TrabalhoES.Properties.Resources.Texto_VS;
            this.pcbVS.Location = new System.Drawing.Point(599, 340);
            this.pcbVS.Name = "pcbVS";
            this.pcbVS.Size = new System.Drawing.Size(168, 87);
            this.pcbVS.TabIndex = 7;
            this.pcbVS.TabStop = false;
            // 
            // pcbContinuar
            // 
            this.pcbContinuar.BackColor = System.Drawing.Color.Transparent;
            this.pcbContinuar.Image = global::TrabalhoES.Properties.Resources.Texto_Continuar;
            this.pcbContinuar.Location = new System.Drawing.Point(552, 520);
            this.pcbContinuar.Name = "pcbContinuar";
            this.pcbContinuar.Size = new System.Drawing.Size(261, 51);
            this.pcbContinuar.TabIndex = 8;
            this.pcbContinuar.TabStop = false;
            this.pcbContinuar.Click += new System.EventHandler(this.pcbContinuar_Click);
            this.pcbContinuar.MouseEnter += new System.EventHandler(this.pcbContinuar_MouseEnter);
            this.pcbContinuar.MouseLeave += new System.EventHandler(this.pcbContinuar_MouseLeave);
            // 
            // pcbSair
            // 
            this.pcbSair.BackColor = System.Drawing.Color.Transparent;
            this.pcbSair.Image = global::TrabalhoES.Properties.Resources.Texto_Sair;
            this.pcbSair.Location = new System.Drawing.Point(1163, 661);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(99, 37);
            this.pcbSair.TabIndex = 9;
            this.pcbSair.TabStop = false;
            this.pcbSair.Click += new System.EventHandler(this.pcbSair_Click);
            this.pcbSair.MouseEnter += new System.EventHandler(this.pcbSair_MouseEnter);
            this.pcbSair.MouseLeave += new System.EventHandler(this.pcbSair_MouseLeave);
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.Image = global::TrabalhoES.Properties.Resources.CS_GO_Logo;
            this.pcbLogo.Location = new System.Drawing.Point(410, 50);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(546, 126);
            this.pcbLogo.TabIndex = 10;
            this.pcbLogo.TabStop = false;
            // 
            // pcbTime1
            // 
            this.pcbTime1.BackColor = System.Drawing.Color.Transparent;
            this.pcbTime1.Image = global::TrabalhoES.Properties.Resources.Texto_Time1;
            this.pcbTime1.Location = new System.Drawing.Point(285, 262);
            this.pcbTime1.Name = "pcbTime1";
            this.pcbTime1.Size = new System.Drawing.Size(277, 106);
            this.pcbTime1.TabIndex = 11;
            this.pcbTime1.TabStop = false;
            // 
            // pcbTime2
            // 
            this.pcbTime2.BackColor = System.Drawing.Color.Transparent;
            this.pcbTime2.Image = global::TrabalhoES.Properties.Resources.Texto_Time2;
            this.pcbTime2.Location = new System.Drawing.Point(801, 262);
            this.pcbTime2.Name = "pcbTime2";
            this.pcbTime2.Size = new System.Drawing.Size(277, 106);
            this.pcbTime2.TabIndex = 12;
            this.pcbTime2.TabStop = false;
            // 
            // frmTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabalhoES.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pcbTime2);
            this.Controls.Add(this.pcbTime1);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.pcbSair);
            this.Controls.Add(this.pcbContinuar);
            this.Controls.Add(this.pcbVS);
            this.Controls.Add(this.txtTime2);
            this.Controls.Add(this.txtTime1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Times";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcbVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContinuar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTime2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTime1;
        private System.Windows.Forms.TextBox txtTime2;
        private System.Windows.Forms.PictureBox pcbVS;
        private System.Windows.Forms.PictureBox pcbContinuar;
        private System.Windows.Forms.PictureBox pcbSair;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.PictureBox pcbTime1;
        private System.Windows.Forms.PictureBox pcbTime2;
    }
}

