using AppGunaExemplo.Configuracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _2_CadastroEmpresa
{
    public partial class CadastroFunc : Form
    {
        List<Funcionario> func = new List<Funcionario>();

        public object DataGridView1 { get; private set; }

        public CadastroFunc()
        {
            InitializeComponent();
            Consultar();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
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
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = tx_nome.Text;
            funcionario.DateTime = Convert.ToDateTime(tx_datanas.Text);
            funcionario.Cpf = tx_cpf.Text;  
            funcionario.Rg = tx_rg.Text;
            funcionario.Email = tx_email.Text;  
            funcionario.Telefone = tx_tel.Text;
            funcionario.Estado_civil = tx_estcivil.Text;    
            funcionario.Funcao = tx_funcao.Text;
            funcionario.Salario = Convert.ToDouble(tx_salario.Text);  


            if (ExiatemTextBoxsVazios())
            {
                MessageBox.Show("Todos os campos são obrigatórios. Preeencha por favor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Inserir(funcionario);
            }
            
            func.Add(funcionario);
            bool resultado = Validacao.ValidaCpf(tx_cpf.Text);
            

            if (resultado == true)
            {
                button1.Visible = true;
            }

            else if (resultado == false)
            {

               
                MessageBox.Show("CPF inválido!");
            }
        }
        private void Inserir (Funcionario funcionario) 
        { 
            try
            {
                Conexao con = new Conexao();
                var comando = con.Comando("insert into Funcionario values (null, @nome,@data_nasc,@cpf,@rg,@email,@telefone,@estado_civil,@salario)");

                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@data_nasc", funcionario.DateTime);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@rg", funcionario.Rg);
                comando.Parameters.AddWithValue("@email", funcionario.Email);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@estado_civil", funcionario.Estado_civil);
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);
                comando.Parameters.AddWithValue("@funcao", funcionario.Funcao);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0) 
                {
                    MessageBox.Show("Funcionário cadastrado!");
                }

                LimparTextBoxs();
                Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
        private void Consultar()
        {
            try
            {
                var con = new Conexao();
                var comando = con.Comando("Select * from Funcionario");
                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    var funcionario = new Funcionario();
                    funcionario.Id = leitor.GetInt32("id_func");
                    funcionario.Nome = leitor.GetString("nome_func");
                    funcionario.DateTime = leitor.GetDateTime("data_nasc_func");
                    var posicaoColuna = leitor.GetOrdinal("cpf_func");
                    funcionario.Rg = leitor.GetString("rg_func");
                    funcionario.Email = leitor.GetString("email_func");
                    funcionario.Telefone = leitor.GetString("telefone_func");
                    funcionario.Estado_civil = leitor.GetString("estado_civil_func");
                    funcionario.Salario = leitor.GetDouble("salario_func");
                    funcionario.Funcao = leitor.GetString("funcao_func");

                   if ( ! leitor.IsDBNull(posicaoColuna))
                   {
                        funcionario.Cpf = leitor.GetString("cpf_func");
                   }
                    func.Add(funcionario);
                }
                DataGridView1 = func;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimparTextBoxs()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = String.Empty;
                }
            }
        }

        private bool ExiatemTextBoxsVazios()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is MaskedTextBox)
                {
                    var text = control.Text.Replace(",","").Replace("-","").Trim();

                    if (text == "")
                    {
                        return true;
                    }

                }
            }

            return false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tx_cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_funcao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tx_end_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_bairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_numero_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tx_est_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tx_salario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tx_tel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tx_rg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tx_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tx_datanas_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tx_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_estcivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
