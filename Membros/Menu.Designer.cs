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
            NovoBT = new Button();
            label1 = new Label();
            NomeTxt = new TextBox();
            SexoTxt = new TextBox();
            CPFTxt = new TextBox();
            IdadeTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ListaMembrosLVW = new ListView();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            ExcluirBT = new Button();
            button2 = new Button();
            ModoRecTxt = new TextBox();
            label11 = new Label();
            DataRecTxt = new TextBox();
            label10 = new Label();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            label9 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label8 = new Label();
            AtualizaListaBT = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // NovoBT
            // 
            NovoBT.Location = new Point(178, 583);
            NovoBT.Name = "NovoBT";
            NovoBT.Size = new Size(75, 23);
            NovoBT.TabIndex = 0;
            NovoBT.Text = "Registrar";
            NovoBT.UseVisualStyleBackColor = true;
            NovoBT.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(193, 21);
            label1.TabIndex = 1;
            label1.Text = "Registrar Novo Membro";
            // 
            // NomeTxt
            // 
            NomeTxt.Location = new Point(6, 87);
            NomeTxt.Name = "NomeTxt";
            NomeTxt.Size = new Size(244, 23);
            NomeTxt.TabIndex = 2;
            // 
            // SexoTxt
            // 
            SexoTxt.Location = new Point(6, 140);
            SexoTxt.Name = "SexoTxt";
            SexoTxt.Size = new Size(182, 23);
            SexoTxt.TabIndex = 3;
            // 
            // CPFTxt
            // 
            CPFTxt.Location = new Point(6, 196);
            CPFTxt.Name = "CPFTxt";
            CPFTxt.Size = new Size(138, 23);
            CPFTxt.TabIndex = 4;
            CPFTxt.TextChanged += CPFTxt_TextChanged;
            // 
            // IdadeTxt
            // 
            IdadeTxt.Location = new Point(6, 250);
            IdadeTxt.Name = "IdadeTxt";
            IdadeTxt.Size = new Size(75, 23);
            IdadeTxt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 69);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 122);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 7;
            label3.Text = "Sexo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 178);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 8;
            label4.Text = "CPF:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 232);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Idade:";
            // 
            // ListaMembrosLVW
            // 
            ListaMembrosLVW.Location = new Point(367, 80);
            ListaMembrosLVW.Name = "ListaMembrosLVW";
            ListaMembrosLVW.Size = new Size(750, 520);
            ListaMembrosLVW.TabIndex = 10;
            ListaMembrosLVW.UseCompatibleStateImageBehavior = false;
            ListaMembrosLVW.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(367, 44);
            label6.Name = "label6";
            label6.Size = new Size(193, 21);
            label6.TabIndex = 11;
            label6.Text = "Lista Atual de Membros:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.Location = new Point(367, 632);
            label7.Name = "label7";
            label7.Size = new Size(673, 15);
            label7.TabIndex = 12;
            label7.Text = "ATENÇÃO: Para modificar ou excluir um mebro da lista, selecione-o clicando com o mouse, logo após realize a ação desejada!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ExcluirBT);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(ModoRecTxt);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(DataRecTxt);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(IdadeTxt);
            groupBox1.Controls.Add(NovoBT);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(NomeTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(SexoTxt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(CPFTxt);
            groupBox1.Location = new Point(20, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 687);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // ExcluirBT
            // 
            ExcluirBT.Location = new Point(97, 583);
            ExcluirBT.Name = "ExcluirBT";
            ExcluirBT.Size = new Size(75, 23);
            ExcluirBT.TabIndex = 21;
            ExcluirBT.Text = "Excluir";
            ExcluirBT.UseVisualStyleBackColor = true;
            ExcluirBT.Visible = false;
            ExcluirBT.Click += ExcluirBT_Click;
            // 
            // button2
            // 
            button2.Location = new Point(16, 583);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 20;
            button2.Text = "Novo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ModoRecTxt
            // 
            ModoRecTxt.Location = new Point(6, 499);
            ModoRecTxt.Name = "ModoRecTxt";
            ModoRecTxt.Size = new Size(100, 23);
            ModoRecTxt.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 469);
            label11.Name = "label11";
            label11.Size = new Size(109, 15);
            label11.TabIndex = 18;
            label11.Text = "Modo de Recepção";
            // 
            // DataRecTxt
            // 
            DataRecTxt.Location = new Point(6, 429);
            DataRecTxt.Name = "DataRecTxt";
            DataRecTxt.Size = new Size(100, 23);
            DataRecTxt.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 411);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 16;
            label10.Text = "Data de Recepção";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(107, 378);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(120, 19);
            radioButton4.TabIndex = 15;
            radioButton4.TabStop = true;
            radioButton4.Text = "Não Comungante";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 378);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(95, 19);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.Text = "Comungante";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 351);
            label9.Name = "label9";
            label9.Size = new Size(114, 15);
            label9.TabIndex = 13;
            label9.Text = "Situação Membresia";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(60, 308);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 19);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Não";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 308);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(45, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sim";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 290);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 10;
            label8.Text = "Casado";
            label8.Click += label8_Click;
            // 
            // AtualizaListaBT
            // 
            AtualizaListaBT.Location = new Point(982, 51);
            AtualizaListaBT.Name = "AtualizaListaBT";
            AtualizaListaBT.Size = new Size(135, 23);
            AtualizaListaBT.TabIndex = 14;
            AtualizaListaBT.Text = "Atualizar Lista";
            AtualizaListaBT.UseVisualStyleBackColor = true;
            AtualizaListaBT.Click += AtualizaListaBT_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1154, 766);
            Controls.Add(AtualizaListaBT);
            Controls.Add(groupBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ListaMembrosLVW);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Novo Membro";
            Load += Cadastro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NovoBT;
        private Label label1;
        private TextBox NomeTxt;
        private TextBox SexoTxt;
        private TextBox CPFTxt;
        private TextBox IdadeTxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public ListView ListaMembrosLVW;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox ModoRecTxt;
        private Label label11;
        private TextBox DataRecTxt;
        private Label label10;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label label9;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button AtualizaListaBT;
        private Button button2;
        private Button ExcluirBT;
    }
}