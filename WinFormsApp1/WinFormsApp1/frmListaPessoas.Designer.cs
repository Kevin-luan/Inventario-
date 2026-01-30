namespace WinFormsApp1
{
    partial class frmListaPessoas
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
            lstPessoas = new ListView();
            btnVoltarfrmMenu = new Button();
            pictureBox1 = new PictureBox();
            btnFrmCadastrarPessoas = new Button();
            txtNomePessoas = new TextBox();
            txtIdPessoas = new TextBox();
            txtEmailPessoas = new TextBox();
            btnExcuirPessoas = new Button();
            btnEditarPessoas = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lstPessoas
            // 
            lstPessoas.Location = new Point(35, 43);
            lstPessoas.MultiSelect = false;
            lstPessoas.Name = "lstPessoas";
            lstPessoas.Size = new Size(391, 388);
            lstPessoas.TabIndex = 0;
            lstPessoas.UseCompatibleStateImageBehavior = false;
            lstPessoas.ItemSelectionChanged += lstPessoas_ItemSelectionChanged;
            // 
            // btnVoltarfrmMenu
            // 
            btnVoltarfrmMenu.Location = new Point(694, 506);
            btnVoltarfrmMenu.Name = "btnVoltarfrmMenu";
            btnVoltarfrmMenu.Size = new Size(94, 29);
            btnVoltarfrmMenu.TabIndex = 1;
            btnVoltarfrmMenu.Text = "voltar";
            btnVoltarfrmMenu.UseVisualStyleBackColor = true;
            btnVoltarfrmMenu.Click += btnVoltarfrmMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Location = new Point(489, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 264);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnFrmCadastrarPessoas
            // 
            btnFrmCadastrarPessoas.Location = new Point(35, 437);
            btnFrmCadastrarPessoas.Name = "btnFrmCadastrarPessoas";
            btnFrmCadastrarPessoas.Size = new Size(108, 43);
            btnFrmCadastrarPessoas.TabIndex = 7;
            btnFrmCadastrarPessoas.Text = "Adicionar ";
            btnFrmCadastrarPessoas.UseVisualStyleBackColor = true;
            btnFrmCadastrarPessoas.Click += btnFrmCadastrarPessoas_Click;
            // 
            // txtNomePessoas
            // 
            txtNomePessoas.Location = new Point(501, 122);
            txtNomePessoas.Name = "txtNomePessoas";
            txtNomePessoas.Size = new Size(125, 30);
            txtNomePessoas.TabIndex = 8;
            // 
            // txtIdPessoas
            // 
            txtIdPessoas.Location = new Point(501, 86);
            txtIdPessoas.Name = "txtIdPessoas";
            txtIdPessoas.Size = new Size(125, 30);
            txtIdPessoas.TabIndex = 9;
            // 
            // txtEmailPessoas
            // 
            txtEmailPessoas.Location = new Point(501, 158);
            txtEmailPessoas.Name = "txtEmailPessoas";
            txtEmailPessoas.Size = new Size(125, 30);
            txtEmailPessoas.TabIndex = 10;
            // 
            // btnExcuirPessoas
            // 
            btnExcuirPessoas.BackColor = Color.IndianRed;
            btnExcuirPessoas.Location = new Point(501, 273);
            btnExcuirPessoas.Name = "btnExcuirPessoas";
            btnExcuirPessoas.Size = new Size(109, 39);
            btnExcuirPessoas.TabIndex = 11;
            btnExcuirPessoas.Text = "Deletar";
            btnExcuirPessoas.UseVisualStyleBackColor = false;
            btnExcuirPessoas.Click += btnExcuirPessoas_Click;
            // 
            // btnEditarPessoas
            // 
            btnEditarPessoas.Location = new Point(626, 278);
            btnEditarPessoas.Name = "btnEditarPessoas";
            btnEditarPessoas.Size = new Size(94, 29);
            btnEditarPessoas.TabIndex = 12;
            btnEditarPessoas.Text = "Editar";
            btnEditarPessoas.UseVisualStyleBackColor = true;
            btnEditarPessoas.Click += btnEditarPessoas_Click;
            // 
            // frmListaPessoas
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 537);
            Controls.Add(btnEditarPessoas);
            Controls.Add(btnExcuirPessoas);
            Controls.Add(txtEmailPessoas);
            Controls.Add(txtIdPessoas);
            Controls.Add(txtNomePessoas);
            Controls.Add(btnFrmCadastrarPessoas);
            Controls.Add(pictureBox1);
            Controls.Add(btnVoltarfrmMenu);
            Controls.Add(lstPessoas);
            Name = "frmListaPessoas";
            Text = "frmListaPessoas";
            Load += frmListaPessoas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstPessoas;
        private Button btnVoltarfrmMenu;
        private PictureBox pictureBox1;
        private Button btnFrmCadastrarPessoas;
        private TextBox txtNomePessoas;
        private TextBox txtIdPessoas;
        private TextBox txtEmailPessoas;
        private Button btnExcuirPessoas;
        private Button btnEditarPessoas;
    }
}