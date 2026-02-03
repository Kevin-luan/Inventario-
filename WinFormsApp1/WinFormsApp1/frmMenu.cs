using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnFrmListPessoas_Click(object sender, EventArgs e)
        {
            frmListaPessoas frm = new frmListaPessoas();
            frm.Show();
            this.Hide();
        }

        private void btnEquipamentoTi_Click(object sender, EventArgs e)
        {
            frmEquipamentoDeTi frm = new frmEquipamentoDeTi();
            frm.Show();
            this.Hide();
        }
    }
}
