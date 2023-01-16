using Cadastro__Centro__de_custo;
using Consultar_Pacientes;
using Registro_de_internação;
using Registros_Obito;
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
using System.Windows.Forms.DataVisualization.Charting;
using static Registro_de_Movimentação.Evasao;
using static Registro_de_Movimentação.Movimentacao;

namespace Registro_de_Movimentação
{
    public partial class RegistroMovitencao : Form
    {
        private int indexRow;

        public RegistroMovitencao(string cod)
        {
            InitializeComponent();
            SelectTable();
            txtNumProntuario.Text = cod;

        }

        public RegistroMovitencao()
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

                    string sqlQuery = "SELECT numPaciente, nomePaciente, numProntuario, dataEntrada, horaEntrada, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, hipoteseDiagnostico, medicoResponsavel, CRM, diagnostico, situacao FROM CadRegInternacao";
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

        private void formatColumns()
        {
            this.dataGridView1.Columns["numPaciente"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["nomePaciente"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["numProntuario"]
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

            this.dataGridView1.Columns["hipoteseDiagnostico"]
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
            this.dataGridView1.Columns["nomePaciente"].HeaderText = "Nome do Paciente";
            this.dataGridView1.Columns["numProntuario"].HeaderText = "Nº do prontuario";
            this.dataGridView1.Columns["dataEntrada"].HeaderText = "Data de entrada";
            this.dataGridView1.Columns["horaEntrada"].HeaderText = "Hora da entrada";
            this.dataGridView1.Columns["CNS"].HeaderText = "CNS";
            this.dataGridView1.Columns["clinicaNome"].HeaderText = "Nome da clinica";
            this.dataGridView1.Columns["localizacaoInterna"].HeaderText = "Localização Interna";
            this.dataGridView1.Columns["leito"].HeaderText = "Leito";
            this.dataGridView1.Columns["centroCusto"].HeaderText = "Centro de custo";
            this.dataGridView1.Columns["hipoteseDiagnostico"].HeaderText = "Hipotese de diagnostico";
            this.dataGridView1.Columns["medicoResponsavel"].HeaderText = "Médico responsavel";
            this.dataGridView1.Columns["CRM"].HeaderText = "CRM";
            this.dataGridView1.Columns["diagnostico"].HeaderText = "Diagnostico";
            this.dataGridView1.Columns["situacao"].HeaderText = "Situação";
            

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
            comboMotivo.Text = " ";
            func(Controls);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            var RegistroMovitencao = new updateMovimentacao()
            {
                numPaciente = this.txtNumPaciente.Text,
                nomePaciente = this.labelNumPaciente.Text,
                dataEntrada = this.txtDataEntrada.Text,
                CNS = this.txtCNS.Text,
                clinicaNome = this.txtNomeClinica.Text,
                localizacaoInterna = this.txtLocInterna.Text,
                leito = this.txtLeito.Text,
                centroCusto = this.txtCentroCusto.Text,
                medicoResponsavel = this.txtMedResponsavel.Text,
                CRM = this.txtCRM.Text,
                diagnostico = this.txtDiagnostico.Text,
                situacao = this.comboMotivo.Text,
                horaEntrada = this.txtHoraEntrada.Text,
                numProntuario = string.IsNullOrEmpty(this.txtNumProntuario.Text)
               ? 0
               : int.Parse(this.txtNumProntuario.Text)

            };

            if(txtNumPaciente.Text == " " || txtNumProntuario.Text == " " || txtCNS.Text == " " || comboMotivo.Text == " " || txtCentroCusto.Text == " " || txtLocInterna.Text == " " || txtLeito.Text == " " || txtMedResponsavel.Text == " " || txtCRM.Text == " " || txtDiagnostico.Text == " ")
            {
                MessageBox.Show("Todos os campos com * são obrigatorios e devem ser preenchidos", "Cadastro Centro de Custo");
            }

            if (comboMotivo.Text == "Alta")
            {
                RegAlta();
                MessageBox.Show("Paciente liberado!");
                ClearTextBoxes();
                
            }

            if (comboMotivo.Text == "Internado")
            {
                RegistroMovitencao.Salvar();
                SelectTable();
                ClearTextBoxes();
            }

            if (comboMotivo.Text == "Evasão")
            {
                registroEvasao();
                MessageBox.Show("Cadastro situação como Evasão!");
                SelectTable();
                ClearTextBoxes();
            }

            if (comboMotivo.Text == "Óbito")
            {
                registroObito();
                MessageBox.Show("Paciente cadastrado para Óbito!");
                ClearTextBoxes();
                return;
            }
        }

        private void RegAlta()
        {
            var RegistroAlta = new Alta()
            {
                numPaciente = this.txtNumPaciente.Text,
                nomePaciente = this.labelNumPaciente.Text,
                dataEntrada = this.txtDataEntrada.Text,
                dataSaida = this.dtDataSaida.Text,
                CNS = this.txtCNS.Text,
                clinicaNome = this.txtNomeClinica.Text,
                localizacaoInterna = this.txtLocInterna.Text,
                leito = this.txtLeito.Text,
                centroCusto = this.txtCentroCusto.Text,
                medicoResponsavel = this.txtMedResponsavel.Text,
                CRM = this.txtCRM.Text,
                diagnostico = this.txtDiagnostico.Text,
                situacao = this.comboMotivo.Text,
                horaEntrada = this.txtHoraEntrada.Text,
                horaSaida = this.dtHoraSaida.Text,       
                
            }; 
            RegistroAlta.Salvar();

            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {
                cn.Open();

                var sqlQuery = "DELETE CadRegInternacao Where numProntuario = '" + txtNumProntuario.Text + "'" + "SELECT numPaciente, nomePaciente, dataEntrada, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, hipoteseDiagnostico, medicoResponsavel, CRM, diagnostico, situacao, horaEntrada FROM CadRegInternacao";
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

        private void registroObito()
        {

            var RegistroObito = new Obito()
            {              
                numPaciente = this.txtNumPaciente.Text,
                nomePaciente = this.labelNumPaciente.Text,
                dataEntrada = this.txtDataEntrada.Text,
                dataSaida = this.dtDataSaida.Text,
                CNS = this.txtCNS.Text,
                clinicaNome = this.txtNomeClinica.Text,
                localizacaoInterna = this.txtLocInterna.Text,
                leito = this.txtLeito.Text,
                centroCusto = this.txtCentroCusto.Text,
                medicoResponsavel = this.txtMedResponsavel.Text,
                CRM = this.txtCRM.Text,
                diagnostico = this.txtDiagnostico.Text,
                situacao = this.comboMotivo.Text,
                horaEntrada = this.txtHoraEntrada.Text,
                horaSaida = this.dtHoraSaida.Text,

            };
            RegistroObito.Salvar();



            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {
                cn.Open();

                var sqlQuery = "DELETE CadRegInternacao Where numProntuario = '" + txtNumProntuario.Text + "'" + "SELECT numPaciente, nomePaciente, dataEntrada, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, hipoteseDiagnostico, medicoResponsavel, CRM, diagnostico, situacao, horaEntrada FROM CadRegInternacao";
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

        private void registroEvasao()
        {

            var RegistroEvasao = new updateEvasao()
            {
                numPaciente = this.txtNumPaciente.Text,
                nomePaciente = this.labelNumPaciente.Text,
                dataEntrada = this.txtDataEntrada.Text,
                dataSaida = this.dtDataSaida.Text,
                CNS = this.txtCNS.Text,
                clinicaNome = this.txtNomeClinica.Text,
                localizacaoInterna = this.txtLocInterna.Text,
                leito = this.txtLeito.Text,
                centroCusto = this.txtCentroCusto.Text,
                medicoResponsavel = this.txtMedResponsavel.Text,
                CRM = this.txtCRM.Text,
                diagnostico = this.txtDiagnostico.Text,
                situacao = this.comboMotivo.Text,
                horaEntrada = this.txtHoraEntrada.Text,
                horaSaida = this.dtHoraSaida.Text,
            };
            RegistroEvasao.Salvar();



            using (SqlConnection cn = new SqlConnection(Conn.Strcon))
            {
                cn.Open();

                var sqlQuery = "DELETE CadRegInternacao Where numProntuario = '" + txtNumProntuario.Text + "'" + "SELECT numPaciente, nomePaciente, dataEntrada, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, hipoteseDiagnostico, medicoResponsavel, CRM, diagnostico, situacao, horaEntrada FROM CadRegInternacao";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            txtNumPaciente.Text = $"{row.Cells["numPaciente"].Value}";
            labelNumPaciente.Text = $"{row.Cells["nomePaciente"].Value}";
            txtNumProntuario.Text = $"{row.Cells["numProntuario"].Value}";
            txtDataEntrada.Text = $"{row.Cells["dataEntrada"].Value}";
            //txtDataSaida.Text = $"{row.Cells["dataSaida"].Value}";
            txtCNS.Text = $"{row.Cells["CNS"].Value}";
            txtNomeClinica.Text = $"{row.Cells["clinicaNome"].Value}";
            txtLocInterna.Text = $"{row.Cells["localizacaoInterna"].Value}";
            txtLeito.Text = $"{row.Cells["leito"].Value}";
            txtCentroCusto.Text = $"{row.Cells["centroCusto"].Value}";
            txtMedResponsavel.Text = $"{row.Cells["medicoResponsavel"].Value}";
            txtCRM.Text = $"{row.Cells["CRM"].Value}";
            txtDiagnostico.Text = $"{row.Cells["Diagnostico"].Value}";
            comboMotivo.Text = $"{row.Cells["situacao"].Value}";
            txtHoraEntrada.Text = $"{row.Cells["horaEntrada"].Value}";
            //txtHoraSaida.Text = $"{row.Cells["horaSaida"].Value}";
        }

        private void txtNumPaciente_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = "SELECT numPaciente, nomePaciente, numProntuario, dataEntrada, dataSaida, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, hipoteseDiagnostico, medicoResponsavel, CRM, diagnostico, situacao, horaEntrada, horaSaida FROM CadRegInternacao WHERE numPaciente LIKE " + " '" + txtNumPaciente.Text + "%'";
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
                MessageBox.Show("Paciente inexistente!");
                Console.WriteLine(ex.Message);
            }

        }

        private void btnColecao_Click(object sender, EventArgs e)
        {
            ConsultarPacientes tela = new ConsultarPacientes();
            tela.Show();
        }

        private void comboMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMotivo.Text == "Alta" )
            {
                this.dtDataSaida.Visible = true;
                this.dtHoraSaida.Visible = true;
                this.lblDataSaida.Visible = true;
                this.lblHoraSaida.Visible = true;
            }

            if (comboMotivo.Text == "Óbito")
            {
                this.dtDataSaida.Visible = true;
                this.dtHoraSaida.Visible = true;
                this.lblDataSaida.Visible = true;
                this.lblHoraSaida.Visible = true;
            }

            if (comboMotivo.Text == "Internado")
            {
                this.dtDataSaida.Visible = false;
                this.dtHoraSaida.Visible = false;
                this.lblDataSaida.Visible = false;
                this.lblHoraSaida.Visible = false;
            }

            if (comboMotivo.Text == "Evasão")
            {
                this.dtDataSaida.Visible = false;
                this.dtHoraSaida.Visible = false;
                this.lblDataSaida.Visible = false;
                this.lblHoraSaida.Visible = false;
            }
        }

        private void txtNumProntuario_TextChanged(object sender, EventArgs e)
        {

            if (txtNumProntuario.Text != "")
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    string sql = $"SELECT numPaciente, nomePaciente, numProntuario, dataEntrada, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, hipoteseDiagnostico, medicoResponsavel, CRM, diagnostico, situacao, horaEntrada FROM dbo.CadRegInternacao WHERE numProntuario = {txtNumProntuario.Text}";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        var consult = cmd.ExecuteScalar();
                        if (consult != null)
                        {
                            SqlDataReader rd;
                            rd = cmd.ExecuteReader();
                            rd.Read();
                            txtNumPaciente.Text = rd["numPaciente"].ToString();
                            labelNumPaciente.Text = rd["nomePaciente"].ToString();
                            //txtDataEntrada.Value = rd.GetDateTime(4);
                            //txtHoraEntrada.Text = rd.GetValue(15).ToString();
                            txtCNS.Text = rd["CNS"].ToString();
                            txtNomeClinica.Text = rd["clinicaNome"].ToString();
                            txtLocInterna.Text = rd["localizacaoInterna"].ToString();
                            txtLeito.Text = rd["leito"].ToString();
                            txtMedResponsavel.Text = rd["medicoResponsavel"].ToString();
                            txtCRM.Text = rd["CRM"].ToString();
                            comboMotivo.Text = rd["situacao"].ToString();
                            txtDiagnostico.Text = rd["diagnostico"].ToString();
                            txtCentroCusto.Text = rd["CentroCusto"].ToString();
                            rd.Close();
                        }
                    }

                }

            }
        }

        private void LoadInfProntuario()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT numPaciente, nomePaciente, numProntuario, dataEntrada, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, medicoResponsavel, CRM, diagnostico, situacao, horaEntrada FROM dbo.CadRegInterncao WHERE numProntuario = {txtNumProntuario.Text}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.txtNumPaciente.Text = dt.Rows[0].Field<string>("numPaciente");
                            //this.labelDataNascimento.Text = dt.Rows[0].Field<int>("dataNascimento").ToString();
                            this.labelNumPaciente.Text = dt.Rows[0].Field<string>("nomePaciente");
                            //this.txtNumProntuario.Text = dt.Rows[0].Field<string>("numProntuario");
                            this.txtDataEntrada.Text = dt.Rows[0].Field<string>("dataEntrada");
                            this.txtCNS.Text = dt.Rows[0].Field<string>("CNS");
                            this.txtNomeClinica.Text = dt.Rows[0].Field<string>("clinicaNome");
                            this.txtLocInterna.Text = dt.Rows[0].Field<string>("localizacaoInterna");
                            this.txtLeito.Text = dt.Rows[0].Field<string>("leito");
                            this.txtCentroCusto.Text = dt.Rows[0].Field<string>("centroCusto");
                            this.txtMedResponsavel.Text = dt.Rows[0].Field<string>("medicoResponsavel");
                            this.txtCRM.Text = dt.Rows[0].Field<string>("CRM");
                            this.txtDiagnostico.Text = dt.Rows[0].Field<string>("diagnostico");
                            this.comboMotivo.Text = dt.Rows[0].Field<string>("situacao");
                            this.txtHoraEntrada.Text = dt.Rows[0].Field<string>("horaEntrada");

                        }
                    }
                }
            }
            catch (Exception ex) //Mostra mensagem caso haver falha 
            {

                MessageBox.Show("Falha ao carregar cadastro do paciente!");
                Console.WriteLine(ex.Message);
            }
        }

        private void btnLoadCentroCustos_Click(object sender, EventArgs e)
        {
            Cadastro_Centro_de_Custos tela = new Cadastro_Centro_de_Custos();
            tela.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
