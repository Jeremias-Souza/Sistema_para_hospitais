namespace Registros_Obito
{
    partial class RegistroObito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroObito));
            this.txtHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDataSaida = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.comboSituacao = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtCRM = new System.Windows.Forms.TextBox();
            this.txtMedResponsavel = new System.Windows.Forms.TextBox();
            this.txtHipDiagnostico = new System.Windows.Forms.TextBox();
            this.txtCentroCusto = new System.Windows.Forms.TextBox();
            this.txtLeito = new System.Windows.Forms.TextBox();
            this.txtLocInterna = new System.Windows.Forms.TextBox();
            this.txtNomeClinica = new System.Windows.Forms.TextBox();
            this.txtCNS = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.labelNumPaciente = new System.Windows.Forms.Label();
            this.btnColecao = new System.Windows.Forms.Button();
            this.txtNumPaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoraEntrada = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHoraSaida
            // 
            this.txtHoraSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoraSaida.Checked = false;
            this.txtHoraSaida.Enabled = false;
            this.txtHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHoraSaida.Location = new System.Drawing.Point(477, 42);
            this.txtHoraSaida.Name = "txtHoraSaida";
            this.txtHoraSaida.Size = new System.Drawing.Size(85, 20);
            this.txtHoraSaida.TabIndex = 71;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Enabled = false;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(367, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 16);
            this.label17.TabIndex = 70;
            this.label17.Text = "Horario de saida:";
            // 
            // txtDataSaida
            // 
            this.txtDataSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataSaida.Checked = false;
            this.txtDataSaida.Enabled = false;
            this.txtDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataSaida.Location = new System.Drawing.Point(477, 14);
            this.txtDataSaida.Name = "txtDataSaida";
            this.txtDataSaida.Size = new System.Drawing.Size(85, 20);
            this.txtDataSaida.TabIndex = 69;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(367, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 16);
            this.label18.TabIndex = 68;
            this.label18.Text = "Data de saida:";
            // 
            // comboSituacao
            // 
            this.comboSituacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboSituacao.Enabled = false;
            this.comboSituacao.FormattingEnabled = true;
            this.comboSituacao.Items.AddRange(new object[] {
            "Internado",
            "Óbito",
            "Alta",
            " "});
            this.comboSituacao.Location = new System.Drawing.Point(1172, 99);
            this.comboSituacao.Name = "comboSituacao";
            this.comboSituacao.Size = new System.Drawing.Size(100, 21);
            this.comboSituacao.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1261, 470);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiagnostico.Enabled = false;
            this.txtDiagnostico.Location = new System.Drawing.Point(1172, 73);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(100, 20);
            this.txtDiagnostico.TabIndex = 11;
            // 
            // txtCRM
            // 
            this.txtCRM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCRM.Enabled = false;
            this.txtCRM.Location = new System.Drawing.Point(1173, 43);
            this.txtCRM.Name = "txtCRM";
            this.txtCRM.Size = new System.Drawing.Size(100, 20);
            this.txtCRM.TabIndex = 10;
            // 
            // txtMedResponsavel
            // 
            this.txtMedResponsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMedResponsavel.Enabled = false;
            this.txtMedResponsavel.Location = new System.Drawing.Point(1173, 16);
            this.txtMedResponsavel.Name = "txtMedResponsavel";
            this.txtMedResponsavel.Size = new System.Drawing.Size(100, 20);
            this.txtMedResponsavel.TabIndex = 9;
            // 
            // txtHipDiagnostico
            // 
            this.txtHipDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHipDiagnostico.Enabled = false;
            this.txtHipDiagnostico.Location = new System.Drawing.Point(864, 47);
            this.txtHipDiagnostico.Name = "txtHipDiagnostico";
            this.txtHipDiagnostico.Size = new System.Drawing.Size(100, 20);
            this.txtHipDiagnostico.TabIndex = 6;
            // 
            // txtCentroCusto
            // 
            this.txtCentroCusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCentroCusto.Enabled = false;
            this.txtCentroCusto.Location = new System.Drawing.Point(864, 21);
            this.txtCentroCusto.Name = "txtCentroCusto";
            this.txtCentroCusto.Size = new System.Drawing.Size(100, 20);
            this.txtCentroCusto.TabIndex = 5;
            // 
            // txtLeito
            // 
            this.txtLeito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLeito.Enabled = false;
            this.txtLeito.Location = new System.Drawing.Point(864, 98);
            this.txtLeito.Name = "txtLeito";
            this.txtLeito.Size = new System.Drawing.Size(100, 20);
            this.txtLeito.TabIndex = 8;
            // 
            // txtLocInterna
            // 
            this.txtLocInterna.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLocInterna.Enabled = false;
            this.txtLocInterna.Location = new System.Drawing.Point(864, 73);
            this.txtLocInterna.Name = "txtLocInterna";
            this.txtLocInterna.Size = new System.Drawing.Size(100, 20);
            this.txtLocInterna.TabIndex = 7;
            // 
            // txtNomeClinica
            // 
            this.txtNomeClinica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeClinica.Enabled = false;
            this.txtNomeClinica.Location = new System.Drawing.Point(477, 98);
            this.txtNomeClinica.Name = "txtNomeClinica";
            this.txtNomeClinica.Size = new System.Drawing.Size(106, 20);
            this.txtNomeClinica.TabIndex = 4;
            // 
            // txtCNS
            // 
            this.txtCNS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCNS.Enabled = false;
            this.txtCNS.Location = new System.Drawing.Point(477, 71);
            this.txtCNS.Name = "txtCNS";
            this.txtCNS.Size = new System.Drawing.Size(106, 20);
            this.txtCNS.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1015, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 16);
            this.label16.TabIndex = 65;
            this.label16.Text = "Situação:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1015, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "Diagnostico:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1015, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 61;
            this.label12.Text = "CRM:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1015, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 16);
            this.label13.TabIndex = 60;
            this.label13.Text = "Médico Responsavel:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(706, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 16);
            this.label14.TabIndex = 59;
            this.label14.Text = "Hipótese do Diagnostico:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(706, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 16);
            this.label15.TabIndex = 56;
            this.label15.Text = "Centro de Custo:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(706, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Leito:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(706, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "Localização interna:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(367, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "Nome da clinica:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(367, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "CNS:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 82;
            this.label10.Text = "Horario de entrada:";
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataEntrada.Checked = false;
            this.txtDataEntrada.CustomFormat = "";
            this.txtDataEntrada.Enabled = false;
            this.txtDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataEntrada.Location = new System.Drawing.Point(152, 40);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(85, 20);
            this.txtDataEntrada.TabIndex = 81;
            // 
            // labelNumPaciente
            // 
            this.labelNumPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNumPaciente.AutoSize = true;
            this.labelNumPaciente.Location = new System.Drawing.Point(225, 17);
            this.labelNumPaciente.Name = "labelNumPaciente";
            this.labelNumPaciente.Size = new System.Drawing.Size(0, 13);
            this.labelNumPaciente.TabIndex = 80;
            // 
            // btnColecao
            // 
            this.btnColecao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnColecao.Location = new System.Drawing.Point(200, 14);
            this.btnColecao.MaximumSize = new System.Drawing.Size(19, 20);
            this.btnColecao.MinimumSize = new System.Drawing.Size(19, 20);
            this.btnColecao.Name = "btnColecao";
            this.btnColecao.Size = new System.Drawing.Size(19, 20);
            this.btnColecao.TabIndex = 2;
            this.btnColecao.Text = "🔎";
            this.btnColecao.UseVisualStyleBackColor = true;
            this.btnColecao.Click += new System.EventHandler(this.btnColecao_Click);
            // 
            // txtNumPaciente
            // 
            this.txtNumPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumPaciente.Location = new System.Drawing.Point(152, 14);
            this.txtNumPaciente.Name = "txtNumPaciente";
            this.txtNumPaciente.Size = new System.Drawing.Size(43, 20);
            this.txtNumPaciente.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 77;
            this.label4.Text = "Data de entrada:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 75;
            this.label2.Text = "Número do Paciente:";
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoraEntrada.Checked = false;
            this.txtHoraEntrada.Enabled = false;
            this.txtHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHoraEntrada.Location = new System.Drawing.Point(152, 66);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(85, 20);
            this.txtHoraEntrada.TabIndex = 83;
            // 
            // RegistroObito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.labelNumPaciente);
            this.Controls.Add(this.btnColecao);
            this.Controls.Add(this.txtNumPaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoraSaida);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtDataSaida);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.comboSituacao);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtCRM);
            this.Controls.Add(this.txtMedResponsavel);
            this.Controls.Add(this.txtHipDiagnostico);
            this.Controls.Add(this.txtCentroCusto);
            this.Controls.Add(this.txtLeito);
            this.Controls.Add(this.txtLocInterna);
            this.Controls.Add(this.txtNomeClinica);
            this.Controls.Add(this.txtCNS);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroObito";
            this.Text = "Registros de Óbito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker txtHoraSaida;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker txtDataSaida;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboSituacao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtCRM;
        private System.Windows.Forms.TextBox txtMedResponsavel;
        private System.Windows.Forms.TextBox txtHipDiagnostico;
        private System.Windows.Forms.TextBox txtCentroCusto;
        private System.Windows.Forms.TextBox txtLeito;
        private System.Windows.Forms.TextBox txtLocInterna;
        private System.Windows.Forms.TextBox txtNomeClinica;
        private System.Windows.Forms.TextBox txtCNS;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtDataEntrada;
        private System.Windows.Forms.Label labelNumPaciente;
        private System.Windows.Forms.Button btnColecao;
        private System.Windows.Forms.TextBox txtNumPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtHoraEntrada;
    }
}

