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
    public partial class frmResultadoMD3 : Form
    {
        public frmResultadoMD3()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region Form Load
        private void frmResultadoMD3_Load(object sender, EventArgs e)
        {
            #region pcbMapa1
            switch (Resources.Global.mapaVencedor[0])
            {
                case 0:
                    pcbMapa1.BackgroundImage = Properties.Resources.Cache;
                    break;
                case 1:
                    pcbMapa1.BackgroundImage = Properties.Resources.Cobblestone;
                    break;
                case 2:
                    pcbMapa1.BackgroundImage = Properties.Resources.Inferno;
                    break;
                case 3:
                    pcbMapa1.BackgroundImage = Properties.Resources.Mirage;
                    break;
                case 4:
                    pcbMapa1.BackgroundImage = Properties.Resources.Nuke;
                    break;
                case 5:
                    pcbMapa1.BackgroundImage = Properties.Resources.Overpass;
                    break;
                case 6:
                    pcbMapa1.BackgroundImage = Properties.Resources.Train;
                    break;
            }
            #endregion

            #region pcbMapa2
            switch (Resources.Global.mapaVencedor[1])
            { // Nao tem como ser o mapa 0, pq o vetor de mapaVencedor esta ordenado
                case 1:
                    pcbMapa2.BackgroundImage = Properties.Resources.Cobblestone;
                    break;
                case 2:
                    pcbMapa2.BackgroundImage = Properties.Resources.Inferno;
                    break;
                case 3:
                    pcbMapa2.BackgroundImage = Properties.Resources.Mirage;
                    break;
                case 4:
                    pcbMapa2.BackgroundImage = Properties.Resources.Nuke;
                    break;
                case 5:
                    pcbMapa2.BackgroundImage = Properties.Resources.Overpass;
                    break;
                case 6:
                    pcbMapa2.BackgroundImage = Properties.Resources.Train;
                    break;
            }
            #endregion

            #region pcbMapa3
            switch (Resources.Global.mapaVencedor[2])
            { // Nao tem como ser o mapa 0 nem 1, pq o vetor mapaVencedor esta ordenado
                case 2:
                    pcbMapa3.BackgroundImage = Properties.Resources.Inferno;
                    break;
                case 3:
                    pcbMapa3.BackgroundImage = Properties.Resources.Mirage;
                    break;
                case 4:
                    pcbMapa3.BackgroundImage = Properties.Resources.Nuke;
                    break;
                case 5:
                    pcbMapa3.BackgroundImage = Properties.Resources.Overpass;
                    break;
                case 6:
                    pcbMapa3.BackgroundImage = Properties.Resources.Train;
                    break;
            }
            #endregion

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
