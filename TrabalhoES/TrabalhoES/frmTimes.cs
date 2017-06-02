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

        private void frmTimes_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        #region Picturbox Sair e Botão Continuar
        private void pcbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbContinuar_Click(object sender, EventArgs e)
        {
            frmConfronto telaConfronto = new frmConfronto();
            telaConfronto.Show();
            this.Hide();
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
