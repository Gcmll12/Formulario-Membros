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
   /* public partial class ExibirListaMembros : Form

    {
        public ExibirListaMembros()
        {
            InitializeComponent();
            ConfiguraLista();

        }
        public void ConfiguraLista()
        {

            ListaMembrosLVW.View = View.Details;
            ListaMembrosLVW.FullRowSelect = true;
            ListaMembrosLVW.GridLines = true;

            ListaMembrosLVW.Columns.Add("Nome", 150);
            ListaMembrosLVW.Columns.Add("Sexo", 100);
            ListaMembrosLVW.Columns.Add("CPF", 120);
            ListaMembrosLVW.Columns.Add("Idade", 50);


        }

        private void ExibirListaMembros_Load(object sender, EventArgs e)
        {


            CarregarMembros();



        }

        public void CarregarMembros()
        {
            string data_source = "datasource=localhost;username=root;password=admin;database=cadastro";
            using (MySqlConnection Conexao = new MySqlConnection(data_source))
            {

                try
                {
                    Conexao.Open();

                    string sqlListarMembros = "SELECT nome, sexo, cpf, idade FROM membro";
                    MySqlCommand cmd = new MySqlCommand(sqlListarMembros, Conexao);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        ListaMembrosLVW.Items.Clear();

                        while (reader.Read())
                        {

                            ListViewItem item = new ListViewItem(reader["nome"].ToString());
                            item.SubItems.Add(reader["sexo"].ToString());
                            item.SubItems.Add(reader["cpf"].ToString());
                            item.SubItems.Add(reader["idade"].ToString());

                            ListaMembrosLVW.Items.Add(item);



                        }

                    }
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

        }*/

       // void ListaMembrosLVW_SelectedIndexChanged(object sender, EventArgs e)
        //{

      //  }
   // }
}
    

