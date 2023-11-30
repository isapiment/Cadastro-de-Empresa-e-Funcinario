using AppGunaExemplo.Configuracao;
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
    public partial class CadastroEmpresa : Form
    {
        List<Empresa> emp = new List<Empresa>();
        public object DataGridView2 { get; private set; }
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
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
            Empresa empresa = new Empresa();
            empresa.RazaoSocial = tx_razao.Text;
            empresa.NomeFantasia = tx_nomefan.Text;
            empresa.NaturezaJuridica = tx_naturezaju.Text;
            empresa.SituacaoCadastral = tx_situacao.Text;
            empresa.Telefone = tx_tel.Text;
            empresa.CapitalSocial = Convert.ToDouble(tx_capital.Text);


            if (ExiatemTextBoxsVazios())
            {
                MessageBox.Show("Todos os campos são obrigatórios. Preeencha por favor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Inserir(empresa);
            }

            emp.Add(empresa);
        }
        private void Inserir(Empresa empresa)
        {
            try
            {
                Conexao con = new Conexao();
                var comando = con.Comando("insert into Funcionario values (null, @cnpj,@razão_social,@nome_fantasia,@situação_cadastral,@regime_tributário,@data_início_ativ,@telefone,@capital_social,@tipo,@porte_empresa,@natureza_jurídica,@nome_proprietário,@cpf_proprietário)");

                comando.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                comando.Parameters.AddWithValue("@razão_social", empresa.RazaoSocial);
                comando.Parameters.AddWithValue("@nome_fantasia", empresa.NomeFantasia);
                comando.Parameters.AddWithValue("@situação_cadastral", empresa.SituacaoCadastral);
                comando.Parameters.AddWithValue("@regime_tributário", empresa.RegimeTributario);
                comando.Parameters.AddWithValue("@data_início_ativ", empresa.DataInicio);
                comando.Parameters.AddWithValue("@telefone", empresa.Telefone);
                comando.Parameters.AddWithValue("@capital_social", empresa.CapitalSocial);
                comando.Parameters.AddWithValue("@tipo", empresa.Tipo);
                comando.Parameters.AddWithValue("@porte_empresa", empresa.PorteEmpresa);
                comando.Parameters.AddWithValue("@natureza_jurídica", empresa.NaturezaJuridica);
                comando.Parameters.AddWithValue("@nome_proprietário", empresa.NomeProprietario);
                comando.Parameters.AddWithValue("@cpf_proprietário", empresa.CpfProprietario);

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
                var comando = con.Comando("Select * from Empresa");
                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    var empresa = new Empresa();
                    empresa.Id = leitor.GetInt32("id_emp");
                    empresa.RazaoSocial = leitor.GetString("razão_social_emp");
                    empresa.DataInicio= leitor.GetDateTime("data_início_ativ_emp");
                    var posicaoColuna = leitor.GetOrdinal("cnpj_emp");
                    empresa.NomeFantasia= leitor.GetString("nome_fantasia_emp");
                    empresa.SituacaoCadastral = leitor.GetString("situação_cadastral_emp");
                    empresa.RegimeTributario = leitor.GetString("regime_tributário_emp");
                    empresa.Telefone = leitor.GetString("telefone_emp");
                    empresa.CapitalSocial = leitor.GetDouble("capital_social_emp");
                    empresa.Tipo = leitor.GetString("tipo_emp");
                    empresa.PorteEmpresa = leitor.GetString("porte_empresa_emp");
                    empresa.NaturezaJuridica = leitor.GetString("natureza_jurídica_emp");
                    empresa.NomeProprietario = leitor.GetString("nome_proprietário_emp");
                    empresa.CpfProprietario = leitor.GetString("cpf_proprietário_emp");

                    if (!leitor.IsDBNull(posicaoColuna))
                    {
                        empresa.Cnpj = leitor.GetString("cnpj_emp");
                        empresa.CpfProprietario = leitor.GetString("cpf_proprietário_emp");
                    }
                    emp.Add(empresa);
                }
                DataGridView2 = emp;
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
                    var text = control.Text.Replace(",", "").Replace("-", "").Trim();

                    if (text == "")
                    {
                        return true;
                    }

                }
            }

            return false;
        }
    }
}
