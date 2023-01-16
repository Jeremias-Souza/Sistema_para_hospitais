namespace Consultar_Pacientes
{
    partial class ConsultarPacientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPacientes));
            this.label6 = new System.Windows.Forms.Label();
            this.comboSituacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoadCPF = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtloadNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoadRG = new System.Windows.Forms.TextBox();
            this.registroAltaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cADASTROHOSPITALDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cADASTRO_HOSPITALDataSet = new Consultar_Pacientes.CADASTRO_HOSPITALDataSet();
            this.registroObitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cADASTROHOSPITALDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registroAltaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registroAltaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.registroObitoTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registroAltaTableAdapter = new Consultar_Pacientes.CADASTRO_HOSPITALDataSetTableAdapters.registroAltaTableAdapter();
            this.registroObitoTableAdapter = new Consultar_Pacientes.CADASTRO_HOSPITALDataSetTableAdapters.registroObitoTableAdapter();
            this.registroAltaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroAltaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROHOSPITALDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTRO_HOSPITALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroObitoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROHOSPITALDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroAltaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroAltaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroObitoTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadPacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroAltaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo de Filtro:";
            // 
            // comboSituacao
            // 
            this.comboSituacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboSituacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSituacao.FormattingEnabled = true;
            this.comboSituacao.Items.AddRange(new object[] {
            "Óbito",
            "Internado",
            "Alta",
            "Evasão",
            " "});
            this.comboSituacao.Location = new System.Drawing.Point(115, 12);
            this.comboSituacao.Name = "comboSituacao";
            this.comboSituacao.Size = new System.Drawing.Size(100, 21);
            this.comboSituacao.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "CPF:";
            // 
            // txtLoadCPF
            // 
            this.txtLoadCPF.Location = new System.Drawing.Point(115, 39);
            this.txtLoadCPF.Name = "txtLoadCPF";
            this.txtLoadCPF.Size = new System.Drawing.Size(100, 20);
            this.txtLoadCPF.TabIndex = 2;
            this.txtLoadCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoadCPF_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1260, 338);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(515, 12);
            this.btnConsulta.MaximumSize = new System.Drawing.Size(86, 31);
            this.btnConsulta.MinimumSize = new System.Drawing.Size(86, 31);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(86, 31);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nome:";
            // 
            // txtloadNome
            // 
            this.txtloadNome.Location = new System.Drawing.Point(115, 65);
            this.txtloadNome.Name = "txtloadNome";
            this.txtloadNome.Size = new System.Drawing.Size(178, 20);
            this.txtloadNome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "RG:";
            // 
            // txtLoadRG
            // 
            this.txtLoadRG.Location = new System.Drawing.Point(115, 90);
            this.txtLoadRG.Name = "txtLoadRG";
            this.txtLoadRG.Size = new System.Drawing.Size(100, 20);
            this.txtLoadRG.TabIndex = 4;
            this.txtLoadRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoadRG_KeyPress);
            // 
            // registroAltaBindingSource
            // 
            this.registroAltaBindingSource.DataMember = "registroAlta";
            this.registroAltaBindingSource.DataSource = this.cADASTROHOSPITALDataSetBindingSource;
            // 
            // cADASTROHOSPITALDataSetBindingSource
            // 
            this.cADASTROHOSPITALDataSetBindingSource.DataSource = this.cADASTRO_HOSPITALDataSet;
            this.cADASTROHOSPITALDataSetBindingSource.Position = 0;
            // 
            // cADASTRO_HOSPITALDataSet
            // 
            this.cADASTRO_HOSPITALDataSet.DataSetName = "CADASTRO_HOSPITALDataSet";
            this.cADASTRO_HOSPITALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroObitoBindingSource
            // 
            this.registroObitoBindingSource.DataMember = "registroObito";
            this.registroObitoBindingSource.DataSource = this.cADASTROHOSPITALDataSetBindingSource1;
            // 
            // cADASTROHOSPITALDataSetBindingSource1
            // 
            this.cADASTROHOSPITALDataSetBindingSource1.DataSource = this.cADASTRO_HOSPITALDataSet;
            this.cADASTROHOSPITALDataSetBindingSource1.Position = 0;
            // 
            // registroAltaBindingSource1
            // 
            this.registroAltaBindingSource1.DataMember = "registroAlta";
            this.registroAltaBindingSource1.DataSource = this.cADASTROHOSPITALDataSetBindingSource1;
            // 
            // registroAltaBindingSource2
            // 
            this.registroAltaBindingSource2.DataMember = "registroAlta";
            this.registroAltaBindingSource2.DataSource = this.cADASTROHOSPITALDataSetBindingSource;
            // 
            // cadPacienteBindingSource
            // 
            this.cadPacienteBindingSource.DataMember = "CadPaciente";
            // 
            // registroAltaTableAdapter
            // 
            this.registroAltaTableAdapter.ClearBeforeFill = true;
            // 
            // registroObitoTableAdapter
            // 
            this.registroObitoTableAdapter.ClearBeforeFill = true;
            // 
            // registroAltaBindingSource3
            // 
            this.registroAltaBindingSource3.DataMember = "registroAlta";
            this.registroAltaBindingSource3.DataSource = this.cADASTROHOSPITALDataSetBindingSource;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BorderWidth = 0;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(616, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(656, 300);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(515, 49);
            this.btnClear.MaximumSize = new System.Drawing.Size(86, 31);
            this.btnClear.MinimumSize = new System.Drawing.Size(86, 31);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 31);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // ConsultarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 669);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLoadCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLoadRG);
            this.Controls.Add(this.txtloadNome);
            this.Controls.Add(this.comboSituacao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarPacientes";
            this.Text = "Consultar Pacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConsultarPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroAltaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROHOSPITALDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTRO_HOSPITALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroObitoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROHOSPITALDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroAltaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroAltaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroObitoTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadPacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroAltaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboSituacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoadCPF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsulta;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtloadNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoadRG;
        private CADASTRO_HOSPITALDataSet cADASTRO_HOSPITALDataSet;
        private System.Windows.Forms.BindingSource cADASTROHOSPITALDataSetBindingSource;
        private System.Windows.Forms.BindingSource cADASTROHOSPITALDataSetBindingSource1;
        private System.Windows.Forms.BindingSource registroAltaBindingSource;
        private CADASTRO_HOSPITALDataSetTableAdapters.registroAltaTableAdapter registroAltaTableAdapter;
        private System.Windows.Forms.BindingSource registroAltaBindingSource1;
        private System.Windows.Forms.BindingSource registroObitoBindingSource;
        private CADASTRO_HOSPITALDataSetTableAdapters.registroObitoTableAdapter registroObitoTableAdapter;
        private System.Windows.Forms.BindingSource registroAltaBindingSource2;
        //private CADASTRO_HOSPITALDataSet7 cADASTRO_HOSPITALDataSet7;
        private System.Windows.Forms.BindingSource cadPacienteBindingSource;
        //private CADASTRO_HOSPITALDataSet7TableAdapters.CadPacienteTableAdapter cadPacienteTableAdapter;
        private System.Windows.Forms.BindingSource registroObitoTableAdapterBindingSource;
        private System.Windows.Forms.BindingSource registroAltaBindingSource3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnClear;
    }
}

