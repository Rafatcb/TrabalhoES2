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
    public partial class frmMapas : Form
    {
        short time = 1, mapasVetados = 0, tempo = 60;

        public frmMapas()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /*  ID DOS MAPAS
         *  Cache = 0
         *  Cobblestone = 1
         *  Inferno = 2
         *  Mirage = 3
         *  Nuke = 4
         *  Overpass = 5
         *  Train = 6     */

        short md = Resources.Global.melhorDe; // Variavel Global do Form

        #region Form Load
        private void frmMapas_Load(object sender, EventArgs e)
        {
            TrocarTime();
            tmrVeto.Enabled = true;
            lblTime1.Text = Resources.Global.time1;
            this.lblTime1.Location = new Point(
                (this.Width - lblTime1.Size.Width) / 2, // X
                this.lblTime1.Location.Y // Y
            );
            lblTime2.Text = Resources.Global.time2;
            this.lblTime2.Location = new Point(
                (this.Width - lblTime2.Size.Width) / 2, // X
                this.lblTime2.Location.Y // Y
            );
        }
        #endregion

        #region [PROCEDURE] Troca o time "da vez"
        void TrocarTime()
        {
            if (time == 1)
            {
                time++;
                pcbTime1glow.Visible = true;
                pcbTime2glow.Visible = false;
            }
            else
            {
                time--;
                pcbTime2glow.Visible = true;
                pcbTime1glow.Visible = false;
            }
        }
        #endregion

        #region [PROCEDURE] Verifica se terminou todos os vetos
        void Veto(short idClicada)
        {
            short i = 0, qtd = 0;
            mapasVetados++;
            Resources.Global.mapas[idClicada] = 1;
            AjustarpcbVeto(idClicada);

            if (mapasVetados == 7 - md)
            {
                #region Desabilitando as PictureBox dos Mapas
                pcbCache.Enabled = false;
                pcbCobblestone.Enabled = false;
                pcbInferno.Enabled = false;
                pcbMirage.Enabled = false;
                pcbNuke.Enabled = false;
                pcbOverpass.Enabled = false;
                pcbTrain.Enabled = false;
                pcbTime1.Enabled = false;
                #endregion

                tmrVeto.Enabled = false;
                tmrEspera.Enabled = true;
                while (qtd < md)
                {
                    if (Resources.Global.mapas[i] == 0)
                    {
                        Resources.Global.mapaVencedor[qtd] = i;
                        qtd++;
                    }
                    i++;
                }
            }
            else
            {
                tempo = 60;
                lblTempo.Text = "60";
                TrocarTime();
            }
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            if (md == 1)
            {
                frmResultadoMD1 telaResultado = new frmResultadoMD1();
                telaResultado.Show();
            }
            else if (md == 3)
            {
                frmResultadoMD3 telaResultado = new frmResultadoMD3();
                telaResultado.Show();
            }
            else
            {
                frmResultadoMD5 telaResultado = new frmResultadoMD5();
                telaResultado.Show();
            }
            tmrHide.Enabled = true;
            tmrEspera.Enabled = false;
        }
        #endregion

        #region [PROCEDURE] Ajustar pcbVeto e mudar imagem do mapa
        void AjustarpcbVeto(short id)
        {
            switch (id)
            {
                case 0:
                    pcbCache.BackgroundImage = Properties.Resources.Cache_Veto;
                    pcbCache.Enabled = false;
                    if (time == 2)
                        pcbVeto01.Visible = true;
                    else
                        pcbVeto02.Visible = true;
                    break;
                case 1:
                    pcbCobblestone.BackgroundImage = Properties.Resources.Cobblestone_Veto;
                    pcbCobblestone.Enabled = false;
                    if (time == 2)
                        pcbVeto11.Visible = true;
                    else
                        pcbVeto12.Visible = true;
                    break;
                case 2:
                    pcbInferno.BackgroundImage = Properties.Resources.Inferno_Veto;
                    pcbInferno.Enabled = false;
                    if (time == 2)
                        pcbVeto21.Visible = true;
                    else
                        pcbVeto22.Visible = true;
                    break;
                case 3:
                    pcbMirage.BackgroundImage = Properties.Resources.Mirage_Veto;
                    pcbMirage.Enabled = false;
                    if (time == 2)
                        pcbVeto31.Visible = true;
                    else
                        pcbVeto32.Visible = true;
                    break;
                case 4:
                    pcbNuke.BackgroundImage = Properties.Resources.Nuke_Veto;
                    pcbNuke.Enabled = false;
                    if (time == 2)
                        pcbVeto41.Visible = true;
                    else
                        pcbVeto42.Visible = true;
                    break;
                case 5:
                    pcbOverpass.BackgroundImage = Properties.Resources.Overpass_Veto;
                    pcbOverpass.Enabled = false;
                    if (time == 2)
                        pcbVeto51.Visible = true;
                    else
                        pcbVeto52.Visible = true;
                    break;
                case 6:
                    pcbTrain.BackgroundImage = Properties.Resources.Train_Veto;
                    pcbTime1.Enabled = false;
                    if (time == 2)
                        pcbVeto61.Visible = true;
                    else
                        pcbVeto62.Visible = true;
                    break;
            }
        }
        #endregion

        #region Timers
        private void tmrVeto_Tick(object sender, EventArgs e)
        {
            tempo--;
            lblTempo.Text = tempo.ToString();
            if (tempo == 0)
            {
                TrocarTime();
                tempo = 60;
                lblTempo.Text = "60";
            }
        }

        private void tmrHide_Tick(object sender, EventArgs e)
        {
            this.Hide();
            tmrHide.Enabled = false;
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

        #region Mudar Cursor nas Picturebox
        private void pcbSair_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pcbSair_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void pcbCache_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pcbCache_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void pcbCobblestone_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pcbCobblestone_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void pcbInferno_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pcbInferno_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void pcbMirage_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pcbMirage_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void pcbNuke_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pcbNuke_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void pcbOverpass_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pcbOverpass_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void pcbTrain_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pcbTrain_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
        #endregion

        #region [CLICK] Picturebox Mapas
        private void pcbCache_Click(object sender, EventArgs e)
        {
            Veto(0);
        }

        private void pcbCobblestone_Click(object sender, EventArgs e)
        {
            Veto(1);
        }

        private void pcbInferno_Click(object sender, EventArgs e)
        {
            Veto(2);
        }

        private void pcbMirage_Click(object sender, EventArgs e)
        {
            Veto(3);
        }

        private void pcbNuke_Click(object sender, EventArgs e)
        {
            Veto(4);
        }

        private void pcbOverpass_Click(object sender, EventArgs e)
        {
            Veto(5);
        }

        private void pcbTrain_Click(object sender, EventArgs e)
        {
            Veto(6);
        }
        #endregion
    }
}
