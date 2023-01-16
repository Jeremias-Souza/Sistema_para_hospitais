using MySql.Data.MySqlClient;
using Sistema_de_registros_para_Hospitais;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TextBox = System.Windows.Forms.TextBox;

namespace Consultar_Pacientes
{
    public partial class ConsultarPacientes : Form
    {
        public ConsultarPacientes()
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

                    string sqlQuery = "SELECT codPaciente, sexoPaciente, dataNascimento, nome, nomeMae, cpf, rg, corPaciente, tipoSanguineo, nacionalidade, naturalidade, grauInstrucao, profissao, responsavel, cepPaciente, enderecoRua, bairro, cidade, telefoneFixo, telefoneCel, contatoFamiliar, telefoneFamiliar, email, observacao, uf FROM CadPaciente";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                    formatColumnsGeral();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }

        }

        private void formatColumnsGeral()
        {

            this.dataGridView1.Columns["codPaciente"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["sexoPaciente"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["dataNascimento"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["nome"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["nomeMae"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["cpf"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["rg"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["corPaciente"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["tipoSanguineo"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["nacionalidade"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["naturalidade"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["grauInstrucao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["profissao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["responsavel"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["cepPaciente"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["enderecoRua"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["bairro"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["cidade"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["telefoneFixo"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["telefoneCel"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["contatoFamiliar"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["email"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["observacao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["uf"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["codPaciente"].HeaderText = "Código";
            this.dataGridView1.Columns["sexoPaciente"].HeaderText = "Sexo";
            this.dataGridView1.Columns["dataNascimento"].HeaderText = "Nascimento";
            this.dataGridView1.Columns["nome"].HeaderText = "Nome";
            this.dataGridView1.Columns["nomeMae"].HeaderText = "Mãe";
            this.dataGridView1.Columns["cpf"].HeaderText = "CPF";
            this.dataGridView1.Columns["rg"].HeaderText = "RG";
            this.dataGridView1.Columns["corPaciente"].HeaderText = "Cor";
            this.dataGridView1.Columns["tipoSanguineo"].HeaderText = "Sangue";
            this.dataGridView1.Columns["nacionalidade"].HeaderText = "Nacionalidade";
            this.dataGridView1.Columns["naturalidade"].HeaderText = "Naturalidade";
            this.dataGridView1.Columns["grauInstrucao"].HeaderText = "Grau Escolar";
            this.dataGridView1.Columns["profissao"].HeaderText = "Profissão";
            this.dataGridView1.Columns["responsavel"].HeaderText = "Responsavel";
            this.dataGridView1.Columns["cepPaciente"].HeaderText = "CEP";
            this.dataGridView1.Columns["enderecoRua"].HeaderText = "Rua";
            this.dataGridView1.Columns["bairro"].HeaderText = "Bairro";
            this.dataGridView1.Columns["cidade"].HeaderText = "Cidade";
            this.dataGridView1.Columns["uf"].HeaderText = "UF";
            this.dataGridView1.Columns["telefoneFixo"].HeaderText = "Telefone";
            this.dataGridView1.Columns["telefoneCel"].HeaderText = "Tel. Celular";
            this.dataGridView1.Columns["contatoFamiliar"].HeaderText = "Familiar";
            this.dataGridView1.Columns["telefoneFamiliar"].HeaderText = "Telefone Familiar";
            this.dataGridView1.Columns["email"].HeaderText = "E-mail";
            this.dataGridView1.Columns["observacao"].HeaderText = "Observação";
        }

        private void ClearTextBoxes()
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
            comboSituacao.Text = " ";
            func(Controls);
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

        private void formatColumnsCPF()
        {

            this.dataGridView1.Columns["codPaciente"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["sexoPaciente"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["dataNascimento"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["nome"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["nomeMae"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["cpf"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["rg"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["corPaciente"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["tipoSanguineo"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["nacionalidade"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["naturalidade"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["grauInstrucao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["profissao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["responsavel"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["cepPaciente"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["enderecoRua"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["bairro"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["cidade"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["telefoneFixo"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["telefoneCel"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["contatoFamiliar"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["email"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["observacao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["uf"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["codPaciente"].HeaderText = "Código";
            this.dataGridView1.Columns["sexoPaciente"].HeaderText = "Sexo";
            this.dataGridView1.Columns["dataNascimento"].HeaderText = "Nascimento";
            this.dataGridView1.Columns["nome"].HeaderText = "Nome";
            this.dataGridView1.Columns["nomeMae"].HeaderText = "Mãe";
            this.dataGridView1.Columns["cpf"].HeaderText = "CPF";
            this.dataGridView1.Columns["rg"].HeaderText = "RG";
            this.dataGridView1.Columns["corPaciente"].HeaderText = "Cor";
            this.dataGridView1.Columns["tipoSanguineo"].HeaderText = "Sangue";
            this.dataGridView1.Columns["nacionalidade"].HeaderText = "Nacionalidade";
            this.dataGridView1.Columns["naturalidade"].HeaderText = "Naturalidade";
            this.dataGridView1.Columns["grauInstrucao"].HeaderText = "Grau Escolar";
            this.dataGridView1.Columns["profissao"].HeaderText = "Profissão";
            this.dataGridView1.Columns["responsavel"].HeaderText = "Responsavel";
            this.dataGridView1.Columns["cepPaciente"].HeaderText = "CEP";
            this.dataGridView1.Columns["enderecoRua"].HeaderText = "Rua";
            this.dataGridView1.Columns["bairro"].HeaderText = "Bairro";
            this.dataGridView1.Columns["cidade"].HeaderText = "Cidade";
            this.dataGridView1.Columns["uf"].HeaderText = "UF";
            this.dataGridView1.Columns["telefoneFixo"].HeaderText = "Telefone";
            this.dataGridView1.Columns["telefoneCel"].HeaderText = "Tel. Celular";
            this.dataGridView1.Columns["contatoFamiliar"].HeaderText = "Familiar";
            this.dataGridView1.Columns["telefoneFamiliar"].HeaderText = "Telefone Familiar";
            this.dataGridView1.Columns["email"].HeaderText = "E-mail";
            this.dataGridView1.Columns["observacao"].HeaderText = "Observação";
        }

        private void txtLoadRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 1 || i.Text.Length == 5)
                    i.Text += ".";
                i.SelectionStart = i.Text.Length + 1;

            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void txtLoadCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 3 || i.Text.Length == 7)
                    i.Text += ".";
                else if (i.Text.Length == 11)
                    i.Text += "-";
                i.SelectionStart = i.Text.Length + 1;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void ConsultaNome()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = "SELECT codPaciente, sexoPaciente, dataNascimento, nome, nomeMae, cpf, rg, corPaciente, tipoSanguineo, nacionalidade, naturalidade, grauInstrucao, profissao, responsavel, cepPaciente, enderecoRua, bairro, cidade, telefoneFixo, telefoneCel, contatoFamiliar, telefoneFamiliar, email, observacao, uf FROM CadRegInternacao WHERE nome";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                    formatColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
        }

        private void ConsultaInternados()
        {
            if (comboSituacao.Text == "Internado")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                    {
                        cn.Open();

                        string sqlQuery = "SELECT codPaciente, sexoPaciente, dataNascimento, nome, nomeMae, cpf, rg, corPaciente, tipoSanguineo, nacionalidade, naturalidade, grauInstrucao, profissao, responsavel, cepPaciente, enderecoRua, bairro, cidade, telefoneFixo, telefoneCel, contatoFamiliar, telefoneFamiliar, email, observacao, uf FROM CadPaciente";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    formatColumnsInternado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha! \n" + ex.Message);
                }

            }

            if (comboSituacao.Text == "Internado" && comboSituacao.Text == "10")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                    {
                        cn.Open();

                        string sqlQuery = "SELECT TOP 10 numPaciente, nomePaciente, numProntuario, dataEntrada, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, hipoteseDiagnostico, medicoResponsavel, CRM, diagnostico, situacao, horaEntrada FROM CadRegInternacao";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    formatColumnsInternado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha! \n" + ex.Message);
                }

            }

            if (comboSituacao.Text == "Internado" && comboSituacao.Text == "50")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                    {
                        cn.Open();

                        string sqlQuery = "SELECT TOP 50 numPaciente, nomePaciente, numProntuario, dataEntrada, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, hipoteseDiagnostico, medicoResponsavel, CRM, diagnostico, situacao, horaEntrada FROM CadRegInternacao";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    formatColumnsInternado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha! \n" + ex.Message);
                }

            }
        }

        private void ConsultaEvasao()
        {
            if (comboSituacao.Text == "Evasão")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                    {
                        cn.Open();

                        string sqlQuery = "SELECT numPaciente, nomePaciente, numProntuario, dataEntrada, horaEntrada, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, medicoResponsavel, CRM, diagnostico, situacao FROM registroEvasao";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    formatColumnsEvasao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha! \n" + ex.Message);
                }
            }
        }

        private void ConsultaAlta()
        {
            if (comboSituacao.Text == "Alta")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                    {
                        cn.Open();

                        string sqlQuery = "SELECT numPaciente, numProntuario, dataEntrada, dataSaida, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, medicoResponsavel, CRM, diagnostico, situacao, horaEntrada, horaSaida FROM registroAlta";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    formatColumnsAlta();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha! \n" + ex.Message);
                }
            }
        }

        private void ConsultaObito()
        {
            if (comboSituacao.Text == "Óbito")
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                    {
                        cn.Open();

                        string sqlQuery = "SELECT  numPaciente, nomePaciente, numProntuario, dataEntrada, dataSaida, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, hipoteseDiagnostico, medicoResponsavel, CRM, diagnostico, situacao, horaEntrada, horaSaida FROM registroObito";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                dataGridView1.DataSource = dt;
                            }
                        }
                    }
                    formatColumnsObito();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha! \n" + ex.Message);
                }
            }
        }

        private void ConsultaCPF()
        {
            txtLoadCPF.MaxLength = 14;

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = "SELECT codPaciente, sexoPaciente, dataNascimento, nome, nomeMae, cpf, rg, corPaciente, tipoSanguineo, nacionalidade, naturalidade, grauInstrucao, profissao, responsavel, cepPaciente, enderecoRua, bairro, cidade, telefoneFixo, telefoneCel, contatoFamiliar, telefoneFamiliar, email, observacao, uf FROM CadPaciente WHERE cpf LIKE" + " '" + txtLoadCPF.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                    formatColumnsCPF();
                }
            }
            catch
            {
                MessageBox.Show("Nenhum Registro Enconstrado", "Consulta de Pacientes");
            }
        }

        private void ConsultaRG()
        {
            txtLoadRG.MaxLength = 9;

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = "SELECT codPaciente, sexoPaciente, dataNascimento, nome, nomeMae, cpf, rg, corPaciente, tipoSanguineo, nacionalidade, naturalidade, grauInstrucao, profissao, responsavel, cepPaciente, enderecoRua, bairro, cidade, telefoneFixo, telefoneCel, contatoFamiliar, telefoneFamiliar, email, observacao, uf FROM CadPaciente WHERE rg LIKE" + " '" + txtLoadRG.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                    formatColumnsCPF();
                }
            }
            catch
            {
                MessageBox.Show("Nenhum Registro Enconstrado", "Consulta de Pacientes");
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
 
            if(txtloadNome.Text != "")
            {
                ConsultaNome();
            }

            if(comboSituacao.Text != "")
            {
                ConsultaInternados();
                ConsultaEvasao();
                ConsultaAlta();
                ConsultaObito();
            }

            if(txtLoadRG.Text != "")
            {
                ConsultaRG();
            }

            if(txtLoadCPF.Text != "")
            {
                ConsultaCPF();
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void formatColumnsInternado()
        {
            this.dataGridView1.Columns["codPaciente"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["sexoPaciente"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["dataNascimento"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["nome"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["nomeMae"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["cpf"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["rg"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["corPaciente"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["tipoSanguineo"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["nacionalidade"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["naturalidade"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["grauInstrucao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["profissao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["responsavel"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["cepPaciente"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["enderecoRua"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["bairro"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["cidade"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["telefoneFixo"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["telefoneCel"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["contatoFamiliar"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["email"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["observacao"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["uf"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["codPaciente"].HeaderText = "Código";
            this.dataGridView1.Columns["sexoPaciente"].HeaderText = "Sexo";
            this.dataGridView1.Columns["dataNascimento"].HeaderText = "Nascimento";
            this.dataGridView1.Columns["nome"].HeaderText = "Nome";
            this.dataGridView1.Columns["nomeMae"].HeaderText = "Mãe";
            this.dataGridView1.Columns["cpf"].HeaderText = "CPF";
            this.dataGridView1.Columns["rg"].HeaderText = "RG";
            this.dataGridView1.Columns["corPaciente"].HeaderText = "Cor";
            this.dataGridView1.Columns["tipoSanguineo"].HeaderText = "Sangue";
            this.dataGridView1.Columns["nacionalidade"].HeaderText = "Nacionalidade";
            this.dataGridView1.Columns["naturalidade"].HeaderText = "Naturalidade";
            this.dataGridView1.Columns["grauInstrucao"].HeaderText = "Grau Escolar";
            this.dataGridView1.Columns["profissao"].HeaderText = "Profissão";
            this.dataGridView1.Columns["responsavel"].HeaderText = "Responsavel";
            this.dataGridView1.Columns["cepPaciente"].HeaderText = "CEP";
            this.dataGridView1.Columns["enderecoRua"].HeaderText = "Rua";
            this.dataGridView1.Columns["bairro"].HeaderText = "Bairro";
            this.dataGridView1.Columns["cidade"].HeaderText = "Cidade";
            this.dataGridView1.Columns["uf"].HeaderText = "UF";
            this.dataGridView1.Columns["telefoneFixo"].HeaderText = "Telefone";
            this.dataGridView1.Columns["telefoneCel"].HeaderText = "Tel. Celular";
            this.dataGridView1.Columns["contatoFamiliar"].HeaderText = "Familiar";
            this.dataGridView1.Columns["telefoneFamiliar"].HeaderText = "Telefone Familiar";
            this.dataGridView1.Columns["email"].HeaderText = "E-mail";
            this.dataGridView1.Columns["observacao"].HeaderText = "Observação";

        }

        private void formatColumnsEvasao()
        {
            this.dataGridView1.Columns["numPaciente"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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

            this.dataGridView1.Columns["medicoResponsavel"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["CRM"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["diagnostico"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["situacao"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["numPaciente"].HeaderText = "Nº do Paciente";
            this.dataGridView1.Columns["numProntuario"].HeaderText = "Nº do prontuario";
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

        private void formatColumnsAlta()
        {
            this.dataGridView1.Columns["numPaciente"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["numProntuario"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["dataEntrada"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["horaEntrada"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["dataSaida"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["horaSaida"]
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
            this.dataGridView1.Columns["numProntuario"].HeaderText = "Nº do prontuario";
            this.dataGridView1.Columns["dataEntrada"].HeaderText = "Data de entrada";
            this.dataGridView1.Columns["horaEntrada"].HeaderText = "Hora da entrada";
            this.dataGridView1.Columns["dataSaida"].HeaderText = "Data de Saida";
            this.dataGridView1.Columns["horaSaida"].HeaderText = "Hora da Saida";
            this.dataGridView1.Columns["CNS"].HeaderText = "CNS";
            this.dataGridView1.Columns["clinicaNome"].HeaderText = "Nome da clinica";
            this.dataGridView1.Columns["localizacaoInterna"].HeaderText = "Localização Interna";
            this.dataGridView1.Columns["leito"].HeaderText = "Leito";
            this.dataGridView1.Columns["centroCusto"].HeaderText = "Centro de custo";
            this.dataGridView1.Columns["medicoResponsavel"].HeaderText = "Médico responsavel";
            this.dataGridView1.Columns["CRM"].HeaderText = "CRM";
            this.dataGridView1.Columns["diagnostico"].HeaderText = "Diagnostico";
            this.dataGridView1.Columns["situacao"].HeaderText = "Situação";

        }

        private void formatColumnsObito()
        {
            this.dataGridView1.Columns["numPaciente"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["nomePaciente"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["numProntuario"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["dataEntrada"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["dataSaida"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["horaEntrada"]
               .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["horaSaida"]
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
            this.dataGridView1.Columns["nomePaciente"].HeaderText = "Nome";
            this.dataGridView1.Columns["numProntuario"].HeaderText = "Nº do prontuario";
            this.dataGridView1.Columns["dataEntrada"].HeaderText = "Data de entrada";
            this.dataGridView1.Columns["horaEntrada"].HeaderText = "Hora de entrada";
            this.dataGridView1.Columns["dataSaida"].HeaderText = "Data da Saida";
            this.dataGridView1.Columns["horaSaida"].HeaderText = "Hora da Saida";
            this.dataGridView1.Columns["CNS"].HeaderText = "CNS";
            this.dataGridView1.Columns["clinicaNome"].HeaderText = "Nome da clinica";
            this.dataGridView1.Columns["localizacaoInterna"].HeaderText = "Localização Interna";
            this.dataGridView1.Columns["leito"].HeaderText = "Leito";
            this.dataGridView1.Columns["centroCusto"].HeaderText = "Centro de custo";
            this.dataGridView1.Columns["hipoteseDiagnostico"].HeaderText = "Hipotese do diagnostico";
            this.dataGridView1.Columns["medicoResponsavel"].HeaderText = "Médico responsavel";
            this.dataGridView1.Columns["CRM"].HeaderText = "CRM";
            this.dataGridView1.Columns["diagnostico"].HeaderText = "Diagnostico";
            this.dataGridView1.Columns["situacao"].HeaderText = "Situação";
        }

        private void ConsultarPacientes_Load(object sender, EventArgs e)
        {

            int contInternados;
            int contAltas;
            int contObitos;
            int contEvasoes;

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {

                    cn.Open();
                    string Internados = $"SELECT COUNT(situacao) FROM CadRegInternacao WHERE situacao = 'Internado'";
                    string Altas = $"SELECT COUNT(situacao) FROM registroAlta WHERE situacao = 'Alta'";
                    string Obitos = $"SELECT COUNT(situacao) FROM registroObito WHERE situacao = 'Óbito'";
                    string Evasoes = $"SELECT COUNT(situacao) FROM registroEvasao WHERE situacao = 'Evasão'";
                    using (SqlCommand cmd = new SqlCommand(Internados, cn))
                    {
                        contInternados = (int)cmd.ExecuteScalar();
                    }
                    using (SqlCommand cmd = new SqlCommand(Altas, cn))
                    {
                        contAltas = (int)cmd.ExecuteScalar();
                    }
                    using (SqlCommand cmd = new SqlCommand(Obitos, cn))
                    {
                        contObitos = (int)cmd.ExecuteScalar();
                    }
                    using (SqlCommand cmd = new SqlCommand(Evasoes, cn))
                    {
                        contEvasoes = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();

            chart1.Legends.Add("m");
 
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].BorderColor = Color.Black;
            chart1.Legends[0].BorderWidth = 1;

            chart1.Palette = ChartColorPalette.EarthTones;

            chart1.Series.Add("Evasões");
            chart1.Series[0].Points.Add(contEvasoes);

            chart1.Series.Add("Óbitos");
            chart1.Series[1].Points.Add(contObitos);

            chart1.Series.Add("Altas");
            chart1.Series[2].Points.Add(contAltas);

            chart1.Series.Add("Internados");
            chart1.Series[3].Points.Add(contInternados);

        }
    }
}
