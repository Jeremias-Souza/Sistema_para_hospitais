using Microsoft.VisualBasic;
using Registro_de_internação;
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
using static System.Net.Mime.MediaTypeNames;

namespace Cadastro_paciente
{
    public partial class CadastroPaciente : Form
    {
        public int indexRow { get; private set; }

        public CadastroPaciente()
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
            this.formatColumns();
        }

        private void formatColumns()
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

        private void btnInternacao_Click(object sender, EventArgs e)
        {
            RegistroInternacao tela = new RegistroInternacao(txtCodPaciente.Text);
            tela.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var Cadastro_paciente = new Paciente()
            {
                sexoPaciente = this.comboSexo.Text,
                dataNascimento = this.txtDataNascimento.Text,
                nome = this.txtNomePaciente.Text,
                nomeMae = this.txtNomeMae.Text,
                cpf = this.txtCPF.Text,
                rg = this.txtRG.Text,
                corPaciente = this.comboCor.Text,
                tipoSanguineo = this.comboSangue.Text,
                nacionalidade = this.txtNacionalidade.Text,
                naturalidade = this.txtNaturalidade.Text,
                grauInstrucao = this.comboInstrucao.Text,
                profissao = this.txtProfissao.Text,
                responsavel = this.txtResponsavel.Text,
                cepPaciente = this.txtCEP.Text,
                enderecoRua = this.txtEndereco.Text,
                bairro = this.txtBairro.Text,
                cidade = this.txtCidade.Text,
                telefoneFixo = this.txtTelefone.Text,
                telefoneCel = this.txtCelular.Text,
                contatoFamiliar = this.txtResponsavel.Text,
                telefoneFamiliar = this.txtTelefoneFamiliar.Text,
                email = this.txtEmail.Text,
                observacao = this.txtObservacoes.Text,
                uf = this.txtUF.Text,
                codPaciente = string.IsNullOrEmpty(this.txtCodPaciente.Text)
               ? 0
               : int.Parse(this.txtCodPaciente.Text)

            };

            if (txtNomePaciente.Text == "" || comboSexo.Text == " " || txtDataNascimento.Text == "" || txtCPF.Text == "" || txtRG.Text == "" || comboSangue.Text== " " || txtNacionalidade.Text == "" || txtCEP.Text == "" || txtEndereco.Text == "" || txtBairro.Text == "" || txtCidade.Text == "" || txtUF.Text == "")
            {
                MessageBox.Show("Todos os campos com * são obrigatorios e devem ser preenchidos", "Cadastro Centro de Custo");
                return;
            }

            if (txtUF.Text != ("AC") && txtUF.Text != ("AL") && txtUF.Text != ("AP") && txtUF.Text != ("AM") && txtUF.Text != ("BA") && txtUF.Text != ("CE") && txtUF.Text != ("DF") && txtUF.Text != ("ES") && txtUF.Text != ("GO") && txtUF.Text != ("MA") && txtUF.Text != ("MT") && txtUF.Text != ("MS") && txtUF.Text != ("MG") && txtUF.Text != ("PA") && txtUF.Text != ("PB") && txtUF.Text != ("PR") && txtUF.Text != ("PE") && txtUF.Text != ("PI") && txtUF.Text != ("RJ") && txtUF.Text != ("RN") && txtUF.Text != ("RS") && txtUF.Text != ("RO") && txtUF.Text != ("RR") && txtUF.Text != ("SC") && txtUF.Text != ("SP") && txtUF.Text != ("SE") && txtUF.Text != ("TO"))
            {
                MessageBox.Show("UF inválida");
                return;
            }

            else
            {
                Cadastro_paciente.Salvar();
                SelectTable();
                MessageBox.Show("Cadastro feito com sucesso!");
            }
            
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

                    var sqlQuery = "DELETE CadPaciente Where codPaciente = '" + txtCodPaciente.Text + "'" + "SELECT codPaciente, sexoPaciente, dataNascimento, nome, nomeMae, cpf, rg, corPaciente, tipoSanguineo, nacionalidade, naturalidade, grauInstrucao, profissao, responsavel, cepPaciente, enderecoRua, bairro, cidade, telefoneFixo, telefoneCel, contatoFamiliar, telefoneFamiliar, email, observacao, uf FROM CadPaciente";
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
            catch (Exception ex) //Mostra mensagem caso haver falha 
            {
                MessageBox.Show("Falha! \n" + ex.Message);
            }
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
            comboCor.Text = " ";
            comboInstrucao.Text = " ";
            comboSangue.Text = " ";
            comboSexo.Text = " ";
            func(Controls);
        }

        private void txtNomePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void txtNacionalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void txtNaturalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void txtNomeMae_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void txtResponsavel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
        }

        private void txtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 2 || i.Text.Length == 5)
                    i.Text += "/";
                i.SelectionStart = i.Text.Length + 1;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 5 || i.Text.Length == 9)
                    i.Text += "-";
                i.SelectionStart = i.Text.Length + 1;

            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 0)
                    i.Text += "(";
                else if (i.Text.Length == 3)
                    i.Text += ") ";
                else if (i.Text.Length == 9)
                    i.Text += "-";

                i.SelectionStart = i.Text.Length + 1;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 0)
                    i.Text += "(";
                else if (i.Text.Length == 3)
                    i.Text += ") ";
                else if (i.Text.Length == 10)
                    i.Text += "-";

                i.SelectionStart = i.Text.Length + 1;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void txtUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());

            string strTexto;
            strTexto = e.KeyChar.ToString();
            strTexto = strTexto.ToUpper();
            e.KeyChar = Convert.ToChar(strTexto);

            if ((Strings.Asc(e.KeyChar) >= 48 & Strings.Asc(e.KeyChar) <= 57))
            {
                e.Handled = true;
                e = null;
            }
            base.OnKeyPress(e);
        }

        private void txtTelefoneFamiliar_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox i = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                i.SelectionStart = i.Text.Length + 1;

                if (i.Text.Length == 0)
                    i.Text += "(";
                else if (i.Text.Length == 3)
                    i.Text += ") ";
                else if (i.Text.Length == 10)
                    i.Text += "-";

                i.SelectionStart = i.Text.Length + 1;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            txtCodPaciente.Text = $"{row.Cells["codPaciente"].Value}";
            comboSexo.Text = $"{row.Cells["sexoPaciente"].Value}";
            txtDataNascimento.Text = $"{row.Cells["dataNascimento"].Value}";
            txtNomePaciente.Text = $"{row.Cells["nome"].Value}";
            txtNomeMae.Text = $"{row.Cells["nomeMae"].Value}";
            txtCPF.Text = $"{row.Cells["cpf"].Value}";
            txtRG.Text = $"{row.Cells["rg"].Value}";
            comboCor.Text = $"{row.Cells["corPaciente"].Value}";
            comboSangue.Text = $"{row.Cells["tipoSanguineo"].Value}";
            txtNacionalidade.Text = $"{row.Cells["nacionalidade"].Value}";
            txtNaturalidade.Text = $"{row.Cells["naturalidade"].Value}";
            comboInstrucao.Text = $"{row.Cells["grauInstrucao"].Value}";
            txtProfissao.Text = $"{row.Cells["profissao"].Value}";
            txtResponsavel.Text = $"{row.Cells["responsavel"].Value}";
            txtCEP.Text = $"{row.Cells["cepPaciente"].Value}";
            txtEndereco.Text = $"{row.Cells["enderecoRua"].Value}";
            txtBairro.Text = $"{row.Cells["bairro"].Value}";
            txtCidade.Text = $"{row.Cells["cidade"].Value}";
            txtTelefone.Text = $"{row.Cells["telefoneFixo"].Value}";
            txtCelular.Text = $"{row.Cells["telefoneCel"].Value}";
            txtContato.Text = $"{row.Cells["contatoFamiliar"].Value}";
            txtTelefoneFamiliar.Text = $"{row.Cells["telefoneFamiliar"].Value}";
            txtEmail.Text = $"{row.Cells["email"].Value}";
            txtObservacoes.Text = $"{row.Cells["observacao"].Value}";
            txtUF.Text = $"{row.Cells["uf"].Value}";
           
        }

        private void txtUF_TextChanged(object sender, EventArgs e)
        {
            txtUF.MaxLength = 2;
        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {
            txtDataNascimento.MaxLength = 10;
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            txtCPF.MaxLength = 14;
        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {
            txtRG.MaxLength = 9;
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            txtCEP.MaxLength = 9;
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            txtTelefone.MaxLength = 14;
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            txtCelular.MaxLength = 15;
        }

        private void txtContato_TextChanged(object sender, EventArgs e)
        {
            txtContato.MaxLength = 16;
        }

        private void txtTelefoneFamiliar_TextChanged(object sender, EventArgs e)
        {
            txtTelefoneFamiliar.MaxLength = 15;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
