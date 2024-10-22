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
        string data_source = "datasource=localhost;username=root;password=admin;database=cadastro";

        private string? id_MemBro_Selecionado = null;
        public MySqlConnection Conexao;
        public Cadastro()

        {
            InitializeComponent();
            this.Load += new EventHandler(Cadastro_Load);

        }
        private void Cadastro_Load(object sender, EventArgs e)
        {
            ConfiguraListView();
            CarregarMembros();
        }

        public void CarregarMembros()
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=admin;database=cadastro";

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                string query = "SELECT * FROM membro";
                MySqlCommand cmd = new MySqlCommand(query, Conexao);
                MySqlDataReader reader = cmd.ExecuteReader();

                ListaMembrosLVW.Items.Clear();

                while (reader.Read())
                {


                    var item = new ListViewItem(reader["nome"].ToString());
                    item.SubItems.Add(reader["sexo"].ToString());
                    item.SubItems.Add(reader["cpf"].ToString());
                    item.SubItems.Add(reader["idade"].ToString());
                    item.SubItems.Add(reader["datarecepcao"].ToString());
                    item.SubItems.Add(reader["modorecepcao"].ToString());
                    ListaMembrosLVW.Items.Add(item);

                }
                reader.Close();







            }

            catch (Exception ex)

            {
                MessageBox.Show("Erro ao carregar membros", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {

                Conexao.Close();

            }




        }



        public void ConfiguraListView()
        {

            ListaMembrosLVW.Columns.Clear();
            ListaMembrosLVW.View = View.Details;
            ListaMembrosLVW.FullRowSelect = true;
            ListaMembrosLVW.GridLines = true;
            ListaMembrosLVW.LabelEdit = false;
            ListaMembrosLVW.ShowItemToolTips = false;
            ListaMembrosLVW.MultiSelect = false;

            ListaMembrosLVW.Columns.Add("Nome", 150);
            ListaMembrosLVW.Columns.Add("Sexo", 150);
            ListaMembrosLVW.Columns.Add("CPF", 100);
            ListaMembrosLVW.Columns.Add("Idade", 50);
            ListaMembrosLVW.Columns.Add("Data Recepção", 150);
            ListaMembrosLVW.Columns.Add("Modo de Recepção", 150);




        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {



                string data_source = "datasource=localhost;username=root;password=admin;database=cadastro";

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                if (id_MemBro_Selecionado != null)
                {
                    //update


                    cmd.CommandText = "UPDATE membro SET " +
                        "nome=@nome,sexo=@sexo,idade=@idade,datarecepcao=@datarecepcao,modorecepcao=@modorecepcao WHERE cpf= @cpf";


                    cmd.Parameters.AddWithValue("@nome", NomeTxt.Text);
                    cmd.Parameters.AddWithValue("@sexo", SexoTxt.Text);
                    cmd.Parameters.AddWithValue("@cpf", id_MemBro_Selecionado);
                    cmd.Parameters.AddWithValue("@idade", IdadeTxt.Text);
                    cmd.Parameters.AddWithValue("@datarecepcao", DataRecTxt.Text);
                    cmd.Parameters.AddWithValue("@modorecepcao", ModoRecTxt.Text);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();







                    MessageBox.Show("Contato atualizado com sucesso");
                }



                else
                {
                    cmd.CommandText = "INSERT INTO membro(nome,sexo,cpf,idade,datarecepcao,modorecepcao) VALUES (@nome,@sexo,@cpf,@idade,@datarecepcao,@modorecepcao)";


                    cmd.Parameters.AddWithValue("@nome", NomeTxt.Text);
                    cmd.Parameters.AddWithValue("@sexo", SexoTxt.Text);
                    cmd.Parameters.AddWithValue("@cpf", CPFTxt.Text);
                    cmd.Parameters.AddWithValue("@idade", IdadeTxt.Text);
                    cmd.Parameters.AddWithValue("@datarecepcao", DataRecTxt.Text);
                    cmd.Parameters.AddWithValue("@modorecepcao", ModoRecTxt.Text);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();







                    MessageBox.Show("Membro Registrado");
                }


                LimpaLista();

                CarregarMembros();

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




        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = ListaMembrosLVW.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {


                id_MemBro_Selecionado = (item.SubItems[2].Text);


                NomeTxt.Text = item.SubItems[0].Text;
                SexoTxt.Text = item.SubItems[1].Text;
                CPFTxt.Text = item.SubItems[2].Text;
                IdadeTxt.Text = item.SubItems[3].Text;
                DataRecTxt.Text = item.SubItems[4].Text;
                ModoRecTxt.Text = item.SubItems[5].Text;

                ExcluirBT.Visible = true;




            }

        }

        private void CPFTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtualizaListaBT_Click(object sender, EventArgs e)
        {
            CarregarMembros();

        }

        public void LimpaLista() {

            id_MemBro_Selecionado = null;
            NomeTxt.Text = String.Empty;
            SexoTxt.Text = "";
            CPFTxt.Text = "";
            IdadeTxt.Text = "";
            DataRecTxt.Text = "";
            ModoRecTxt.Text = "";
            ExcluirBT.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpaLista();
        }

        public void ExcluirBT_Click(object sender, EventArgs e)
        {

            try {

                DialogResult conf = MessageBox.Show("Deseja Realmente Excluir?",
                                                      "Atenção! Esta Ação Não Tem Volta",
                                                      MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (conf==DialogResult.Yes) {

                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conexao;

                    cmd.CommandText = "DELETE FROM membro WHERE cpf= @cpf ";
                      
                    cmd.Parameters.AddWithValue("@cpf", id_MemBro_Selecionado);
                   
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Membro Excluído Com Sucesso!",
                        "Sucesso",MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CarregarMembros();
                    LimpaLista();
                }
            
            
            }
            catch (MySqlException ex) {
                MessageBox.Show("Erro"+ex.Number +"Ocorreu:" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            finally {

                Conexao.Close();
            
            }



        }
    }
}
