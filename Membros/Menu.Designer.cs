namespace Membros
{
    partial class Cadastro
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
            button1 = new Button();
            label1 = new Label();
            NomeTxt = new TextBox();
            SexoTxt = new TextBox();
            CPFTxt = new TextBox();
            IdadeTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(222, 336);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 36);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 1;
            label1.Text = "Registrar Novo Membro";
            // 
            // NomeTxt
            // 
            NomeTxt.Location = new Point(159, 111);
            NomeTxt.Name = "NomeTxt";
            NomeTxt.Size = new Size(244, 23);
            NomeTxt.TabIndex = 2;
            // 
            // SexoTxt
            // 
            SexoTxt.Location = new Point(159, 163);
            SexoTxt.Name = "SexoTxt";
            SexoTxt.Size = new Size(244, 23);
            SexoTxt.TabIndex = 3;
            // 
            // CPFTxt
            // 
            CPFTxt.Location = new Point(159, 211);
            CPFTxt.Name = "CPFTxt";
            CPFTxt.Size = new Size(138, 23);
            CPFTxt.TabIndex = 4;
            // 
            // IdadeTxt
            // 
            IdadeTxt.Location = new Point(159, 258);
            IdadeTxt.Name = "IdadeTxt";
            IdadeTxt.Size = new Size(75, 23);
            IdadeTxt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 111);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 163);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 7;
            label3.Text = "Sexo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 211);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 8;
            label4.Text = "CPF:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 258);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Idade:";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 425);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(IdadeTxt);
            Controls.Add(CPFTxt);
            Controls.Add(SexoTxt);
            Controls.Add(NomeTxt);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Novo Membro";
            Load += Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox NomeTxt;
        private TextBox SexoTxt;
        private TextBox CPFTxt;
        private TextBox IdadeTxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}