using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        private void frmEquipamentoDeTi_Load(object sender, EventArgs e)
        {

            lstEquipamentosTi.View = View.Details;
            lstEquipamentosTi.Columns.Clear();
      

            lstEquipamentosTi.Columns.Add("ID", 50);
            lstEquipamentosTi.Columns.Add("Nome", 150);
            lstEquipamentosTi.Columns.Add("Quantidade", 80);
            lstEquipamentosTi.Columns.Add("Modelo", 150);
            CadastroEquipamentoti(); // chama o método
        }

        public void CadastroEquipamentoti()
        {
            try
            {
                lstEquipamentosTi.Items.Clear();

                using (var conn = Conexao.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM EquipamentosTi";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var ler = cmd.ExecuteReader())
                    {
                        while (ler.Read())
                        {
                            string[] linha =
                            {
                            ler.GetInt32(0).ToString(),
                            ler.GetString(1),
                            ler.GetInt32(2).ToString(),
                            ler.GetString(3)

                        };

                            var item = new ListViewItem(linha);
                            lstEquipamentosTi.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnCadastarEquipamento_Click(object sender, EventArgs e)
        {
            frmCadastrarEquipamentoDeTi frm = new frmCadastrarEquipamentoDeTi();
            frm.Show();
            this.Hide();
        }

        private void lstEquipamentosTi_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }
    }

}








