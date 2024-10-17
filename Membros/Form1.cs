namespace Membros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelarBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntrarBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioTxt.Text.Equals("Gabriel")
                    && SenhaTxt.Text.Equals("1234"))
                { 

                var menu = new MenuPrincipal();
                    menu.Show(this);

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Incorretos",
                        "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    UsuarioTxt.Focus();
                    SenhaTxt.Text = "";
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuário ou Senha Incorretos",
                       ex.Message,
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }
    }
}
