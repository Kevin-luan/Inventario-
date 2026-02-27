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
    public partial class frmCadastrarEquipamentoDeTi : Form
    {
        public frmCadastrarEquipamentoDeTi()
        {
            InitializeComponent();
        }

        private void btbCadastrarEquipamentoDeTI_Click(object sender, EventArgs e)
        {
            EquipamentosDeTi equipamentosDeTi = new EquipamentosDeTi();
            equipamentosDeTi.Nome_equipamento = txbNomeEquipamentoTi.Text;
            equipamentosDeTi.Modelo = txbModeloEquipamentoTi.Text;
            equipamentosDeTi.Quantidade = int.Parse(txbQuantidade.Text);





            try
            {
                using (var conn = Conexao.GetConnection())
                {
                    conn.Open();
                    string sql = "INSERT INTO EquipamentosTi (nome_equipamento, quantidade, modelo_equipamento) VALUES (@nome, @quantidade,@modelo)";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {

                        cmd.Parameters.AddWithValue("@nome", equipamentosDeTi.Nome_equipamento);
                        cmd.Parameters.AddWithValue("@quantidade", equipamentosDeTi.Quantidade);
                        cmd.Parameters.AddWithValue("@modelo", equipamentosDeTi.Modelo);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cadastro realizado com sucesso!");
                        txbNomeEquipamentoTi.Clear();
                        txbModeloEquipamentoTi.Clear();
                        txbQuantidade.Clear();


                    }



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmEquipamentoDeTi frm = new frmEquipamentoDeTi();
            frm.Show();
            this.Hide();
        }
    }
}
