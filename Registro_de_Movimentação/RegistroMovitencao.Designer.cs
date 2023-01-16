namespace Registro_de_Movimentação
{
    partial class RegistroMovitencao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroMovitencao));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadCentroCustos = new System.Windows.Forms.Button();
            this.labelNumPaciente = new System.Windows.Forms.Label();
            this.comboMotivo = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.txtMedResponsavel = new System.Windows.Forms.TextBox();
            this.txtCentroCusto = new System.Windows.Forms.TextBox();
            this.txtLeito = new System.Windows.Forms.TextBox();
            this.txtLocInterna = new System.Windows.Forms.TextBox();
            this.txtNomeClinica = new System.Windows.Forms.TextBox();
            this.txtCNS = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnColecao = new System.Windows.Forms.Button();
            this.txtNumProntuario = new System.Windows.Forms.TextBox();
            this.txtNumPaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.dtDataSaida = new System.Windows.Forms.DateTimePicker();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1258, 484);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnLoadCentroCustos
            // 
            this.btnLoadCentroCustos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadCentroCustos.Location = new System.Drawing.Point(840, 16);
            this.btnLoadCentroCustos.MaximumSize = new System.Drawing.Size(19, 20);
            this.btnLoadCentroCustos.MinimumSize = new System.Drawing.Size(19, 20);
            this.btnLoadCentroCustos.Name = "btnLoadCentroCustos";
            this.btnLoadCentroCustos.Size = new System.Drawing.Size(19, 20);
            this.btnLoadCentroCustos.TabIndex = 6;
            this.btnLoadCentroCustos.Text = "🔎";
            this.btnLoadCentroCustos.UseVisualStyleBackColor = true;
            this.btnLoadCentroCustos.Click += new System.EventHandler(this.btnLoadCentroCustos_Click);
            // 
            // labelNumPaciente
            // 
            this.labelNumPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNumPaciente.AutoSize = true;
            this.labelNumPaciente.Location = new System.Drawing.Point(244, 17);
            this.labelNumPaciente.MaximumSize = new System.Drawing.Size(160, 13);
            this.labelNumPaciente.Name = "labelNumPaciente";
            this.labelNumPaciente.Size = new System.Drawing.Size(0, 13);
            this.labelNumPaciente.TabIndex = 67;
            // 
            // comboMotivo
            // 
            this.comboMotivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboMotivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboMotivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboMotivo.FormattingEnabled = true;
            this.comboMotivo.Items.AddRange(new object[] {
            "Internado",
            "Óbito",
            "Alta",
            "Evasão",
            " "});
            this.comboMotivo.Location = new System.Drawing.Point(171, 91);
            this.comboMotivo.Name = "comboMotivo";
            this.comboMotivo.Size = new System.Drawing.Size(112, 21);
            this.comboMotivo.TabIndex = 4;
            this.comboMotivo.SelectedIndexChanged += new System.EventHandler(this.comboMotivo_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(1186, 54);
            this.btnDelete.MaximumSize = new System.Drawing.Size(86, 31);
            this.btnDelete.MinimumSize = new System.Drawing.Size(86, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(1186, 12);
            this.btnSave.MaximumSize = new System.Drawing.Size(86, 31);
            this.btnSave.MinimumSize = new System.Drawing.Size(86, 31);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiagnostico.Location = new System.Drawing.Point(1058, 68);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(100, 55);
            this.txtDiagnostico.TabIndex = 12;
            // 
            // txtCRM
            // 
            this.txtCRM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCRM.Location = new System.Drawing.Point(1059, 41);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(100, 20);
            this.txtCRM.TabIndex = 11;
            // 
            // txtMedResponsavel
            // 
            this.txtMedResponsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMedResponsavel.Location = new System.Drawing.Point(1059, 14);
            this.txtMedResponsavel.Name = "txtMedResponsavel";
            this.txtMedResponsavel.Size = new System.Drawing.Size(100, 20);
            this.txtMedResponsavel.TabIndex = 10;
            // 
            // txtCentroCusto
            // 
            this.txtCentroCusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCentroCusto.Location = new System.Drawing.Point(734, 16);
            this.txtCentroCusto.Name = "txtCentroCusto";
            this.txtCentroCusto.Size = new System.Drawing.Size(100, 20);
            this.txtCentroCusto.TabIndex = 5;
            // 
            // txtLeito
            // 
            this.txtLeito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLeito.Location = new System.Drawing.Point(734, 68);
            this.txtLeito.Name = "txtLeito";
            this.txtLeito.Size = new System.Drawing.Size(100, 20);
            this.txtLeito.TabIndex = 8;
            // 
            // txtLocInterna
            // 
            this.txtLocInterna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLocInterna.Location = new System.Drawing.Point(734, 43);
            this.txtLocInterna.Name = "txtLocInterna";
            this.txtLocInterna.Size = new System.Drawing.Size(100, 20);
            this.txtLocInterna.TabIndex = 7;
            // 
            // txtNomeClinica
            // 
            this.txtNomeClinica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeClinica.Location = new System.Drawing.Point(734, 94);
            this.txtNomeClinica.Name = "txtNomeClinica";
            this.txtNomeClinica.Size = new System.Drawing.Size(100, 20);
            this.txtNomeClinica.TabIndex = 9;
            // 
            // txtCNS
            // 
            this.txtCNS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCNS.Location = new System.Drawing.Point(171, 65);
            this.txtCNS.Name = "txtCNS";
            this.txtCNS.Size = new System.Drawing.Size(112, 20);
            this.txtCNS.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(32, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 16);
            this.label16.TabIndex = 65;
            this.label16.Text = "*Motivo:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(901, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "*Diagnostico:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(901, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 62;
            this.label12.Text = "*CRM:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(901, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 16);
            this.label13.TabIndex = 60;
            this.label13.Text = "*Médico Responsavel:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(576, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 16);
            this.label15.TabIndex = 57;
            this.label15.Text = "*Centro de Custo:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "*Leito:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(576, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "*Localização interna:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(576, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "Clinica Médica:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "*CNS:";
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoraEntrada.Checked = false;
            this.txtHoraEntrada.Enabled = false;
            this.txtHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHoraEntrada.Location = new System.Drawing.Point(453, 42);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(85, 20);
            this.txtHoraEntrada.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(314, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 81;
            this.label10.Text = "Hora:";
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataEntrada.Checked = false;
            this.txtDataEntrada.CustomFormat = "";
            this.txtDataEntrada.Enabled = false;
            this.txtDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataEntrada.Location = new System.Drawing.Point(453, 16);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(85, 20);
            this.txtDataEntrada.TabIndex = 80;
            // 
            // btnColecao
            // 
            this.btnColecao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnColecao.Location = new System.Drawing.Point(219, 14);
            this.btnColecao.MaximumSize = new System.Drawing.Size(19, 20);
            this.btnColecao.MinimumSize = new System.Drawing.Size(19, 20);
            this.btnColecao.Name = "btnColecao";
            this.btnColecao.Size = new System.Drawing.Size(19, 20);
            this.btnColecao.TabIndex = 2;
            this.btnColecao.Text = "🔎";
            this.btnColecao.UseVisualStyleBackColor = true;
            this.btnColecao.Click += new System.EventHandler(this.btnColecao_Click);
            // 
            // txtNumProntuario
            // 
            this.txtNumProntuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumProntuario.Location = new System.Drawing.Point(171, 40);
            this.txtNumProntuario.Name = "txtNumProntuario";
            this.txtNumProntuario.Size = new System.Drawing.Size(43, 20);
            this.txtNumProntuario.TabIndex = 2;
            this.txtNumProntuario.TextChanged += new System.EventHandler(this.txtNumProntuario_TextChanged);
            // 
            // txtNumPaciente
            // 
            this.txtNumPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumPaciente.Location = new System.Drawing.Point(171, 14);
            this.txtNumPaciente.Name = "txtNumPaciente";
            this.txtNumPaciente.Size = new System.Drawing.Size(43, 20);
            this.txtNumPaciente.TabIndex = 1;
            this.txtNumPaciente.Leave += new System.EventHandler(this.txtNumPaciente_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 77;
            this.label4.Text = "Data:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 76;
            this.label3.Text = "*Número do Prontuário:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 75;
            this.label2.Text = "*Número do Paciente:";
            // 
            // dtHoraSaida
            // 
            this.dtHoraSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtHoraSaida.Checked = false;
            this.dtHoraSaida.Enabled = false;
            this.dtHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraSaida.Location = new System.Drawing.Point(453, 94);
            this.dtHoraSaida.Name = "dtHoraSaida";
            this.dtHoraSaida.Size = new System.Drawing.Size(85, 20);
            this.dtHoraSaida.TabIndex = 86;
            this.dtHoraSaida.Visible = false;
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHoraSaida.AutoSize = true;
            this.lblHoraSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraSaida.Location = new System.Drawing.Point(314, 93);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(96, 16);
            this.lblHoraSaida.TabIndex = 85;
            this.lblHoraSaida.Text = "Hora da saida:";
            this.lblHoraSaida.Visible = false;
            // 
            // dtDataSaida
            // 
            this.dtDataSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtDataSaida.Checked = false;
            this.dtDataSaida.CustomFormat = "";
            this.dtDataSaida.Enabled = false;
            this.dtDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataSaida.Location = new System.Drawing.Point(453, 68);
            this.dtDataSaida.Name = "dtDataSaida";
            this.dtDataSaida.Size = new System.Drawing.Size(85, 20);
            this.dtDataSaida.TabIndex = 84;
            this.dtDataSaida.Visible = false;
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSaida.Location = new System.Drawing.Point(314, 69);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(95, 16);
            this.lblDataSaida.TabIndex = 83;
            this.lblDataSaida.Text = "Data da saida:";
            this.lblDataSaida.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Location = new System.Drawing.Point(1186, 94);
            this.btnClear.MaximumSize = new System.Drawing.Size(86, 31);
            this.btnClear.MinimumSize = new System.Drawing.Size(86, 31);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 31);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // RegistroMovitencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 657);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtHoraSaida);
            this.Controls.Add(this.lblHoraSaida);
            this.Controls.Add(this.dtDataSaida);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.btnColecao);
            this.Controls.Add(this.txtNumProntuario);
            this.Controls.Add(this.txtNumPaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoadCentroCustos);
            this.Controls.Add(this.labelNumPaciente);
            this.Controls.Add(this.comboMotivo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(this.txtMedResponsavel);
            this.Controls.Add(this.txtCentroCusto);
            this.Controls.Add(this.txtLeito);
            this.Controls.Add(this.txtLocInterna);
            this.Controls.Add(this.txtNomeClinica);
            this.Controls.Add(this.txtCNS);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroMovitencao";
            this.Text = "Registo de movimentação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLoadCentroCustos;
        private System.Windows.Forms.Label labelNumPaciente;
        private System.Windows.Forms.ComboBox comboMotivo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.TextBox txtMedResponsavel;
        private System.Windows.Forms.TextBox txtCentroCusto;
        private System.Windows.Forms.TextBox txtLeito;
        private System.Windows.Forms.TextBox txtLocInterna;
        private System.Windows.Forms.TextBox txtNomeClinica;
        private System.Windows.Forms.TextBox txtCNS;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtHoraEntrada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtDataEntrada;
        private System.Windows.Forms.Button btnColecao;
        private System.Windows.Forms.TextBox txtNumProntuario;
        private System.Windows.Forms.TextBox txtNumPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtHoraSaida;
        private System.Windows.Forms.Label lblHoraSaida;
        private System.Windows.Forms.DateTimePicker dtDataSaida;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Button btnClear;
    }
}

