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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{

    public partial class frmListaPessoas : Form
    {


        public frmListaPessoas()
        {
            InitializeComponent();

        }

        private void frmListaPessoas_Load(object sender, EventArgs e)
        {

            lstPessoas.View = View.Details;
            lstPessoas.FullRowSelect = true;
            lstPessoas.GridLines = true;

            lstPessoas.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstPessoas.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lstPessoas.Columns.Add("Email", 150, HorizontalAlignment.Left);
            BuscarPessoas();

        }

        public void BuscarPessoas()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Conexao.GetConnection())
                {
                    conn.Open();

                    string sql = " Select * from Pessoas";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader ler = cmd.ExecuteReader();

                        while (ler.Read())
                        {
                            string[] linha =
                            {
                             ler.GetInt32(0).ToString(),
                             ler.GetString(1),
                             ler.GetString(2)

                            };
                            var linha_listview = new ListViewItem(linha);
                            lstPessoas.Items.Add(linha_listview);

                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void btnVoltarfrmMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void lstPessoas_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Pessoas pessoas = new Pessoas();
            int id_selecionado;
            ListView.SelectedListViewItemCollection ItensSelecionados = lstPessoas.SelectedItems;
            foreach (ListViewItem item in ItensSelecionados)
            {

                txtIdPessoas.Text = item.SubItems[0].Text;
                txtNomePessoas.Text = item.SubItems[1].Text;
                txtEmailPessoas.Text = item.SubItems[2].Text;

                id_selecionado = Convert.ToInt32(item.SubItems[0].Text);
            }
        }


        private void btnFrmCadastrarPessoas_Click(object sender, EventArgs e)
        {
            frmCadastrarPessoas frmCadastrar = new frmCadastrarPessoas();
            frmCadastrar.Show();
            this.Hide();
        }

        private void btnExcuirPessoas_Click(object sender, EventArgs e)
        {


            Pessoas pessoas = new Pessoas();
            {
                pessoas.Id = txtIdPessoas.Text;
            }


            try
            {
                using (var conn = Conexao.GetConnection())
                {

                    conn.Open();
                    string sql = "DELETE FROM Pessoas WHERE id_pessoas =@Id";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {

                        cmd.Parameters.AddWithValue("@Id", pessoas.Id);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnEditarPessoas_Click(object sender, EventArgs e)
        {

            Pessoas pessoas = new Pessoas();

            ListView.SelectedListViewItemCollection ItensSelecionados = lstPessoas.SelectedItems;
            foreach (ListViewItem item in ItensSelecionados)
            {



                pessoas.Id = txtIdPessoas.Text;
                pessoas.nome_pessoas = txtNomePessoas.Text;
                pessoas.email_pessoas = txtEmailPessoas.Text;
            }

            try
            {
                using (var conn = Conexao.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE Pessoas  SET nome_pessoas = @pessoasnome_pessoas, email_pessoas = @pessoasemail_pessoas  WHERE id_pessoas = @pessoasId";


                    using (var cmd = new MySqlCommand(sql, conn))
                    {

                        cmd.Parameters.AddWithValue("@pessoasId", pessoas.Id);
                        cmd.Parameters.AddWithValue("@pessoasnome_pessoas", pessoas.nome_pessoas);
                        cmd.Parameters.AddWithValue("@pessoasemail_pessoas", pessoas.email_pessoas);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Update realizado");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void lstPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
