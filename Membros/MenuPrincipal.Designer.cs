namespace Membros
{
    partial class MenuPrincipal
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
            CadastraMembroBT = new Button();
            ExibeMembroBT = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CadastraMembroBT
            // 
            CadastraMembroBT.Cursor = Cursors.Hand;
            CadastraMembroBT.Location = new Point(260, 45);
            CadastraMembroBT.Name = "CadastraMembroBT";
            CadastraMembroBT.Size = new Size(141, 105);
            CadastraMembroBT.TabIndex = 0;
            CadastraMembroBT.Text = "Cadastrar Membro";
            CadastraMembroBT.UseVisualStyleBackColor = true;
            CadastraMembroBT.Click += CadastraMembroBT_Click;
            // 
            // ExibeMembroBT
            // 
            ExibeMembroBT.Cursor = Cursors.Hand;
            ExibeMembroBT.Location = new Point(101, 45);
            ExibeMembroBT.Name = "ExibeMembroBT";
            ExibeMembroBT.Size = new Size(141, 105);
            ExibeMembroBT.TabIndex = 1;
            ExibeMembroBT.Text = "Exibir Lista de Membros";
            ExibeMembroBT.UseVisualStyleBackColor = true;
         
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ExibeMembroBT);
            groupBox1.Controls.Add(CadastraMembroBT);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(74, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(637, 325);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione Uma Opção:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button CadastraMembroBT;
        private Button ExibeMembroBT;
        private GroupBox groupBox1;
    }
}