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
            lblIdPessoas = new Label();
            lblNomePessoas = new Label();
            lblEmailPessoas = new Label();
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
            btnVoltarfrmMenu.Location = new Point(332, 437);
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
            // lblIdPessoas
            // 
            lblIdPessoas.AutoSize = true;
            lblIdPessoas.BackColor = SystemColors.AppWorkspace;
            lblIdPessoas.Font = new Font("Arial Narrow", 16.2F);
            lblIdPessoas.Location = new Point(502, 126);
            lblIdPessoas.Name = "lblIdPessoas";
            lblIdPessoas.Size = new Size(75, 33);
            lblIdPessoas.TabIndex = 3;
            lblIdPessoas.Text = "aaaaa";
            // 
            // lblNomePessoas
            // 
            lblNomePessoas.AutoSize = true;
            lblNomePessoas.BackColor = SystemColors.AppWorkspace;
            lblNomePessoas.Font = new Font("Arial Narrow", 16.2F);
            lblNomePessoas.Location = new Point(502, 197);
            lblNomePessoas.Name = "lblNomePessoas";
            lblNomePessoas.Size = new Size(135, 33);
            lblNomePessoas.TabIndex = 4;
            lblNomePessoas.Text = "aaaaaaaaaa";
            // 
            // lblEmailPessoas
            // 
            lblEmailPessoas.AutoSize = true;
            lblEmailPessoas.BackColor = SystemColors.AppWorkspace;
            lblEmailPessoas.Font = new Font("Arial Narrow", 16.2F);
            lblEmailPessoas.Location = new Point(502, 257);
            lblEmailPessoas.Name = "lblEmailPessoas";
            lblEmailPessoas.Size = new Size(75, 33);
            lblEmailPessoas.TabIndex = 5;
            lblEmailPessoas.Text = "aaaaa";
            // 
            // btnEditarPessoas
            // 
            btnEditarPessoas.Location = new Point(616, 330);
            btnEditarPessoas.Name = "btnEditarPessoas";
            btnEditarPessoas.Size = new Size(151, 42);
            btnEditarPessoas.TabIndex = 6;
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
            Controls.Add(lblEmailPessoas);
            Controls.Add(lblNomePessoas);
            Controls.Add(lblIdPessoas);
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
        private Label lblIdPessoas;
        private Label lblNomePessoas;
        private Label lblEmailPessoas;
        private Button btnEditarPessoas;
    }
}