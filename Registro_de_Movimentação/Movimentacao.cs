using Sistema_de_registros_para_Hospitais;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_Movimentação
{
    internal class Movimentacao
    {
        internal class updateMovimentacao
        {
            public string numPaciente { get; set; }
            public string nomePaciente { get; set; }
            public int numProntuario { get; set; }
            public string dataEntrada { get; set; }
            public string dataSaida { get; set; }
            public string CNS { get; set; }
            public string clinicaNome { get; set; }
            public string localizacaoInterna { get; set; }
            public string leito { get; set; }
            public string centroCusto { get; set; }
            public string hipoteseDiagnostico { get; set; }
            public string medicoResponsavel { get; set; }
            public string CRM { get; set; }
            public string diagnostico { get; set; }
            public string situacao { get; set; }
            public string horaEntrada { get; set; }
            public string horaSaida { get; set; }


            public void Salvar()
            {
                if (this.numProntuario == 0)
                {
                    var sql = "INSERT INTO CadRegInternacao (numPaciente, nomePaciente, dataEntrada, dataSaida, CNS, clinicaNome, localizacaoInterna, leito, centroCusto, hipoteseDiagnostico, medicoResponsavel, CRM, diagnostico, situacao, horaEntrada, horaSaida) VALUES (@numPaciente, @nomePaciente, @dataEntrada, @dataSaida, @CNS, @clinicaNome, @localizacaoInterna, @leito, @centroCusto, @hipoteseDiagnostico, @medicoResponsavel, @CRM, @diagnostico, @situacao, @horaEntrada, @horaSaida)";
                    using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                    {

                        cn.Open();
                        using (var cmd = new SqlCommand(sql, cn))
                        {

                            cmd.Parameters.AddWithValue("@numPaciente", this.numPaciente);
                            cmd.Parameters.AddWithValue("@nomePaciente", this.nomePaciente);
                            cmd.Parameters.AddWithValue("@dataEntrada", this.dataEntrada);
                            cmd.Parameters.AddWithValue("@dataSaida", this.dataSaida);
                            cmd.Parameters.AddWithValue("@CNS", this.CNS);
                            cmd.Parameters.AddWithValue("@clinicaNome", this.clinicaNome);
                            cmd.Parameters.AddWithValue("@localizacaoInterna", this.localizacaoInterna);
                            cmd.Parameters.AddWithValue("@leito", this.leito);
                            cmd.Parameters.AddWithValue("@centroCusto", this.centroCusto);
                            cmd.Parameters.AddWithValue("@hipoteseDiagnostico", this.hipoteseDiagnostico);
                            cmd.Parameters.AddWithValue("@medicoResponsavel", this.medicoResponsavel);
                            cmd.Parameters.AddWithValue("@CRM", this.CRM);
                            cmd.Parameters.AddWithValue("@diagnostico", this.diagnostico);
                            cmd.Parameters.AddWithValue("@situacao", this.situacao);
                            cmd.Parameters.AddWithValue("@horaEntrada", this.horaEntrada);
                            cmd.Parameters.AddWithValue("@horaSaida", this.horaSaida);


                            cmd.ExecuteNonQuery();
                        }
                        cn.Close();
                    }
                    return;
                }
                else
                {
                    if (MessageBox.Show("Deseja realmente atualizar a consulta do Paciente? \nNão será possivel reverter a situação ", "Cadastro do Paciente", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }

                    var sql = "UPDATE CadRegInternacao SET numPaciente = @numPaciente, dataEntrada = @dataEntrada, CNS = @CNS, clinicaNome = @clinicaNome, localizacaoInterna = @localizacaoInterna, leito = @leito, centroCusto = @centroCusto, medicoResponsavel = @medicoResponsavel, CRM = @CRM, diagnostico = @diagnostico, situacao = @situacao, horaEntrada = @horaEntrada";
                    using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                    {

                        cn.Open();
                        using (var cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@numPaciente", this.numPaciente);
                            cmd.Parameters.AddWithValue("@nomePaciente", this.nomePaciente);
                            cmd.Parameters.AddWithValue("@dataEntrada", this.dataEntrada);
                            cmd.Parameters.AddWithValue("@CNS", this.CNS);
                            cmd.Parameters.AddWithValue("@clinicaNome", this.clinicaNome);
                            cmd.Parameters.AddWithValue("@localizacaoInterna", this.localizacaoInterna);
                            cmd.Parameters.AddWithValue("@leito", this.leito);
                            cmd.Parameters.AddWithValue("@centroCusto", this.centroCusto);
                            cmd.Parameters.AddWithValue("@medicoResponsavel", this.medicoResponsavel);
                            cmd.Parameters.AddWithValue("@CRM", this.CRM);
                            cmd.Parameters.AddWithValue("@diagnostico", this.diagnostico);
                            cmd.Parameters.AddWithValue("@situacao", this.situacao);
                            cmd.Parameters.AddWithValue("@horaEntrada", this.horaEntrada);
                            cmd.Parameters.AddWithValue("@numProntuario", this.numProntuario);


                            cmd.ExecuteNonQuery();
                        }
                        cn.Close();
                    }
                }

            }
        }

    }
}
