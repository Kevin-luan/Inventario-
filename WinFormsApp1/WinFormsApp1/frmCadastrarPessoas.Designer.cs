namespace WinFormsApp1
{
    partial class frmCadastrarPessoas
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
            lblNome = new Label();
            txbNome = new TextBox();
            txbEmail = new TextBox();
            lblEmil = new Label();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(24, 49);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(24, 91);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(310, 30);
            txbNome.TabIndex = 1;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(24, 199);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(310, 30);
            txbEmail.TabIndex = 3;
            // 
            // lblEmil
            // 
            lblEmil.AutoSize = true;
            lblEmil.Location = new Point(24, 157);
            lblEmil.Name = "lblEmil";
            lblEmil.Size = new Size(58, 23);
            lblEmil.TabIndex = 2;
            lblEmil.Text = "E-mail";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(272, 300);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(135, 48);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // frmCadastrarPessoas
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 429);
            Controls.Add(btnCadastrar);
            Controls.Add(txbEmail);
            Controls.Add(lblEmil);
            Controls.Add(txbNome);
            Controls.Add(lblNome);
            Name = "frmCadastrarPessoas";
            Text = "frmCadastrarPessoas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txbNome;
        private TextBox txbEmail;
        private Label lblEmil;
        private Button btnCadastrar;
    }
}