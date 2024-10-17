namespace Membros
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EntrarBt = new Button();
            UsuarioTxt = new TextBox();
            SenhaTxt = new TextBox();
            Usuario = new Label();
            Senha = new Label();
            LoginTxt = new Label();
            CancelarBt = new Button();
            SuspendLayout();
            // 
            // EntrarBt
            // 
            EntrarBt.AllowDrop = true;
            EntrarBt.Location = new Point(170, 169);
            EntrarBt.Name = "EntrarBt";
            EntrarBt.Size = new Size(75, 23);
            EntrarBt.TabIndex = 0;
            EntrarBt.Text = "Entrar";
            EntrarBt.UseVisualStyleBackColor = true;
            EntrarBt.Click += EntrarBt_Click;
            // 
            // UsuarioTxt
            // 
            UsuarioTxt.Location = new Point(105, 73);
            UsuarioTxt.Name = "UsuarioTxt";
            UsuarioTxt.Size = new Size(140, 23);
            UsuarioTxt.TabIndex = 1;
            // 
            // SenhaTxt
            // 
            SenhaTxt.Location = new Point(105, 116);
            SenhaTxt.Name = "SenhaTxt";
            SenhaTxt.Size = new Size(140, 23);
            SenhaTxt.TabIndex = 2;
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Location = new Point(49, 76);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(50, 15);
            Usuario.TabIndex = 3;
            Usuario.Text = "Usuário:";
            Usuario.Click += label1_Click;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(49, 119);
            Senha.Name = "Senha";
            Senha.Size = new Size(42, 15);
            Senha.TabIndex = 4;
            Senha.Text = "Senha:";
            // 
            // LoginTxt
            // 
            LoginTxt.AutoSize = true;
            LoginTxt.Location = new Point(105, 24);
            LoginTxt.Name = "LoginTxt";
            LoginTxt.Size = new Size(37, 15);
            LoginTxt.TabIndex = 5;
            LoginTxt.Text = "Login";
            // 
            // CancelarBt
            // 
            CancelarBt.Location = new Point(67, 169);
            CancelarBt.Name = "CancelarBt";
            CancelarBt.Size = new Size(75, 23);
            CancelarBt.TabIndex = 6;
            CancelarBt.Text = "Cancelar";
            CancelarBt.UseVisualStyleBackColor = true;
            CancelarBt.Click += CancelarBt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 215);
            Controls.Add(CancelarBt);
            Controls.Add(LoginTxt);
            Controls.Add(Senha);
            Controls.Add(Usuario);
            Controls.Add(SenhaTxt);
            Controls.Add(UsuarioTxt);
            Controls.Add(EntrarBt);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Membros.IPB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EntrarBt;
        private TextBox UsuarioTxt;
        private TextBox SenhaTxt;
        private Label Usuario;
        private Label Senha;
        private Label LoginTxt;
        private Button CancelarBt;
    }
}
