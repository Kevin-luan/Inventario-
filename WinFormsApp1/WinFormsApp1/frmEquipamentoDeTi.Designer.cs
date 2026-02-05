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
            // lstEquipamentosTi
            // 
            lstEquipamentosTi.Location = new Point(12, 12);
            lstEquipamentosTi.Name = "lstEquipamentosTi";
            lstEquipamentosTi.Size = new Size(441, 337);
            lstEquipamentosTi.TabIndex = 1;
            lstEquipamentosTi.UseCompatibleStateImageBehavior = false;
            lstEquipamentosTi.SelectedIndexChanged += lstEquipamentosTi_SelectedIndexChanged;
            // 
            // frmEquipamentoDeTi
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEquipamentosTi);
            Controls.Add(btnCadastarEquipamento);
            Name = "frmEquipamentoDeTi";
            Text = " ";
            Load += frmEquipamentoDeTi_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastarEquipamento;
        private ListView lstEquipamentosTi;
    }
}