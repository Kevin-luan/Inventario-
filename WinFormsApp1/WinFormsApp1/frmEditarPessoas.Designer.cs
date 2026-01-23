namespace WinFormsApp1
{
    partial class frmEditarPessoas
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
            txtNomePessoas = new TextBox();
            txtEditarPessoas = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtNomePessoas
            // 
            txtNomePessoas.Location = new Point(12, 42);
            txtNomePessoas.Name = "txtNomePessoas";
            txtNomePessoas.Size = new Size(165, 30);
            txtNomePessoas.TabIndex = 0;
            // 
            // txtEditarPessoas
            // 
            txtEditarPessoas.Location = new Point(12, 101);
            txtEditarPessoas.Name = "txtEditarPessoas";
            txtEditarPessoas.Size = new Size(165, 30);
            txtEditarPessoas.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(81, 156);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(96, 33);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // frmEditarPessoas
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(212, 324);
            Controls.Add(btnSalvar);
            Controls.Add(txtEditarPessoas);
            Controls.Add(txtNomePessoas);
            Name = "frmEditarPessoas";
            Text = "frmEditarPessoas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomePessoas;
        private TextBox txtEditarPessoas;
        private Button btnSalvar;
    }
}