namespace _2_CadastroEmpresa
{
    partial class CadastroEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroEmpresa));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tx_situacao = new System.Windows.Forms.ComboBox();
            this.tx_nomefan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tx_capital = new System.Windows.Forms.MaskedTextBox();
            this.tx_tel = new System.Windows.Forms.MaskedTextBox();
            this.tx_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.tx_razao = new System.Windows.Forms.TextBox();
            this.tx_cpfpro = new System.Windows.Forms.MaskedTextBox();
            this.tx_nomepro = new System.Windows.Forms.TextBox();
            this.tx_naturezaju = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tx_bairro = new System.Windows.Forms.TextBox();
            this.tx_numero = new System.Windows.Forms.NumericUpDown();
            this.tx_est = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.tx_datainic = new System.Windows.Forms.MaskedTextBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_numero)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(930, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 57);
            this.button1.TabIndex = 131;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(726, 638);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 57);
            this.button3.TabIndex = 130;
            this.button3.Text = "Voltar ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 582);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 195);
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // tx_situacao
            // 
            this.tx_situacao.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_situacao.FormattingEnabled = true;
            this.tx_situacao.Items.AddRange(new object[] {
            "Ativa",
            "Nula",
            "Suspensa",
            "Inapta",
            "Baixada"});
            this.tx_situacao.Location = new System.Drawing.Point(943, 114);
            this.tx_situacao.Name = "tx_situacao";
            this.tx_situacao.Size = new System.Drawing.Size(158, 33);
            this.tx_situacao.TabIndex = 127;
            // 
            // tx_nomefan
            // 
            this.tx_nomefan.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_nomefan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nomefan.Location = new System.Drawing.Point(220, 159);
            this.tx_nomefan.Name = "tx_nomefan";
            this.tx_nomefan.Size = new System.Drawing.Size(453, 30);
            this.tx_nomefan.TabIndex = 126;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 28);
            this.label13.TabIndex = 118;
            this.label13.Text = "Nome Fantasia:";
            // 
            // tx_capital
            // 
            this.tx_capital.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_capital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_capital.Location = new System.Drawing.Point(906, 202);
            this.tx_capital.Mask = "000,000";
            this.tx_capital.Name = "tx_capital";
            this.tx_capital.Size = new System.Drawing.Size(88, 30);
            this.tx_capital.TabIndex = 117;
            this.tx_capital.ValidatingType = typeof(System.DateTime);
            // 
            // tx_tel
            // 
            this.tx_tel.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_tel.Location = new System.Drawing.Point(831, 157);
            this.tx_tel.Mask = "(99) 00000-0000";
            this.tx_tel.Name = "tx_tel";
            this.tx_tel.Size = new System.Drawing.Size(174, 30);
            this.tx_tel.TabIndex = 116;
            // 
            // tx_cnpj
            // 
            this.tx_cnpj.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cnpj.Location = new System.Drawing.Point(888, 278);
            this.tx_cnpj.Mask = "000,000,000/0000-00";
            this.tx_cnpj.Name = "tx_cnpj";
            this.tx_cnpj.Size = new System.Drawing.Size(200, 30);
            this.tx_cnpj.TabIndex = 115;
            this.tx_cnpj.ValidatingType = typeof(System.DateTime);
            // 
            // tx_razao
            // 
            this.tx_razao.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_razao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_razao.Location = new System.Drawing.Point(193, 119);
            this.tx_razao.Name = "tx_razao";
            this.tx_razao.Size = new System.Drawing.Size(483, 30);
            this.tx_razao.TabIndex = 114;
            // 
            // tx_cpfpro
            // 
            this.tx_cpfpro.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_cpfpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cpfpro.Location = new System.Drawing.Point(294, 366);
            this.tx_cpfpro.Mask = "000,000,000-00";
            this.tx_cpfpro.Name = "tx_cpfpro";
            this.tx_cpfpro.PasswordChar = '*';
            this.tx_cpfpro.Size = new System.Drawing.Size(163, 30);
            this.tx_cpfpro.TabIndex = 113;
            // 
            // tx_nomepro
            // 
            this.tx_nomepro.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_nomepro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nomepro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tx_nomepro.Location = new System.Drawing.Point(304, 327);
            this.tx_nomepro.Name = "tx_nomepro";
            this.tx_nomepro.Size = new System.Drawing.Size(493, 30);
            this.tx_nomepro.TabIndex = 111;
            // 
            // tx_naturezaju
            // 
            this.tx_naturezaju.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_naturezaju.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_naturezaju.FormattingEnabled = true;
            this.tx_naturezaju.Items.AddRange(new object[] {
            "EI – Empresário Individual",
            "MEI – Microempreendedor Individual",
            "Sociedade Anônima",
            "Sociedade Simples Limitada",
            "Sociedade Limitada Unipessoal"});
            this.tx_naturezaju.Location = new System.Drawing.Point(497, 275);
            this.tx_naturezaju.Name = "tx_naturezaju";
            this.tx_naturezaju.Size = new System.Drawing.Size(290, 33);
            this.tx_naturezaju.TabIndex = 110;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 43);
            this.label12.TabIndex = 109;
            this.label12.Text = "Endereço";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(685, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 28);
            this.label10.TabIndex = 107;
            this.label10.Text = "Situação Cadastral:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(685, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 28);
            this.label8.TabIndex = 105;
            this.label8.Text = "Telefone: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.label7.Location = new System.Drawing.Point(7, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 28);
            this.label7.TabIndex = 104;
            this.label7.Text = "Razão Social:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.label5.Location = new System.Drawing.Point(6, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 28);
            this.label5.TabIndex = 102;
            this.label5.Text = "CPF do Proprietário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.label4.Location = new System.Drawing.Point(7, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 28);
            this.label4.TabIndex = 101;
            this.label4.Text = "Regime Tributário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.label1.Location = new System.Drawing.Point(7, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 28);
            this.label1.TabIndex = 100;
            this.label1.Text = "Nome do Proprietário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 45);
            this.label2.TabIndex = 98;
            this.label2.Text = "Cadastro de Empresa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(280, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(524, 71);
            this.label3.TabIndex = 99;
            this.label3.Text = "......................................";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(251, 204);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(169, 26);
            this.radioButton1.TabIndex = 132;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Simples Nacional";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(439, 204);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(166, 26);
            this.radioButton2.TabIndex = 133;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Lucro Presumido";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(621, 204);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 26);
            this.radioButton3.TabIndex = 134;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Real";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(697, 201);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(177, 28);
            this.label19.TabIndex = 136;
            this.label19.Text = "Capital Social:";
            // 
            // tx_cidade
            // 
            this.tx_cidade.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cidade.Location = new System.Drawing.Point(109, 546);
            this.tx_cidade.Name = "tx_cidade";
            this.tx_cidade.Size = new System.Drawing.Size(513, 30);
            this.tx_cidade.TabIndex = 146;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(168, 461);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 30);
            this.textBox1.TabIndex = 145;
            // 
            // tx_bairro
            // 
            this.tx_bairro.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_bairro.Location = new System.Drawing.Point(96, 500);
            this.tx_bairro.Name = "tx_bairro";
            this.tx_bairro.Size = new System.Drawing.Size(469, 30);
            this.tx_bairro.TabIndex = 144;
            // 
            // tx_numero
            // 
            this.tx_numero.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_numero.Location = new System.Drawing.Point(644, 502);
            this.tx_numero.Name = "tx_numero";
            this.tx_numero.Size = new System.Drawing.Size(120, 30);
            this.tx_numero.TabIndex = 143;
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
            this.tx_est.Location = new System.Drawing.Point(762, 547);
            this.tx_est.Name = "tx_est";
            this.tx_est.Size = new System.Drawing.Size(232, 33);
            this.tx_est.TabIndex = 142;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(593, 501);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 29);
            this.label17.TabIndex = 141;
            this.label17.Text = "Nº:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(662, 547);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 29);
            this.label16.TabIndex = 140;
            this.label16.Text = "Estado:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 547);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 29);
            this.label15.TabIndex = 139;
            this.label15.Text = "Cidade:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 500);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 29);
            this.label14.TabIndex = 138;
            this.label14.Text = "Bairro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 461);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 29);
            this.label11.TabIndex = 137;
            this.label11.Text = "Rua, Av., etc.:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(7, 275);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 28);
            this.label20.TabIndex = 147;
            this.label20.Text = "Tipo:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(169, 278);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(68, 26);
            this.radioButton4.TabIndex = 149;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Filial";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(82, 278);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(78, 26);
            this.radioButton5.TabIndex = 148;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Matriz";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(553, 239);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(335, 28);
            this.label18.TabIndex = 151;
            this.label18.Text = "Data de Início de Atividade:";
            // 
            // tx_datainic
            // 
            this.tx_datainic.BackColor = System.Drawing.Color.GhostWhite;
            this.tx_datainic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_datainic.Location = new System.Drawing.Point(930, 237);
            this.tx_datainic.Mask = "00/00/0000";
            this.tx_datainic.Name = "tx_datainic";
            this.tx_datainic.Size = new System.Drawing.Size(123, 30);
            this.tx_datainic.TabIndex = 150;
            this.tx_datainic.ValidatingType = typeof(System.DateTime);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(445, 241);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(91, 26);
            this.radioButton6.TabIndex = 155;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Grande";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(360, 242);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(79, 26);
            this.radioButton7.TabIndex = 154;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Médio";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(251, 240);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(103, 26);
            this.radioButton8.TabIndex = 153;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Pequeno";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.label21.Location = new System.Drawing.Point(6, 239);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(227, 28);
            this.label21.TabIndex = 152;
            this.label21.Text = "Porte da Empresa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 28);
            this.label6.TabIndex = 156;
            this.label6.Text = "Natureza Jurídica:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(793, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 28);
            this.label9.TabIndex = 157;
            this.label9.Text = "CNPJ:";
            // 
            // CadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 733);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tx_datainic);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tx_bairro);
            this.Controls.Add(this.tx_numero);
            this.Controls.Add(this.tx_est);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tx_situacao);
            this.Controls.Add(this.tx_nomefan);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tx_capital);
            this.Controls.Add(this.tx_tel);
            this.Controls.Add(this.tx_cnpj);
            this.Controls.Add(this.tx_razao);
            this.Controls.Add(this.tx_cpfpro);
            this.Controls.Add(this.tx_nomepro);
            this.Controls.Add(this.tx_naturezaju);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "CadastroEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "From5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_numero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox tx_situacao;
        private System.Windows.Forms.TextBox tx_nomefan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox tx_capital;
        private System.Windows.Forms.MaskedTextBox tx_tel;
        private System.Windows.Forms.MaskedTextBox tx_cnpj;
        private System.Windows.Forms.TextBox tx_razao;
        private System.Windows.Forms.MaskedTextBox tx_cpfpro;
        private System.Windows.Forms.TextBox tx_nomepro;
        private System.Windows.Forms.ComboBox tx_naturezaju;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tx_bairro;
        private System.Windows.Forms.NumericUpDown tx_numero;
        private System.Windows.Forms.ComboBox tx_est;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox tx_datainic;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}