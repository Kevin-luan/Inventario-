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
            lstEquipamentosTi.FullRowSelect = true;
            lstEquipamentosTi.GridLines = true;


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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }

        private void lstEquipamentosTi_MouseClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_Selecionados = lstEquipamentosTi.SelectedItems;
            foreach (ListViewItem item in itens_Selecionados)
            {
                txtIdEquipamentoTi.Text = item.SubItems[0].Text;
                txtEquipamentoTi.Text = item.SubItems[1].Text;
                txtQuantidade.Text = item.SubItems[2].Text;
                txtModeleoEquipamentoTI.Text = item.SubItems[3].Text;


            }
        }

        private void btnDeletarPessoas_Click(object sender, EventArgs e)
        {
            EquipamentosDeTi equipamento = new EquipamentosDeTi();

            {
                equipamento.idEquipamento = int.Parse(txtIdEquipamentoTi.Text);
            }
            try
            {
                using (var conn = Conexao.GetConnection()) { 
                
                conn.Open();

                    string sql = "DELETE FROM EquipamentosTi WHERE id_equipamento = @equipamento.idEquipamento ";
                    using (var cmd = new MySqlCommand(sql, conn)) {
                        cmd.Parameters.AddWithValue("@equipamento.idEquipamento", equipamento.idEquipamento);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex) {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }

}








