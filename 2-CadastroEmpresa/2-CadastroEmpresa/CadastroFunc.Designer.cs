namespace _2_CadastroEmpresa
{
    partial class CadastroFunc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFunc));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.tx_funcao = new System.Windows.Forms.ComboBox();
            this.tx_end = new System.Windows.Forms.TextBox();
            this.tx_bairro = new System.Windows.Forms.TextBox();
            this.tx_numero = new System.Windows.Forms.NumericUpDown();
            this.tx_est = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tx_salario = new System.Windows.Forms.MaskedTextBox();
            this.tx_tel = new System.Windows.Forms.MaskedTextBox();
            this.tx_rg = new System.Windows.Forms.MaskedTextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tx_datanas = new System.Windows.Forms.MaskedTextBox();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_estcivil = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tx_numero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 45);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cadastro de Funcionário";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(285, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(524, 71);
            this.label3.TabIndex = 18;
            this.label3.Text = "......................................";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tx_cidade
            // 
            this.tx_cidade.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cidade.Location = new System.Drawing.Point(128, 545);
            this.tx_cidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_cidade.Name = "tx_cidade";
            this.tx_cidade.Size = new System.Drawing.Size(513, 30);
            this.tx_cidade.TabIndex = 94;
            this.tx_cidade.TextChanged += new System.EventHandler(this.tx_cidade_TextChanged);
            // 
            // tx_funcao
            // 
            this.tx_funcao.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_funcao.FormattingEnabled = true;
            this.tx_funcao.Items.AddRange(new object[] {
            "Vendedor",
            "Limpeza  ",
            "Administrador ",
            "TEC. Informática "});
            this.tx_funcao.Location = new System.Drawing.Point(859, 242);
            this.tx_funcao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_funcao.Name = "tx_funcao";
            this.tx_funcao.Size = new System.Drawing.Size(159, 33);
            this.tx_funcao.TabIndex = 93;
            this.tx_funcao.SelectedIndexChanged += new System.EventHandler(this.tx_funcao_SelectedIndexChanged);
            // 
            // tx_end
            // 
            this.tx_end.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_end.Location = new System.Drawing.Point(187, 458);
            this.tx_end.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_end.Name = "tx_end";
            this.tx_end.Size = new System.Drawing.Size(453, 30);
            this.tx_end.TabIndex = 92;
            this.tx_end.TextChanged += new System.EventHandler(this.tx_end_TextChanged);
            // 
            // tx_bairro
            // 
            this.tx_bairro.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_bairro.Location = new System.Drawing.Point(128, 498);
            this.tx_bairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_bairro.Name = "tx_bairro";
            this.tx_bairro.Size = new System.Drawing.Size(469, 30);
            this.tx_bairro.TabIndex = 91;
            this.tx_bairro.TextChanged += new System.EventHandler(this.tx_bairro_TextChanged);
            // 
            // tx_numero
            // 
            this.tx_numero.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_numero.Location = new System.Drawing.Point(803, 457);
            this.tx_numero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_numero.Name = "tx_numero";
            this.tx_numero.Size = new System.Drawing.Size(120, 30);
            this.tx_numero.TabIndex = 90;
            this.tx_numero.ValueChanged += new System.EventHandler(this.tx_numero_ValueChanged);
            // 
            // tx_est
            // 
            this.tx_est.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_est.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_est.ForeColor = System.Drawing.Color.Black;
            this.tx_est.FormattingEnabled = true;
            this.tx_est.Items.AddRange(new object[] {
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO) "});
            this.tx_est.Location = new System.Drawing.Point(852, 545);
            this.tx_est.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_est.Name = "tx_est";
            this.tx_est.Size = new System.Drawing.Size(201, 33);
            this.tx_est.TabIndex = 89;
            this.tx_est.SelectedIndexChanged += new System.EventHandler(this.tx_est_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(752, 458);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 29);
            this.label17.TabIndex = 88;
            this.label17.Text = "Nº:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(752, 545);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 29);
            this.label16.TabIndex = 87;
            this.label16.Text = "Estado:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 546);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 29);
            this.label15.TabIndex = 86;
            this.label15.Text = "Cidade:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 498);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 29);
            this.label14.TabIndex = 85;
            this.label14.Text = "Bairro:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 458);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 29);
            this.label13.TabIndex = 84;
            this.label13.Text = "Rua, Av., etc.:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // tx_salario
            // 
            this.tx_salario.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_salario.Location = new System.Drawing.Point(853, 287);
            this.tx_salario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_salario.Mask = "000,000";
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(88, 30);
            this.tx_salario.TabIndex = 83;
            this.tx_salario.ValidatingType = typeof(System.DateTime);
            this.tx_salario.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tx_salario_MaskInputRejected);
            // 
            // tx_tel
            // 
            this.tx_tel.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_tel.Location = new System.Drawing.Point(880, 158);
            this.tx_tel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_tel.Mask = "(99) 00000-0000";
            this.tx_tel.Name = "tx_tel";
            this.tx_tel.Size = new System.Drawing.Size(175, 30);
            this.tx_tel.TabIndex = 82;
            this.tx_tel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tx_tel_MaskInputRejected);
            // 
            // tx_rg
            // 
            this.tx_rg.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_rg.Location = new System.Drawing.Point(80, 287);
            this.tx_rg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_rg.Mask = "00,000,000-00";
            this.tx_rg.Name = "tx_rg";
            this.tx_rg.Size = new System.Drawing.Size(163, 30);
            this.tx_rg.TabIndex = 81;
            this.tx_rg.ValidatingType = typeof(System.DateTime);
            this.tx_rg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tx_rg_MaskInputRejected);
            // 
            // tx_email
            // 
            this.tx_email.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_email.Location = new System.Drawing.Point(115, 332);
            this.tx_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(524, 30);
            this.tx_email.TabIndex = 80;
            this.tx_email.TextChanged += new System.EventHandler(this.tx_email_TextChanged);
            // 
            // tx_cpf
            // 
            this.tx_cpf.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cpf.Location = new System.Drawing.Point(95, 246);
            this.tx_cpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_cpf.Mask = "000,000,000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.PasswordChar = '*';
            this.tx_cpf.Size = new System.Drawing.Size(163, 30);
            this.tx_cpf.TabIndex = 79;
            this.tx_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tx_cpf_MaskInputRejected);
            // 
            // tx_datanas
            // 
            this.tx_datanas.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_datanas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_datanas.Location = new System.Drawing.Point(367, 204);
            this.tx_datanas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_datanas.Mask = "00/00/0000";
            this.tx_datanas.Name = "tx_datanas";
            this.tx_datanas.Size = new System.Drawing.Size(123, 30);
            this.tx_datanas.TabIndex = 78;
            this.tx_datanas.ValidatingType = typeof(System.DateTime);
            this.tx_datanas.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tx_datanas_MaskInputRejected);
            // 
            // tx_nome
            // 
            this.tx_nome.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tx_nome.Location = new System.Drawing.Point(115, 158);
            this.tx_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(524, 30);
            this.tx_nome.TabIndex = 77;
            this.tx_nome.TextChanged += new System.EventHandler(this.tx_nome_TextChanged);
            // 
            // tx_estcivil
            // 
            this.tx_estcivil.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_estcivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_estcivil.FormattingEnabled = true;
            this.tx_estcivil.Items.AddRange(new object[] {
            "Casado",
            "Namorando ",
            "Divorsíado(a)",
            "Viúvo(a)"});
            this.tx_estcivil.Location = new System.Drawing.Point(909, 201);
            this.tx_estcivil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_estcivil.Name = "tx_estcivil";
            this.tx_estcivil.Size = new System.Drawing.Size(159, 33);
            this.tx_estcivil.TabIndex = 76;
            this.tx_estcivil.SelectedIndexChanged += new System.EventHandler(this.tx_estcivil_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 43);
            this.label12.TabIndex = 75;
            this.label12.Text = "Endereço";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(752, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 29);
            this.label11.TabIndex = 74;
            this.label11.Text = "Salário:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(753, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 29);
            this.label10.TabIndex = 73;
            this.label10.Text = "Função:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(752, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 29);
            this.label9.TabIndex = 72;
            this.label9.Text = "Estado Civil: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(752, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 29);
            this.label8.TabIndex = 71;
            this.label8.Text = "Telefone: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 70;
            this.label7.Text = "E-mail:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 29);
            this.label6.TabIndex = 69;
            this.label6.Text = "RG:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 29);
            this.label5.TabIndex = 68;
            this.label5.Text = "CPF:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.label4.Location = new System.Drawing.Point(20, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 28);
            this.label4.TabIndex = 67;
            this.label4.Text = "Data de Nascimento:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.label1.Location = new System.Drawing.Point(20, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 66;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 598);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 137);
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(704, 655);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 57);
            this.button3.TabIndex = 96;
            this.button3.Text = "Voltar ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(908, 655);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 57);
            this.button1.TabIndex = 97;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastroFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 734);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.tx_funcao);
            this.Controls.Add(this.tx_end);
            this.Controls.Add(this.tx_bairro);
            this.Controls.Add(this.tx_numero);
            this.Controls.Add(this.tx_est);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.tx_tel);
            this.Controls.Add(this.tx_rg);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.tx_datanas);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.tx_estcivil);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CadastroFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tx_numero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.ComboBox tx_funcao;
        private System.Windows.Forms.TextBox tx_end;
        private System.Windows.Forms.TextBox tx_bairro;
        private System.Windows.Forms.NumericUpDown tx_numero;
        private System.Windows.Forms.ComboBox tx_est;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox tx_salario;
        private System.Windows.Forms.MaskedTextBox tx_tel;
        private System.Windows.Forms.MaskedTextBox tx_rg;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.MaskedTextBox tx_datanas;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.ComboBox tx_estcivil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}