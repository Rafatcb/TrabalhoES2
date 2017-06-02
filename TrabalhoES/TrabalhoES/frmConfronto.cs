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

        private void frmConfronto_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region Picturbox Sair e Botão Continuar
        private void pcbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbContinuar_Click(object sender, EventArgs e)
        {
            //frmConfronto telaConfronto = new frmConfronto();  Colocar aqui a prox tela
            //telaConfronto.Show();
            //this.Hide();
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
    }
}
