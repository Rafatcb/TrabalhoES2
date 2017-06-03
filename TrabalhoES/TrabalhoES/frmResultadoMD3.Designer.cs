namespace TrabalhoES
{
    partial class frmResultadoMD3
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
            this.pcbMapasConfronto = new System.Windows.Forms.PictureBox();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.pcbMapa1 = new System.Windows.Forms.PictureBox();
            this.pcbMapa2 = new System.Windows.Forms.PictureBox();
            this.pcbMapa3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMapasConfronto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMapa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMapa2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMapa3)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMapasConfronto
            // 
            this.pcbMapasConfronto.BackColor = System.Drawing.Color.Transparent;
            this.pcbMapasConfronto.Image = global::TrabalhoES.Properties.Resources.Texto_MapasConfronto;
            this.pcbMapasConfronto.Location = new System.Drawing.Point(357, 55);
            this.pcbMapasConfronto.Name = "pcbMapasConfronto";
            this.pcbMapasConfronto.Size = new System.Drawing.Size(652, 51);
            this.pcbMapasConfronto.TabIndex = 1;
            this.pcbMapasConfronto.TabStop = false;
            // 
            // pcbSair
            // 
            this.pcbSair.BackColor = System.Drawing.Color.Transparent;
            this.pcbSair.Image = global::TrabalhoES.Properties.Resources.Texto_Sair;
            this.pcbSair.Location = new System.Drawing.Point(1163, 661);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(99, 37);
            this.pcbSair.TabIndex = 21;
            this.pcbSair.TabStop = false;
            this.pcbSair.Click += new System.EventHandler(this.pcbSair_Click);
            this.pcbSair.MouseEnter += new System.EventHandler(this.pcbSair_MouseEnter);
            this.pcbSair.MouseLeave += new System.EventHandler(this.pcbSair_MouseLeave);
            // 
            // pcbMapa1
            // 
            this.pcbMapa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbMapa1.Location = new System.Drawing.Point(508, 201);
            this.pcbMapa1.Name = "pcbMapa1";
            this.pcbMapa1.Size = new System.Drawing.Size(350, 197);
            this.pcbMapa1.TabIndex = 22;
            this.pcbMapa1.TabStop = false;
            // 
            // pcbMapa2
            // 
            this.pcbMapa2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbMapa2.Location = new System.Drawing.Point(330, 404);
            this.pcbMapa2.Name = "pcbMapa2";
            this.pcbMapa2.Size = new System.Drawing.Size(350, 197);
            this.pcbMapa2.TabIndex = 23;
            this.pcbMapa2.TabStop = false;
            // 
            // pcbMapa3
            // 
            this.pcbMapa3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbMapa3.Location = new System.Drawing.Point(686, 404);
            this.pcbMapa3.Name = "pcbMapa3";
            this.pcbMapa3.Size = new System.Drawing.Size(350, 197);
            this.pcbMapa3.TabIndex = 24;
            this.pcbMapa3.TabStop = false;
            // 
            // frmResultadoMD3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabalhoES.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pcbMapa3);
            this.Controls.Add(this.pcbMapa2);
            this.Controls.Add(this.pcbMapa1);
            this.Controls.Add(this.pcbSair);
            this.Controls.Add(this.pcbMapasConfronto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResultadoMD3";
            this.Text = "Mapas do Confronto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmResultadoMD3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMapasConfronto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMapa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMapa2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMapa3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMapasConfronto;
        private System.Windows.Forms.PictureBox pcbSair;
        private System.Windows.Forms.PictureBox pcbMapa1;
        private System.Windows.Forms.PictureBox pcbMapa2;
        private System.Windows.Forms.PictureBox pcbMapa3;
    }
}