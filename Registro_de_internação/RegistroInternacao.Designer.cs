using System;

namespace Registro_de_internação
{
    partial class RegistroInternacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroInternacao));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNumPaciente = new System.Windows.Forms.TextBox();
            this.txtNumProntuario = new System.Windows.Forms.TextBox();
            this.txtCNS = new System.Windows.Forms.TextBox();
            this.txtNomeClinica = new System.Windows.Forms.TextBox();
            this.txtLocInterna = new System.Windows.Forms.TextBox();
            this.txtLeito = new System.Windows.Forms.TextBox();
            this.txtCentroCusto = new System.Windows.Forms.TextBox();
            this.txtHipDiagnostico = new System.Windows.Forms.TextBox();
            this.txtMedResponsavel = new System.Windows.Forms.TextBox();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnColecao = new System.Windows.Forms.Button();
            this.comboSituacao = new System.Windows.Forms.ComboBox();
            this.labelNumPaciente = new System.Windows.Forms.Label();
            this.txtDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnLoadCentroCustos = new System.Windows.Forms.Button();
            this.labelNomeMae = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnMovimentacao = new System.Windows.Forms.Button();
            this.labelNomeCusto = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Número do Paciente:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "*Número do Prontuário:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data de entrada:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "*Leito:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(562, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "*Localização interna:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(264, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nome da clinica:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(264, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "*CNS do paciente:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(932, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Diagnostico:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(932, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "*CRM:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(932, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "*Médico Responsavel:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(562, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Hipótese do Diagnostico:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(562, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 16);
            this.label15.TabIndex = 12;
            this.label15.Text = "*Centro de Custo:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(932, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 16);
            this.label16.TabIndex = 17;
            this.label16.Text = "*Situação:";
            // 
            // txtNumPaciente
            // 
            this.txtNumPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumPaciente.Location = new System.Drawing.Point(153, 47);
            this.txtNumPaciente.MaximumSize = new System.Drawing.Size(39, 20);
            this.txtNumPaciente.MinimumSize = new System.Drawing.Size(39, 20);
            this.txtNumPaciente.Name = "txtNumPaciente";
            this.txtNumPaciente.Size = new System.Drawing.Size(39, 20);
            this.txtNumPaciente.TabIndex = 2;
            this.txtNumPaciente.TabStop = false;
            this.txtNumPaciente.TextChanged += new System.EventHandler(this.txtNumPaciente_TextChanged);
            // 
            // txtNumProntuario
            // 
            this.txtNumProntuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumProntuario.Enabled = false;
            this.txtNumProntuario.Location = new System.Drawing.Point(153, 21);
            this.txtNumProntuario.MaximumSize = new System.Drawing.Size(39, 20);
            this.txtNumProntuario.MinimumSize = new System.Drawing.Size(39, 20);
            this.txtNumProntuario.Name = "txtNumProntuario";
            this.txtNumProntuario.Size = new System.Drawing.Size(39, 20);
            this.txtNumProntuario.TabIndex = 1;
            // 
            // txtCNS
            // 
            this.txtCNS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCNS.Location = new System.Drawing.Point(392, 106);
            this.txtCNS.MaximumSize = new System.Drawing.Size(106, 20);
            this.txtCNS.MinimumSize = new System.Drawing.Size(106, 20);
            this.txtCNS.Name = "txtCNS";
            this.txtCNS.Size = new System.Drawing.Size(106, 20);
            this.txtCNS.TabIndex = 5;
            this.txtCNS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNS_KeyPress);
            // 
            // txtNomeClinica
            // 
            this.txtNomeClinica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeClinica.Location = new System.Drawing.Point(392, 78);
            this.txtNomeClinica.MaximumSize = new System.Drawing.Size(106, 20);
            this.txtNomeClinica.MinimumSize = new System.Drawing.Size(106, 20);
            this.txtNomeClinica.Name = "txtNomeClinica";
            this.txtNomeClinica.Size = new System.Drawing.Size(106, 20);
            this.txtNomeClinica.TabIndex = 4;
            // 
            // txtLocInterna
            // 
            this.txtLocInterna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLocInterna.Location = new System.Drawing.Point(720, 81);
            this.txtLocInterna.MaximumSize = new System.Drawing.Size(77, 20);
            this.txtLocInterna.MinimumSize = new System.Drawing.Size(77, 20);
            this.txtLocInterna.Name = "txtLocInterna";
            this.txtLocInterna.Size = new System.Drawing.Size(77, 20);
            this.txtLocInterna.TabIndex = 9;
            // 
            // txtLeito
            // 
            this.txtLeito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLeito.Location = new System.Drawing.Point(720, 108);
            this.txtLeito.MaximumSize = new System.Drawing.Size(77, 20);
            this.txtLeito.MinimumSize = new System.Drawing.Size(77, 20);
            this.txtLeito.Name = "txtLeito";
            this.txtLeito.Size = new System.Drawing.Size(77, 20);
            this.txtLeito.TabIndex = 10;
            // 
            // txtCentroCusto
            // 
            this.txtCentroCusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCentroCusto.Location = new System.Drawing.Point(720, 25);
            this.txtCentroCusto.MaximumSize = new System.Drawing.Size(77, 20);
            this.txtCentroCusto.MinimumSize = new System.Drawing.Size(77, 20);
            this.txtCentroCusto.Name = "txtCentroCusto";
            this.txtCentroCusto.Size = new System.Drawing.Size(77, 20);
            this.txtCentroCusto.TabIndex = 6;
            this.txtCentroCusto.Leave += new System.EventHandler(this.txtCentroCusto_Leave);
            // 
            // txtHipDiagnostico
            // 
            this.txtHipDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHipDiagnostico.Location = new System.Drawing.Point(720, 53);
            this.txtHipDiagnostico.MaximumSize = new System.Drawing.Size(166, 20);
            this.txtHipDiagnostico.MinimumSize = new System.Drawing.Size(166, 20);
            this.txtHipDiagnostico.Name = "txtHipDiagnostico";
            this.txtHipDiagnostico.Size = new System.Drawing.Size(166, 20);
            this.txtHipDiagnostico.TabIndex = 8;
            // 
            // txtMedResponsavel
            // 
            this.txtMedResponsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMedResponsavel.Location = new System.Drawing.Point(1077, 23);
            this.txtMedResponsavel.MaximumSize = new System.Drawing.Size(100, 20);
            this.txtMedResponsavel.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtMedResponsavel.Name = "txtMedResponsavel";
            this.txtMedResponsavel.Size = new System.Drawing.Size(100, 20);
            this.txtMedResponsavel.TabIndex = 11;
            // 
            // txtCRM
            // 
            this.txtCRM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCRM.Location = new System.Drawing.Point(1077, 50);
            this.txtCRM.MaximumSize = new System.Drawing.Size(100, 20);
            this.txtCRM.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(100, 20);
            this.txtCRM.TabIndex = 12;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiagnostico.Location = new System.Drawing.Point(1077, 106);
            this.txtDiagnostico.MaximumSize = new System.Drawing.Size(100, 43);
            this.txtDiagnostico.MinimumSize = new System.Drawing.Size(100, 43);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(100, 43);
            this.txtDiagnostico.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1261, 484);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(1186, 22);
            this.btnSave.MaximumSize = new System.Drawing.Size(86, 31);
            this.btnSave.MinimumSize = new System.Drawing.Size(86, 31);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(1186, 55);
            this.btnDelete.MaximumSize = new System.Drawing.Size(86, 31);
            this.btnDelete.MinimumSize = new System.Drawing.Size(86, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnColecao
            // 
            this.btnColecao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnColecao.Location = new System.Drawing.Point(193, 47);
            this.btnColecao.MaximumSize = new System.Drawing.Size(19, 20);
            this.btnColecao.MinimumSize = new System.Drawing.Size(19, 20);
            this.btnColecao.Name = "btnColecao";
            this.btnColecao.Size = new System.Drawing.Size(19, 20);
            this.btnColecao.TabIndex = 3;
            this.btnColecao.Text = "🔎";
            this.btnColecao.UseVisualStyleBackColor = true;
            this.btnColecao.Click += new System.EventHandler(this.btnColecao_Click);
            // 
            // comboSituacao
            // 
            this.comboSituacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboSituacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboSituacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSituacao.FormattingEnabled = true;
            this.comboSituacao.Items.AddRange(new object[] {
            "Internado",
            "Óbito",
            "Alta",
            " "});
            this.comboSituacao.Location = new System.Drawing.Point(1077, 77);
            this.comboSituacao.MaximumSize = new System.Drawing.Size(100, 0);
            this.comboSituacao.MinimumSize = new System.Drawing.Size(100, 0);
            this.comboSituacao.Name = "comboSituacao";
            this.comboSituacao.Size = new System.Drawing.Size(100, 21);
            this.comboSituacao.TabIndex = 13;
            this.comboSituacao.SelectedValueChanged += new System.EventHandler(this.comboSituacao_SelectedValueChanged);
            // 
            // labelNumPaciente
            // 
            this.labelNumPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNumPaciente.AutoSize = true;
            this.labelNumPaciente.Location = new System.Drawing.Point(150, 80);
            this.labelNumPaciente.MaximumSize = new System.Drawing.Size(100, 13);
            this.labelNumPaciente.Name = "labelNumPaciente";
            this.labelNumPaciente.Size = new System.Drawing.Size(0, 13);
            this.labelNumPaciente.TabIndex = 36;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataEntrada.Checked = false;
            this.txtDataEntrada.CustomFormat = "";
            this.txtDataEntrada.Enabled = false;
            this.txtDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataEntrada.Location = new System.Drawing.Point(392, 22);
            this.txtDataEntrada.MaximumSize = new System.Drawing.Size(83, 20);
            this.txtDataEntrada.MinimumSize = new System.Drawing.Size(83, 20);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(83, 20);
            this.txtDataEntrada.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(264, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Horario de entrada:";
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoraEntrada.Checked = false;
            this.txtHoraEntrada.Enabled = false;
            this.txtHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHoraEntrada.Location = new System.Drawing.Point(392, 50);
            this.txtHoraEntrada.MaximumSize = new System.Drawing.Size(83, 20);
            this.txtHoraEntrada.MinimumSize = new System.Drawing.Size(83, 20);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(83, 20);
            this.txtHoraEntrada.TabIndex = 39;
            // 
            // btnLoadCentroCustos
            // 
            this.btnLoadCentroCustos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadCentroCustos.Location = new System.Drawing.Point(800, 25);
            this.btnLoadCentroCustos.MaximumSize = new System.Drawing.Size(19, 20);
            this.btnLoadCentroCustos.MinimumSize = new System.Drawing.Size(19, 20);
            this.btnLoadCentroCustos.Name = "btnLoadCentroCustos";
            this.btnLoadCentroCustos.Size = new System.Drawing.Size(19, 20);
            this.btnLoadCentroCustos.TabIndex = 7;
            this.btnLoadCentroCustos.Text = "🔎";
            this.btnLoadCentroCustos.UseVisualStyleBackColor = true;
            this.btnLoadCentroCustos.Click += new System.EventHandler(this.btnLoadCentroCustos_Click);
            // 
            // labelNomeMae
            // 
            this.labelNomeMae.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNomeMae.AutoSize = true;
            this.labelNomeMae.Location = new System.Drawing.Point(150, 136);
            this.labelNomeMae.Name = "labelNomeMae";
            this.labelNomeMae.Size = new System.Drawing.Size(0, 13);
            this.labelNomeMae.TabIndex = 102;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(149, 108);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(0, 13);
            this.labelDataNascimento.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 104;
            this.label5.Text = "Nome do Paciente:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 105;
            this.label6.Text = "Data Nascimento:";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 16);
            this.label17.TabIndex = 106;
            this.label17.Text = "Nome da mãe:";
            // 
            // btnMovimentacao
            // 
            this.btnMovimentacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMovimentacao.Location = new System.Drawing.Point(1186, 87);
            this.btnMovimentacao.MinimumSize = new System.Drawing.Size(86, 23);
            this.btnMovimentacao.Name = "btnMovimentacao";
            this.btnMovimentacao.Size = new System.Drawing.Size(86, 31);
            this.btnMovimentacao.TabIndex = 17;
            this.btnMovimentacao.Text = "Movimentação";
            this.btnMovimentacao.UseVisualStyleBackColor = true;
            this.btnMovimentacao.Click += new System.EventHandler(this.btnMovimentacao_Click);
            // 
            // labelNomeCusto
            // 
            this.labelNomeCusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNomeCusto.AutoSize = true;
            this.labelNomeCusto.Location = new System.Drawing.Point(821, 28);
            this.labelNomeCusto.Name = "labelNomeCusto";
            this.labelNomeCusto.Size = new System.Drawing.Size(0, 13);
            this.labelNomeCusto.TabIndex = 109;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Location = new System.Drawing.Point(1186, 119);
            this.btnClear.MaximumSize = new System.Drawing.Size(86, 31);
            this.btnClear.MinimumSize = new System.Drawing.Size(86, 31);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 31);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // RegistroInternacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelNomeCusto);
            this.Controls.Add(this.btnMovimentacao);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.labelNomeMae);
            this.Controls.Add(this.btnLoadCentroCustos);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.labelNumPaciente);
            this.Controls.Add(this.comboSituacao);
            this.Controls.Add(this.btnColecao);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(this.txtMedResponsavel);
            this.Controls.Add(this.txtHipDiagnostico);
            this.Controls.Add(this.txtCentroCusto);
            this.Controls.Add(this.txtLeito);
            this.Controls.Add(this.txtLocInterna);
            this.Controls.Add(this.txtNomeClinica);
            this.Controls.Add(this.txtCNS);
            this.Controls.Add(this.txtNumProntuario);
            this.Controls.Add(this.txtNumPaciente);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroInternacao";
            this.Text = "Registro de internação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNumPaciente;
        private System.Windows.Forms.TextBox txtNumProntuario;
        private System.Windows.Forms.TextBox txtCNS;
        private System.Windows.Forms.TextBox txtNomeClinica;
        private System.Windows.Forms.TextBox txtLocInterna;
        private System.Windows.Forms.TextBox txtLeito;
        private System.Windows.Forms.TextBox txtCentroCusto;
        private System.Windows.Forms.TextBox txtHipDiagnostico;
        private System.Windows.Forms.TextBox txtMedResponsavel;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnColecao;
        private System.Windows.Forms.ComboBox comboSituacao;
        private System.Windows.Forms.Label labelNumPaciente;
        private System.Windows.Forms.DateTimePicker txtDataEntrada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtHoraEntrada;
        private System.Windows.Forms.Button btnLoadCentroCustos;
        private System.Windows.Forms.Label labelNomeMae;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnMovimentacao;
        private System.Windows.Forms.Label labelNomeCusto;
        private System.Windows.Forms.Button btnClear;
    }
}

