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
    public partial class frmConfronto : Form
    {
        public frmConfronto()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region Picturbox Sair e Continuar
        private void pcbSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pcbVoltar_Click(object sender, EventArgs e)
        {
            frmTimes telaTimes = new frmTimes();
            telaTimes.Show();
            this.Hide();
        }
        #endregion

        #region Mudar cursor na Picturebox Continuar, MD1, MD3, MD5 e Sair
        private void pcbContinuar_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pcbContinuar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void pcbSair_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pcbSair_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void pcbMD1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pcbMD1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void pcbMD3_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pcbMD3_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void pcbMD5_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pcbMD5_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void pcbVoltar_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pcbVoltar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
        #endregion

        #region [CLICK] Melhor de
        private void pcbMD1_Click(object sender, EventArgs e)
        {
            Resources.Global.melhorDe = 1;
            frmMapas telaMapas = new frmMapas();
            telaMapas.Show();
            this.Hide();
        }

        private void pcbMD3_Click(object sender, EventArgs e)
        {
            Resources.Global.melhorDe = 3;
            frmMapas telaMapas = new frmMapas();
            telaMapas.Show();
            this.Hide();
        }

        private void pcbMD5_Click(object sender, EventArgs e)
        {
            Resources.Global.melhorDe = 5;
            frmMapas telaMapas = new frmMapas();
            telaMapas.Show();
            this.Hide();
        }
        #endregion
    }
}
