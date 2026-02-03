namespace WinFormsApp1
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            btnFrmListPessoas = new Button();
            btnEquipamentoTi = new Button();
            SuspendLayout();
            // 
            // btnFrmListPessoas
            // 
            btnFrmListPessoas.Image = (Image)resources.GetObject("btnFrmListPessoas.Image");
            btnFrmListPessoas.Location = new Point(21, 27);
            btnFrmListPessoas.Name = "btnFrmListPessoas";
            btnFrmListPessoas.Size = new Size(123, 174);
            btnFrmListPessoas.TabIndex = 0;
            btnFrmListPessoas.Text = "Pessoas";
            btnFrmListPessoas.TextAlign = ContentAlignment.BottomCenter;
            btnFrmListPessoas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFrmListPessoas.UseVisualStyleBackColor = true;
            btnFrmListPessoas.Click += btnFrmListPessoas_Click;
            // 
            // btnEquipamentoTi
            // 
            btnEquipamentoTi.Location = new Point(161, 27);
            btnEquipamentoTi.Name = "btnEquipamentoTi";
            btnEquipamentoTi.Size = new Size(123, 174);
            btnEquipamentoTi.TabIndex = 1;
            btnEquipamentoTi.Text = "Equipamento de TI";
            btnEquipamentoTi.TextAlign = ContentAlignment.BottomCenter;
            btnEquipamentoTi.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEquipamentoTi.UseVisualStyleBackColor = true;
            btnEquipamentoTi.Click += btnEquipamentoTi_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEquipamentoTi);
            Controls.Add(btnFrmListPessoas);
            Name = "frmMenu";
            Text = "frmMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFrmListPessoas;
        private Button btnEquipamentoTi;
    }
}