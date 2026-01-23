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
            string nome, email;


            nome = txbNome.Text;
            email = txbEmail.Text;
            if(nome =="" )
            {
                MessageBox.Show("todos os campos devem ser preenchidos");
                txbNome.Focus();
            }
            if (email == "")
            {
                MessageBox.Show("todos os campos devem ser preenchidos");
                txbNome.Focus();
                txbEmail.Focus();
            }
            else { 
            try
            {
                using (var conn = Conexao.GetConnection())
                {
                    conn.Open();

                    string sql = "INSERT INTO Pessoas (nome_pessoas, email_pessoas) VALUES (@nome, @email)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@email", email);
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
    }


}
