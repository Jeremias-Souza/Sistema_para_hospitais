using Sistema_de_registros_para_Hospitais;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_paciente
{
    internal class Paciente
    {
        public int codPaciente { get; set; }
        public string sexoPaciente { get; set; }
        public string dataNascimento { get; set; }
        public string nome { get; set; }
        public string nomeMae { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string corPaciente { get; set; }
        public string tipoSanguineo { get; set; }
        public string nacionalidade { get; set; }
        public string naturalidade { get; set; }
        public string grauInstrucao { get; set; }
        public string profissao { get; set; }
        public string responsavel { get; set; }
        public string cepPaciente { get; set; }
        public string enderecoRua { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string telefoneFixo { get; set; }
        public string telefoneCel { get; set; }
        public string contatoFamiliar { get; set; }
        public string telefoneFamiliar { get; set; }
        public string email { get; set; }
        public string observacao { get; set; }
        public string uf { get; set; }


        public void Salvar()
        {

            if (this.codPaciente == 0)
            {
                var sql = "INSERT INTO CadPaciente (sexoPaciente, dataNascimento, nome, nomeMae, cpf, rg, corPaciente, tipoSanguineo, nacionalidade, naturalidade, grauInstrucao, profissao, responsavel, cepPaciente, enderecoRua, bairro, cidade, telefoneFixo, telefoneCel, contatoFamiliar, telefoneFamiliar, email, observacao, uf) VALUES (@sexoPaciente, @dataNascimento, @nome, @nomeMae, @cpf, @rg, @corPaciente, @tipoSanguineo, @nacionalidade, @naturalidade, @grauInstrucao, @profissao, @responsavel, @cepPaciente, @enderecoRua, @bairro, @cidade, @telefoneFixo, @telefoneCel, @contatoFamiliar, @telefoneFamiliar, @email, @observacao, @uf)";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {

                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@sexoPaciente", this.sexoPaciente);
                        cmd.Parameters.AddWithValue("@dataNascimento", this.dataNascimento);
                        cmd.Parameters.AddWithValue("@nome", this.nome);
                        cmd.Parameters.AddWithValue("@nomeMae", this.nomeMae);
                        cmd.Parameters.AddWithValue("@cpf", this.cpf);
                        cmd.Parameters.AddWithValue("@rg", this.rg);
                        cmd.Parameters.AddWithValue("@corPaciente", this.corPaciente);
                        cmd.Parameters.AddWithValue("@tipoSanguineo", this.tipoSanguineo);
                        cmd.Parameters.AddWithValue("@nacionalidade", this.nacionalidade);
                        cmd.Parameters.AddWithValue("@naturalidade", this.naturalidade);
                        cmd.Parameters.AddWithValue("@grauInstrucao", this.grauInstrucao);
                        cmd.Parameters.AddWithValue("@profissao", this.profissao);
                        cmd.Parameters.AddWithValue("@responsavel", this.responsavel);
                        cmd.Parameters.AddWithValue("@cepPaciente", this.cepPaciente);
                        cmd.Parameters.AddWithValue("@enderecoRua", this.enderecoRua);
                        cmd.Parameters.AddWithValue("@bairro", this.bairro);
                        cmd.Parameters.AddWithValue("@cidade", this.cidade);
                        cmd.Parameters.AddWithValue("@telefoneFixo", this.telefoneFixo);
                        cmd.Parameters.AddWithValue("@telefoneCel", this.telefoneCel);
                        cmd.Parameters.AddWithValue("@contatoFamiliar", this.contatoFamiliar);
                        cmd.Parameters.AddWithValue("@telefoneFamiliar", this.telefoneFamiliar);
                        cmd.Parameters.AddWithValue("@email", this.email);
                        cmd.Parameters.AddWithValue("@observacao", this.observacao);
                        cmd.Parameters.AddWithValue("@uf", this.uf);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
                return;
            }

            else
            {
                if (MessageBox.Show("Deseja realmente atualizar o cadastro do Paciente? \nNão será possivel reverter a situação ", "Cadastro do Paciente", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                var sql = "UPDATE CadPaciente SET sexoPaciente = @sexoPaciente, dataNascimento = @dataNascimento, nome = @nome, nomeMae = @nomeMae, cpf = @cpf, rg = @rg, corPaciente = @corPaciente, tipoSanguineo = @tipoSanguineo, nacionalidade = @nacionalidade, naturalidade = @naturalidade, grauInstrucao = @grauInstrucao, profissao = @profissao, responsavel = @responsavel, cepPaciente = @responsavel, enderecoRua = @responsavel, bairro = @bairro, cidade = @cidade, telefoneFixo = @telefoneFixo, telefoneCel = @telefoneCel, contatoFamiliar = @contatoFamiliar, telefoneFamiliar = @telefoneFamiliar, email = @email, observacao = @observacao, uf = @uf WHERE codPaciente = @codPaciente";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {

                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@sexoPaciente", this.sexoPaciente);
                        cmd.Parameters.AddWithValue("@dataNascimento", this.dataNascimento);
                        cmd.Parameters.AddWithValue("@nome", this.nome);
                        cmd.Parameters.AddWithValue("@nomeMae", this.nomeMae);
                        cmd.Parameters.AddWithValue("@cpf", this.cpf);
                        cmd.Parameters.AddWithValue("@rg", this.rg);
                        cmd.Parameters.AddWithValue("@corPaciente", this.corPaciente);
                        cmd.Parameters.AddWithValue("@tipoSanguineo", this.tipoSanguineo);
                        cmd.Parameters.AddWithValue("@nacionalidade", this.nacionalidade);
                        cmd.Parameters.AddWithValue("@naturalidade", this.naturalidade);
                        cmd.Parameters.AddWithValue("@grauInstrucao", this.grauInstrucao);
                        cmd.Parameters.AddWithValue("@profissao", this.profissao);
                        cmd.Parameters.AddWithValue("@responsavel", this.responsavel);
                        cmd.Parameters.AddWithValue("@cepPaciente", this.cepPaciente);
                        cmd.Parameters.AddWithValue("@enderecoRua", this.enderecoRua);
                        cmd.Parameters.AddWithValue("@bairro", this.bairro);
                        cmd.Parameters.AddWithValue("@cidade", this.cidade);
                        cmd.Parameters.AddWithValue("@telefoneFixo", this.telefoneFixo);
                        cmd.Parameters.AddWithValue("@telefoneCel", this.telefoneCel);
                        cmd.Parameters.AddWithValue("@contatoFamiliar", this.contatoFamiliar);
                        cmd.Parameters.AddWithValue("@telefoneFamiliar", this.telefoneFamiliar);
                        cmd.Parameters.AddWithValue("@email", this.email);
                        cmd.Parameters.AddWithValue("@observacao", this.observacao);
                        cmd.Parameters.AddWithValue("@uf", this.uf);
                        cmd.Parameters.AddWithValue("@codPaciente", this.codPaciente);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }
        }
    }
}
