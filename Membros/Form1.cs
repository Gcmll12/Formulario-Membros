using MySql.Data.MySqlClient;
using System.Runtime.CompilerServices;

namespace Membros
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        public Form1()
        {
            InitializeComponent();
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

                var menu = new Cadastro();
                    menu.CarregarMembros(); 
                    menu.Show(this);

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usu�rio ou Senha Incorretos",
                        "Desculpe", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    UsuarioTxt.Focus();
                    SenhaTxt.Text = "";
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Usu�rio ou Senha Incorretos",
                       ex.Message,
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }
       
    }





}
