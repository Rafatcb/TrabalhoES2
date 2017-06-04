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
    public partial class frmMDIContainer : Form
    {
        public frmMDIContainer()
        {
            InitializeComponent();
        }

        private void frmMDIContainer_Load(object sender, EventArgs e)
        {
            frmTimes telaTimes = new frmTimes();
            telaTimes.MdiParent = this;
            telaTimes.Show();
        }
    }
}
