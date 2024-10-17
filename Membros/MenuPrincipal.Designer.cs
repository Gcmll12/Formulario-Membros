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
            HistoricoMembroBT = new Button();
            ImprimeMembroBT = new Button();
            ModificaMembroBT = new Button();
            ExcluiMembroBT = new Button();
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
            ExibeMembroBT.Click += ExibeMembroBT_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(HistoricoMembroBT);
            groupBox1.Controls.Add(ImprimeMembroBT);
            groupBox1.Controls.Add(ModificaMembroBT);
            groupBox1.Controls.Add(ExcluiMembroBT);
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
            // HistoricoMembroBT
            // 
            HistoricoMembroBT.Location = new Point(260, 171);
            HistoricoMembroBT.Name = "HistoricoMembroBT";
            HistoricoMembroBT.Size = new Size(141, 105);
            HistoricoMembroBT.TabIndex = 5;
            HistoricoMembroBT.Text = "Ver Histórico Membresia";
            HistoricoMembroBT.UseVisualStyleBackColor = true;
            // 
            // ImprimeMembroBT
            // 
            ImprimeMembroBT.Location = new Point(420, 171);
            ImprimeMembroBT.Name = "ImprimeMembroBT";
            ImprimeMembroBT.Size = new Size(141, 105);
            ImprimeMembroBT.TabIndex = 4;
            ImprimeMembroBT.Text = "Imprimir Lista Membros";
            ImprimeMembroBT.UseVisualStyleBackColor = true;
            // 
            // ModificaMembroBT
            // 
            ModificaMembroBT.Location = new Point(101, 171);
            ModificaMembroBT.Name = "ModificaMembroBT";
            ModificaMembroBT.Size = new Size(141, 105);
            ModificaMembroBT.TabIndex = 3;
            ModificaMembroBT.Text = "Modificar Membro";
            ModificaMembroBT.UseVisualStyleBackColor = true;
            // 
            // ExcluiMembroBT
            // 
            ExcluiMembroBT.Location = new Point(420, 45);
            ExcluiMembroBT.Name = "ExcluiMembroBT";
            ExcluiMembroBT.Size = new Size(141, 105);
            ExcluiMembroBT.TabIndex = 2;
            ExcluiMembroBT.Text = "Excluir Membro";
            ExcluiMembroBT.UseVisualStyleBackColor = true;
            ExcluiMembroBT.Click += ExcluiMembroBT_Click;
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
        private Button ExcluiMembroBT;
        private Button HistoricoMembroBT;
        private Button ImprimeMembroBT;
        private Button ModificaMembroBT;
    }
}