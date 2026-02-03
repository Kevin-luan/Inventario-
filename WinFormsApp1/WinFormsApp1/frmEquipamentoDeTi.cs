using MySqlConnector;
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
    public partial class frmEquipamentoDeTi : Form
    {
        public frmEquipamentoDeTi()
        {
            InitializeComponent();
        }

        private void btnCadastarEquipamento_Click(object sender, EventArgs e)
        {
            frmCadastrarEquipamentoDeTi frm = new frmCadastrarEquipamentoDeTi();
            frm.Show();
            this.Hide();

           
        }
    }
}
