using Cadastro__Centro__de_custo;
using Consultar_Pacientes;
using Registro_de_Movimentação;
using Sistema_de_registros_para_Hospitais;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Registro_de_internação
{
    public partial class RegistroInternacao : Form
    {
        private int indexRow;

        public RegistroInternacao(string cod)
        {
            InitializeComponent();
            SelectTable();
            txtNumPaciente.Text = cod;
        }

        public RegistroInternacao()
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

                    string sqlQuery = "SELECT numPaciente, nomePaciente, numProntuario, dataEntrada, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, hipoteseDiagnostico, medicoResponsavel, CRM, diagnostico, situacao, horaEntrada FROM CadRegInternacao";
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

            this.dataGridView1.Columns["horaEntrada"]
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
            labelNomeMae.Text = " ";
            labelDataNascimento.Text = " ";
            labelNumPaciente.Text = " ";
            comboSituacao.Text = " ";
            labelNomeCusto.Text = " ";
            func(Controls);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {          

            var RegistroInternacao = new Internacao()
            {
                numPaciente = this.txtNumPaciente.Text,
                nomePaciente = this.labelNumPaciente.Text,
                dataEntrada = this.txtDataEntrada.Text,
                CNS = this.txtCNS.Text,               
                clinicaNome = this.txtNomeClinica.Text,
                localizacaoInterna = this.txtLocInterna.Text,
                leito = this.txtLeito.Text,
                codCentroCusto = this.txtCentroCusto.Text,
                hipoteseDiagnostico = this.txtHipDiagnostico.Text,
                medicoResponsavel = this.txtMedResponsavel.Text,
                CRM = this.txtCRM.Text,
                diagnostico = this.txtDiagnostico.Text,
                situacao = this.comboSituacao.Text,
                horaEntrada = this.txtHoraEntrada.Text,            
                numProntuario = string.IsNullOrEmpty(this.txtNumProntuario.Text)
               ? 0
               : int.Parse(this.txtNumProntuario.Text)

            };

            if (string.IsNullOrWhiteSpace(txtNumPaciente.Text))
            {
                MessageBox.Show("É necessario informar o numero do paciente. ");
                return;
            }

            if (txtNumPaciente.Text == "" ||  txtCNS.Text == "" || txtCentroCusto.Text == "" || txtLocInterna.Text == "" || txtLeito.Text == " " || txtMedResponsavel.Text == " " || txtCRM.Text == " " || comboSituacao.Text == " ")
            {
                MessageBox.Show("Todos os campos com * são obrigatorios e devem ser preenchidos", "Cadastro Centro de Custo");
                return;
            }

            if (txtNumProntuario.Text != "0" && comboSituacao.Text == "Internado")
            {
                RegistroInternacao.Salvar();
                SelectTable();
                ClearTextBoxes();
                MessageBox.Show("Cadastro feito com sucesso!");
            }

                   
        }

        private void txtCNS_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 1 || i.Text.Length == 3)
                    i.Text += "";
                if (i.Text.Length == 3 || i.Text.Length == 8)
                    i.Text += " ";
                if (i.Text.Length == 8 || i.Text.Length == 13)
                    i.Text += " ";
                if (i.Text.Length == 13 || i.Text.Length == 18)
                    i.Text += " ";
                i.SelectionStart = i.Text.Length + 1;               
            }

            txtCNS.MaxLength = 18;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente DELETAR o Cadastro do Paciente? ", "Cadastro do Paciente", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
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
                ClearTextBoxes();
                SelectTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
        }       

        private void txtCentroCusto_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT codCentroCusto, nomeCentroCusto FROM CadCentroCusto WHERE CodCentroCusto = {int.Parse(this.txtCentroCusto.Text)}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.labelNomeCusto.Text = dt.Rows[0].Field<string>("nomeCentroCusto");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Centro Custos inexistente!");
                Console.WriteLine(ex.Message);
            }
        }

        private void btnLoadCentroCustos_Click(object sender, EventArgs e)
        {
            Cadastro_Centro_de_Custos tela = new Cadastro_Centro_de_Custos();
            tela.Show();
        }

        private void btnColecao_Click(object sender, EventArgs e)
        {
            ConsultarPacientes tela = new ConsultarPacientes();
            tela.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            txtNumPaciente.Text = $"{row.Cells["numPaciente"].Value}";
            labelNumPaciente.Text = $"{row.Cells["nomePaciente"].Value}";
            txtNumProntuario.Text = $"{row.Cells["numProntuario"].Value}";
            txtDataEntrada.Text = $"{row.Cells["dataEntrada"].Value}";
            txtCNS.Text = $"{row.Cells["CNS"].Value}";
            txtNomeClinica.Text = $"{row.Cells["clinicaNome"].Value}";
            txtLocInterna.Text = $"{row.Cells["localizacaoInterna"].Value}";
            txtLeito.Text = $"{row.Cells["leito"].Value}";
            txtCentroCusto.Text = $"{row.Cells["centroCusto"].Value}";
            txtHipDiagnostico.Text = $"{row.Cells["hipoteseDiagnostico"].Value}";
            txtMedResponsavel.Text = $"{row.Cells["medicoResponsavel"].Value}";
            txtCRM.Text = $"{row.Cells["CRM"].Value}";
            txtDiagnostico.Text = $"{row.Cells["diagnostico"].Value}";
            comboSituacao.Text = $"{row.Cells["situacao"].Value}";
            txtHoraEntrada.Text = $"{row.Cells["horaEntrada"].Value}";

        }

        private void txtNumPaciente_TextChanged(object sender, EventArgs e)
        {
            LoadInfPaciente();

            if (txtNumPaciente.Text != "")
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();
                    string sql = $"SELECT numPaciente, nomePaciente, numProntuario, dataEntrada, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, hipoteseDiagnostico, medicoResponsavel, CRM, diagnostico, situacao, horaEntrada FROM dbo.CadRegInternacao WHERE numPaciente = {txtNumPaciente.Text}";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        var consult = cmd.ExecuteScalar();
                        if (consult != null)
                        {
                            SqlDataReader rd;
                            rd = cmd.ExecuteReader();
                            rd.Read();
                            txtNumProntuario.Text = rd["numProntuario"].ToString();
                            txtCNS.Text = rd["CNS"].ToString();
                            txtNomeClinica.Text = rd["clinicaNome"].ToString();
                            txtLocInterna.Text = rd["localizacaoInterna"].ToString();
                            txtLeito.Text = rd["leito"].ToString();
                            txtMedResponsavel.Text = rd["medicoResponsavel"].ToString();
                            txtCRM.Text = rd["CRM"].ToString();
                            comboSituacao.Text = rd["situacao"].ToString();
                            txtDiagnostico.Text = rd["diagnostico"].ToString();
                            txtCentroCusto.Text = rd["CentroCusto"].ToString();
                            rd.Close();
                        }
                    }

                }

            } 
            
        }

        private void LoadInfPaciente()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = $"SELECT nome, nomeMae, dataNascimento FROM dbo.CadPaciente WHERE codPaciente = {txtNumPaciente.Text}";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            this.labelNumPaciente.Text = dt.Rows[0].Field<string>("nome");
                            this.labelNomeMae.Text = dt.Rows[0].Field<string>("nomeMae");
                            this.labelDataNascimento.Text = dt.Rows[0].Field<string>("dataNascimento");
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            if(labelNomeMae.Text == "")
            {
                labelNomeMae.Text = "Nome da Mãe não foi informado!";
            }
        }

        private void comboSituacao_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboSituacao.Text == "Alta")
            {
                MessageBox.Show("Esta tela do cadastro não tem permissão para fazer a movimentação do paciente! \n\nAbra a tela de Movimentações para mudar a situação do paciente!", "Registro de internações.");
                comboSituacao.Text = " ";
                return;
            }

            if (comboSituacao.Text == "Óbito")
            {
                MessageBox.Show("Esta tela do cadastro não tem permissão para fazer a movimentação do paciente! \n\nAbra a tela de Movimentações para mudar a situação do paciente!", "Registro de internações.");
                comboSituacao.Text = " ";
                return;
            }
        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            RegistroMovitencao tela = new RegistroMovitencao(txtNumProntuario.Text);
            tela.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
