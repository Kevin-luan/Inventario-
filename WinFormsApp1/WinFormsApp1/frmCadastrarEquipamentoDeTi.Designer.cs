namespace WinFormsApp1
{
    partial class frmCadastrarEquipamentoDeTi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btbCadastrarEquipamentoDeTI = new Button();
            lblNomeEquipamentoTi = new Label();
            txbNomeEquipamentoTi = new TextBox();
            lblModeloEquipamento = new Label();
            txbModeloEquipamentoTi = new TextBox();
            lblQuantEquipamentoTi = new Label();
            txbQuantidade = new TextBox();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // btbCadastrarEquipamentoDeTI
            // 
            btbCadastrarEquipamentoDeTI.Location = new Point(101, 307);
            btbCadastrarEquipamentoDeTI.Name = "btbCadastrarEquipamentoDeTI";
            btbCadastrarEquipamentoDeTI.Size = new Size(124, 60);
            btbCadastrarEquipamentoDeTI.TabIndex = 0;
            btbCadastrarEquipamentoDeTI.Text = "Cadastrar";
            btbCadastrarEquipamentoDeTI.UseVisualStyleBackColor = true;
            btbCadastrarEquipamentoDeTI.Click += btbCadastrarEquipamentoDeTI_Click;
            // 
            // lblNomeEquipamentoTi
            // 
            lblNomeEquipamentoTi.AutoSize = true;
            lblNomeEquipamentoTi.Location = new Point(27, 38);
            lblNomeEquipamentoTi.Name = "lblNomeEquipamentoTi";
            lblNomeEquipamentoTi.Size = new Size(164, 23);
            lblNomeEquipamentoTi.TabIndex = 1;
            lblNomeEquipamentoTi.Text = "Nome Equipamento";
            // 
            // txbNomeEquipamentoTi
            // 
            txbNomeEquipamentoTi.Location = new Point(27, 64);
            txbNomeEquipamentoTi.Name = "txbNomeEquipamentoTi";
            txbNomeEquipamentoTi.Size = new Size(198, 30);
            txbNomeEquipamentoTi.TabIndex = 2;
            // 
            // lblModeloEquipamento
            // 
            lblModeloEquipamento.AutoSize = true;
            lblModeloEquipamento.Location = new Point(27, 143);
            lblModeloEquipamento.Name = "lblModeloEquipamento";
            lblModeloEquipamento.Size = new Size(73, 23);
            lblModeloEquipamento.TabIndex = 3;
            lblModeloEquipamento.Text = "Modelo ";
            // 
            // txbModeloEquipamentoTi
            // 
            txbModeloEquipamentoTi.Location = new Point(27, 169);
            txbModeloEquipamentoTi.Name = "txbModeloEquipamentoTi";
            txbModeloEquipamentoTi.Size = new Size(198, 30);
            txbModeloEquipamentoTi.TabIndex = 4;
            // 
            // lblQuantEquipamentoTi
            // 
            lblQuantEquipamentoTi.AutoSize = true;
            lblQuantEquipamentoTi.Location = new Point(27, 245);
            lblQuantEquipamentoTi.Name = "lblQuantEquipamentoTi";
            lblQuantEquipamentoTi.Size = new Size(100, 23);
            lblQuantEquipamentoTi.TabIndex = 5;
            lblQuantEquipamentoTi.Text = "Quantidade";
            // 
            // txbQuantidade
            // 
            txbQuantidade.Location = new Point(27, 271);
            txbQuantidade.Name = "txbQuantidade";
            txbQuantidade.Size = new Size(198, 30);
            txbQuantidade.TabIndex = 6;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(286, 396);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(111, 42);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmCadastrarEquipamentoDeTi
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 450);
            Controls.Add(btnVoltar);
            Controls.Add(txbQuantidade);
            Controls.Add(lblQuantEquipamentoTi);
            Controls.Add(txbModeloEquipamentoTi);
            Controls.Add(lblModeloEquipamento);
            Controls.Add(txbNomeEquipamentoTi);
            Controls.Add(lblNomeEquipamentoTi);
            Controls.Add(btbCadastrarEquipamentoDeTI);
            Name = "frmCadastrarEquipamentoDeTi";
            Text = "frmCadastrarEquipamentoDeTi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btbCadastrarEquipamentoDeTI;
        private Label lblNomeEquipamentoTi;
        private TextBox txbNomeEquipamentoTi;
        private Label lblModeloEquipamento;
        private TextBox txbModeloEquipamentoTi;
        private Label lblQuantEquipamentoTi;
        private TextBox txbQuantidade;
        private Button btnVoltar;
    }
}