using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_CadastroEmpresa
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarFuncionario form2= new ConsultarFuncionario();
            this.Visible = false;
            form2.ShowDialog();
            this.Visible = true;
        }

        private void Funcionário_Click(object sender, EventArgs e)
        {
            ConsultarEmpresa form3 = new ConsultarEmpresa();
            this.Visible = false;
            form3.ShowDialog();
            this.Visible = true;
        }
    }
}
