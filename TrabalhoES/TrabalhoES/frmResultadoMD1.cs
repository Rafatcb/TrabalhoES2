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

        #region FormLoad
        private void frmResultadoMD1_Load(object sender, EventArgs e)
        {
            switch (Resources.Global.mapaVencedor[0])
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
        #endregion

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
            var result = MessageBox.Show("Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
    }
}
