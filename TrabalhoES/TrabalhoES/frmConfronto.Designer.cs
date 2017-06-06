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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfronto));
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.pcbMD1 = new System.Windows.Forms.PictureBox();
            this.pcbMD3 = new System.Windows.Forms.PictureBox();
            this.pcbMD5 = new System.Windows.Forms.PictureBox();
            this.pcbVoltar = new System.Windows.Forms.PictureBox();
            this.tmrHide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMD5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoltar)).BeginInit();
            this.SuspendLayout();
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
            // pcbMD1
            // 
            this.pcbMD1.BackColor = System.Drawing.Color.Transparent;
            this.pcbMD1.Image = global::TrabalhoES.Properties.Resources.Texto_MD1;
            this.pcbMD1.Location = new System.Drawing.Point(438, 305);
            this.pcbMD1.Name = "pcbMD1";
            this.pcbMD1.Size = new System.Drawing.Size(489, 65);
            this.pcbMD1.TabIndex = 13;
            this.pcbMD1.TabStop = false;
            this.pcbMD1.Click += new System.EventHandler(this.pcbMD1_Click);
            this.pcbMD1.MouseEnter += new System.EventHandler(this.pcbMD1_MouseEnter);
            this.pcbMD1.MouseLeave += new System.EventHandler(this.pcbMD1_MouseLeave);
            // 
            // pcbMD3
            // 
            this.pcbMD3.BackColor = System.Drawing.Color.Transparent;
            this.pcbMD3.Image = global::TrabalhoES.Properties.Resources.Texto_MD3;
            this.pcbMD3.Location = new System.Drawing.Point(429, 405);
            this.pcbMD3.Name = "pcbMD3";
            this.pcbMD3.Size = new System.Drawing.Size(507, 65);
            this.pcbMD3.TabIndex = 14;
            this.pcbMD3.TabStop = false;
            this.pcbMD3.Click += new System.EventHandler(this.pcbMD3_Click);
            this.pcbMD3.MouseEnter += new System.EventHandler(this.pcbMD3_MouseEnter);
            this.pcbMD3.MouseLeave += new System.EventHandler(this.pcbMD3_MouseLeave);
            // 
            // pcbMD5
            // 
            this.pcbMD5.BackColor = System.Drawing.Color.Transparent;
            this.pcbMD5.Image = global::TrabalhoES.Properties.Resources.Texto_MD5;
            this.pcbMD5.Location = new System.Drawing.Point(430, 505);
            this.pcbMD5.Name = "pcbMD5";
            this.pcbMD5.Size = new System.Drawing.Size(507, 65);
            this.pcbMD5.TabIndex = 15;
            this.pcbMD5.TabStop = false;
            this.pcbMD5.Click += new System.EventHandler(this.pcbMD5_Click);
            this.pcbMD5.MouseEnter += new System.EventHandler(this.pcbMD5_MouseEnter);
            this.pcbMD5.MouseLeave += new System.EventHandler(this.pcbMD5_MouseLeave);
            // 
            // pcbVoltar
            // 
            this.pcbVoltar.BackColor = System.Drawing.Color.Transparent;
            this.pcbVoltar.Image = global::TrabalhoES.Properties.Resources.Texto_Voltar;
            this.pcbVoltar.Location = new System.Drawing.Point(99, 661);
            this.pcbVoltar.Name = "pcbVoltar";
            this.pcbVoltar.Size = new System.Drawing.Size(154, 37);
            this.pcbVoltar.TabIndex = 16;
            this.pcbVoltar.TabStop = false;
            this.pcbVoltar.Click += new System.EventHandler(this.pcbVoltar_Click);
            this.pcbVoltar.MouseEnter += new System.EventHandler(this.pcbVoltar_MouseEnter);
            this.pcbVoltar.MouseLeave += new System.EventHandler(this.pcbVoltar_MouseLeave);
            // 
            // tmrHide
            // 
            this.tmrHide.Interval = 500;
            this.tmrHide.Tick += new System.EventHandler(this.tmrHide_Tick);
            // 
            // frmConfronto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabalhoES.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pcbVoltar);
            this.Controls.Add(this.pcbMD5);
            this.Controls.Add(this.pcbMD3);
            this.Controls.Add(this.pcbMD1);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.pcbSair);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfronto";
            this.Text = "Confronto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMD5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoltar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbSair;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.PictureBox pcbMD1;
        private System.Windows.Forms.PictureBox pcbMD3;
        private System.Windows.Forms.PictureBox pcbMD5;
        private System.Windows.Forms.PictureBox pcbVoltar;
        private System.Windows.Forms.Timer tmrHide;
    }
}

