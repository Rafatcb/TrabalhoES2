using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoES
{
    public partial class frmResultadoMD1 : Form
    {
        public frmResultadoMD1()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmResultadoMD1_Load(object sender, EventArgs e)
        {
            // Fazer switch para mudar o background da pcbMapa de acordo com o vencedor
            switch (Resources.Global.mapaVencedor)
            {
                case 0:
                    pcbMapa.BackgroundImage = Properties.Resources.Cache;
                    break;
                case 1:
                    pcbMapa.BackgroundImage = Properties.Resources.Cobblestone;
                    break;
                case 2:
                    pcbMapa.BackgroundImage = Properties.Resources.Inferno;
                    break;
                case 3:
                    pcbMapa.BackgroundImage = Properties.Resources.Mirage;
                    break;
                case 4:
                    pcbMapa.BackgroundImage = Properties.Resources.Nuke;
                    break;
                case 5:
                    pcbMapa.BackgroundImage = Properties.Resources.Overpass;
                    break;
                case 6:
                    pcbMapa.BackgroundImage = Properties.Resources.Train;
                    break;
            }
        }

        #region Mudar Cursor na Picturebox Sair
        private void pcbSair_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pcbSair_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
        #endregion

        #region [CLICK] Sair
        private void pcbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
