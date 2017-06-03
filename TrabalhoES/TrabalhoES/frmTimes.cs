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
    public partial class frmTimes : Form
    {
        public frmTimes()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region [CLICK] Sair e Continuar
        private void pcbSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Resources.Global.sair = 1;
                this.Close();
            }
        }

        private void pcbContinuar_Click(object sender, EventArgs e)
        {
            if ((txtTime1.Text == "") || (txtTime2.Text == ""))
            {
                MessageBox.Show("Insira o nome dos dois times", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                Resources.Global.time1 = txtTime1.Text;
                Resources.Global.time2 = txtTime2.Text;
                frmConfronto telaConfronto = new frmConfronto();
                telaConfronto.Show();
                this.Hide();
            }
        }
        #endregion

        #region Mudar cursor na Picturebox Continuar e Sair
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
        #endregion

        #region Mudar de TextBox e Continuar para Confrontos com ENTER
        private void txtTime1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Pressionou ENTER
                txtTime2.Focus();
        }

        private void txtTime2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Pressionou ENTER
                pcbContinuar_Click(sender, e);
        }
        #endregion
    }
}
