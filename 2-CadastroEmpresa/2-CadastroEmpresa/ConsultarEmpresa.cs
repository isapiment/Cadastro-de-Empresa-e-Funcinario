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
    public partial class ConsultarEmpresa : Form
    {
        private List<Empresa> emp = new List<Empresa>();
        public ConsultarEmpresa()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu form1 = new Menu();
            this.Visible = false;
            form1.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroEmpresa form5 = new CadastroEmpresa();
            this.Visible = false;
            form5.ShowDialog();
            this.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = emp;
        }
    }
}
