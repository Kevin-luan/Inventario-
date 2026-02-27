namespace WinFormsApp1
{
    partial class frmEquipamentoDeTi
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
            btnCadastarEquipamento = new Button();
            lstEquipamentosTi = new ListView();
            pictureBox1 = new PictureBox();
            lblIdEquioamentoTI = new Label();
            txtIdEquipamentoTi = new TextBox();
            txtEquipamentoTi = new TextBox();
            lblEquipamentoTI = new Label();
            txtQuantidade = new TextBox();
            lblQuantidade = new Label();
            txtModeleoEquipamentoTI = new TextBox();
            lblModelo = new Label();
            btnVoltar = new Button();
            btnDeletarPessoas = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCadastarEquipamento
            // 
            btnCadastarEquipamento.Location = new Point(2, 409);
            btnCadastarEquipamento.Name = "btnCadastarEquipamento";
            btnCadastarEquipamento.Size = new Size(190, 52);
            btnCadastarEquipamento.TabIndex = 0;
            btnCadastarEquipamento.Text = "Adicionar";
            btnCadastarEquipamento.UseVisualStyleBackColor = true;
            btnCadastarEquipamento.Click += btnCadastarEquipamento_Click;
            // 
            // lstEquipamentosTi
            // 
            lstEquipamentosTi.Location = new Point(2, 12);
            lstEquipamentosTi.MultiSelect = false;
            lstEquipamentosTi.Name = "lstEquipamentosTi";
            lstEquipamentosTi.Size = new Size(441, 391);
            lstEquipamentosTi.TabIndex = 1;
            lstEquipamentosTi.UseCompatibleStateImageBehavior = false;
            lstEquipamentosTi.SelectedIndexChanged += lstEquipamentosTi_SelectedIndexChanged;
            lstEquipamentosTi.MouseClick += lstEquipamentosTi_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(462, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 391);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblIdEquioamentoTI
            // 
            lblIdEquioamentoTI.AutoSize = true;
            lblIdEquioamentoTI.Location = new Point(475, 22);
            lblIdEquioamentoTI.Name = "lblIdEquioamentoTI";
            lblIdEquioamentoTI.Size = new Size(27, 23);
            lblIdEquioamentoTI.TabIndex = 3;
            lblIdEquioamentoTI.Text = "ID";
            // 
            // txtIdEquipamentoTi
            // 
            txtIdEquipamentoTi.Location = new Point(475, 48);
            txtIdEquipamentoTi.Name = "txtIdEquipamentoTi";
            txtIdEquipamentoTi.Size = new Size(38, 30);
            txtIdEquipamentoTi.TabIndex = 4;
            // 
            // txtEquipamentoTi
            // 
            txtEquipamentoTi.Location = new Point(475, 118);
            txtEquipamentoTi.Name = "txtEquipamentoTi";
            txtEquipamentoTi.Size = new Size(216, 30);
            txtEquipamentoTi.TabIndex = 6;
            // 
            // lblEquipamentoTI
            // 
            lblEquipamentoTI.AutoSize = true;
            lblEquipamentoTI.Location = new Point(475, 92);
            lblEquipamentoTI.Name = "lblEquipamentoTI";
            lblEquipamentoTI.Size = new Size(164, 23);
            lblEquipamentoTI.TabIndex = 5;
            lblEquipamentoTI.Text = "Nome Equipamento";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(478, 196);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(35, 30);
            txtQuantidade.TabIndex = 8;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(475, 161);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(100, 23);
            lblQuantidade.TabIndex = 7;
            lblQuantidade.Text = "Quantidade";
            // 
            // txtModeleoEquipamentoTI
            // 
            txtModeleoEquipamentoTI.Location = new Point(478, 277);
            txtModeleoEquipamentoTI.Name = "txtModeleoEquipamentoTI";
            txtModeleoEquipamentoTI.Size = new Size(219, 30);
            txtModeleoEquipamentoTI.TabIndex = 10;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(475, 242);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(122, 23);
            lblModelo.TabIndex = 9;
            lblModelo.Text = "Modelo/Marca";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(253, 409);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(190, 52);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnDeletarPessoas
            // 
            btnDeletarPessoas.BackColor = Color.IndianRed;
            btnDeletarPessoas.Location = new Point(479, 346);
            btnDeletarPessoas.Name = "btnDeletarPessoas";
            btnDeletarPessoas.Size = new Size(94, 33);
            btnDeletarPessoas.TabIndex = 12;
            btnDeletarPessoas.Text = "Deletar";
            btnDeletarPessoas.UseVisualStyleBackColor = false;
            btnDeletarPessoas.Click += btnDeletarPessoas_Click;
            // 
            // frmEquipamentoDeTi
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 529);
            Controls.Add(btnDeletarPessoas);
            Controls.Add(btnVoltar);
            Controls.Add(txtModeleoEquipamentoTI);
            Controls.Add(lblModelo);
            Controls.Add(txtQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(txtEquipamentoTi);
            Controls.Add(lblEquipamentoTI);
            Controls.Add(txtIdEquipamentoTi);
            Controls.Add(lblIdEquioamentoTI);
            Controls.Add(pictureBox1);
            Controls.Add(lstEquipamentosTi);
            Controls.Add(btnCadastarEquipamento);
            Name = "frmEquipamentoDeTi";
            Text = " ";
            Load += frmEquipamentoDeTi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastarEquipamento;
        private ListView lstEquipamentosTi;
        private PictureBox pictureBox1;
        private Label lblIdEquioamentoTI;
        private TextBox txtIdEquipamentoTi;
        private TextBox txtEquipamentoTi;
        private Label lblEquipamentoTI;
        private TextBox txtQuantidade;
        private Label lblQuantidade;
        private TextBox txtModeleoEquipamentoTI;
        private Label lblModelo;
        private Button btnVoltar;
        private Button btnDeletarPessoas;
    }
}