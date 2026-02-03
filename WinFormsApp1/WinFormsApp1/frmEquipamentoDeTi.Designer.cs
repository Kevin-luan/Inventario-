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
            SuspendLayout();
            // 
            // btnCadastarEquipamento
            // 
            btnCadastarEquipamento.Location = new Point(12, 370);
            btnCadastarEquipamento.Name = "btnCadastarEquipamento";
            btnCadastarEquipamento.Size = new Size(190, 51);
            btnCadastarEquipamento.TabIndex = 0;
            btnCadastarEquipamento.Text = "Adicionar";
            btnCadastarEquipamento.UseVisualStyleBackColor = true;
            btnCadastarEquipamento.Click += btnCadastarEquipamento_Click;
            // 
            // frmEquipamentoDeTi
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastarEquipamento);
            Name = "frmEquipamentoDeTi";
            Text = "frmEquipamentoDeTi";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastarEquipamento;
    }
}