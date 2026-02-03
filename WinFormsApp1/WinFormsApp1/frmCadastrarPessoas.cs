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
    public partial class frmCadastrarPessoas : Form
    {
        public frmCadastrarPessoas()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoas pessoas = new Pessoas();

            {
                pessoas.nome_pessoas = txbNome.Text;
                pessoas.email_pessoas = txbEmail.Text;
            };
                       
            if (pessoas.nome_pessoas == "")
            {
                MessageBox.Show("todos os campos devem ser preenchidos");
                txbNome.Focus();
            }
            if (pessoas.email_pessoas == "")
            {
                MessageBox.Show("todos os campos devem ser preenchidos");
                txbNome.Focus();
                txbEmail.Focus();
            }
            else
            {
                try
                {
                    using (var conn = Conexao.GetConnection())
                    {
                        conn.Open();

                        string sql = "INSERT INTO Pessoas (nome_pessoas, email_pessoas) VALUES (@nome, @email)";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@nome", pessoas.nome_pessoas);
                            cmd.Parameters.AddWithValue("@email", pessoas.email_pessoas);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Cadastro realizado com sucesso!");
                    txbNome.Clear();
                    txbEmail.Clear();
                    txbNome.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

            }

        }

        private void btnFrnListarPessaos_Click(object sender, EventArgs e)
        {
            frmListaPessoas frmListaPessoas = new frmListaPessoas();
            frmListaPessoas.Show();
            this.Hide();
        }
    }


}
