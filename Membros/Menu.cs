using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

   

namespace Membros
{
    public partial class Cadastro : Form

    {
        MySqlConnection Conexao;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string data_source = "datasource=localhost;username=root;password=admin;database=cadastro";

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                cmd.CommandText = "INSERT INTO membro(nome,sexo,cpf,idade) VALUES (@nome,@sexo,@cpf,@idade)";
              

                cmd.Parameters.AddWithValue("@nome", NomeTxt.Text);
                cmd.Parameters.AddWithValue("@sexo", SexoTxt.Text);
                cmd.Parameters.AddWithValue("@cpf", CPFTxt.Text);
                cmd.Parameters.AddWithValue("@idade", IdadeTxt.Text);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

              

        
           

       
                MessageBox.Show("Membro Registrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                Conexao.Close();


            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
