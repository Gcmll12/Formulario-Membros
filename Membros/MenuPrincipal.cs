using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Membros
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void CadastraMembroBT_Click(object sender, EventArgs e)
        {

            try
            {

                var menu2 = new Cadastro();

                menu2.Show();

            }

            catch
            {


            }


        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ExcluiMembroBT_Click(object sender, EventArgs e)
        {

        }
    }
}
