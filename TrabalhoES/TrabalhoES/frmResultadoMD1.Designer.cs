namespace TrabalhoES
{
    partial class frmResultadoMD1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultadoMD1));
            this.pcbMapaConfronto = new System.Windows.Forms.PictureBox();
            this.pcbMapa = new System.Windows.Forms.PictureBox();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMapaConfronto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMapaConfronto
            // 
            this.pcbMapaConfronto.BackColor = System.Drawing.Color.Transparent;
            this.pcbMapaConfronto.Image = global::TrabalhoES.Properties.Resources.Texto_MapaConfronto;
            this.pcbMapaConfronto.Location = new System.Drawing.Point(376, 55);
            this.pcbMapaConfronto.Name = "pcbMapaConfronto";
            this.pcbMapaConfronto.Size = new System.Drawing.Size(613, 51);
            this.pcbMapaConfronto.TabIndex = 22;
            this.pcbMapaConfronto.TabStop = false;
            // 
            // pcbMapa
            // 
            this.pcbMapa.Location = new System.Drawing.Point(363, 255);
            this.pcbMapa.Name = "pcbMapa";
            this.pcbMapa.Size = new System.Drawing.Size(640, 360);
            this.pcbMapa.TabIndex = 21;
            this.pcbMapa.TabStop = false;
            // 
            // pcbSair
            // 
            this.pcbSair.BackColor = System.Drawing.Color.Transparent;
            this.pcbSair.Image = global::TrabalhoES.Properties.Resources.Texto_Sair;
            this.pcbSair.Location = new System.Drawing.Point(1163, 661);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(99, 37);
            this.pcbSair.TabIndex = 20;
            this.pcbSair.TabStop = false;
            this.pcbSair.Click += new System.EventHandler(this.pcbSair_Click);
            this.pcbSair.MouseEnter += new System.EventHandler(this.pcbSair_MouseEnter);
            this.pcbSair.MouseLeave += new System.EventHandler(this.pcbSair_MouseLeave);
            // 
            // frmResultadoMD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabalhoES.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pcbMapaConfronto);
            this.Controls.Add(this.pcbMapa);
            this.Controls.Add(this.pcbSair);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResultadoMD1";
            this.Text = "Mapa do Confronto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmResultadoMD1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMapaConfronto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbSair;
        private System.Windows.Forms.PictureBox pcbMapa;
        private System.Windows.Forms.PictureBox pcbMapaConfronto;
    }
}