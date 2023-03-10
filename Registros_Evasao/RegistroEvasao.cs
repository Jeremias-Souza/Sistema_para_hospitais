using Consultar_Pacientes;
using Sistema_de_registros_para_Hospitais;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros_Obito
{
    public partial class RegistroEvasao : Form
    {
        private int indexRow;

        public RegistroEvasao()
        {
            InitializeComponent();
            SelectTable();
        }

        private void SelectTable()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    string sqlQuery = "SELECT numPaciente, nomePaciente, dataEntrada, horaEntrada, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, medicoResponsavel, CRM, diagnostico, situacao FROM registroEvasao";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
            this.formatColumns();
            ClearTextBoxes();

        }



        private void ClearTextBoxes() //Função para limpar formularios depois de salvar
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();

                    else
                        func(control.Controls);

            };
            labelNumPaciente.Text = " ";
            func(Controls);
        }

        private void formatColumns()
        {
            this.dataGridView1.Columns["numPaciente"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["dataEntrada"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["horaEntrada"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["CNS"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["clinicaNome"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["localizacaoInterna"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["leito"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["centroCusto"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["medicoResponsavel"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["CRM"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["diagnostico"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["situacao"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["numPaciente"].HeaderText = "Nº do Paciente";
            this.dataGridView1.Columns["dataEntrada"].HeaderText = "Data de entrada";
            this.dataGridView1.Columns["horaEntrada"].HeaderText = "Hora da entrada";
            this.dataGridView1.Columns["CNS"].HeaderText = "CNS";
            this.dataGridView1.Columns["clinicaNome"].HeaderText = "Nome da clinica";
            this.dataGridView1.Columns["localizacaoInterna"].HeaderText = "Localização Interna";
            this.dataGridView1.Columns["leito"].HeaderText = "Leito";
            this.dataGridView1.Columns["centroCusto"].HeaderText = "Centro de custo";
            this.dataGridView1.Columns["medicoResponsavel"].HeaderText = "Médico responsavel";
            this.dataGridView1.Columns["CRM"].HeaderText = "CRM";
            this.dataGridView1.Columns["diagnostico"].HeaderText = "Diagnostico";
            this.dataGridView1.Columns["situacao"].HeaderText = "Situacão";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            txtNumPaciente.Text = $"{row.Cells["numPaciente"].Value}";
            labelNumPaciente.Text = $"{row.Cells["nomePaciente"].Value}";
            txtDataEntrada.Text = $"{row.Cells["dataEntrada"].Value}";
            txtHoraEntrada.Text = $"{row.Cells["horaEntrada"].Value}";
            txtCNS.Text = $"{row.Cells["CNS"].Value}";
            txtNomeClinica.Text = $"{row.Cells["clinicaNome"].Value}";
            txtLeito.Text = $"{row.Cells["leito"].Value}";
            txtCentroCusto.Text = $"{row.Cells["centroCusto"].Value}";
            txtMedResponsavel.Text = $"{row.Cells["medicoResponsavel"].Value}";
            txtCRM.Text = $"{row.Cells["CRM"].Value}";
            txtDiagnostico.Text = $"{row.Cells["Diagnostico"].Value}";
        }

        private void btnColecao_Click(object sender, EventArgs e)
        {
            ConsultarPacientes tela = new ConsultarPacientes();
            tela.Show();
        }
    }
}
