using Sistema_de_registros_para_Hospitais;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro__Centro__de_custo
{
    internal class CentroCustos
    {
        public int codCentroCusto { get; set; }
        public string nomeCentroCusto { get; set; }

        public void Salvar()
        {

            if (this.codCentroCusto == 0)
            {
                var sql = "INSERT INTO CadCentroCusto (nomeCentroCusto) VALUES (@nomeCentroCusto)";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {

                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@nomeCentroCusto", this.nomeCentroCusto);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
                return;
            }

            else
            {
                var sql = "UPDATE CadCentroCusto SET nomeCentroCusto = @nomeCentroCusto WHERE codCentroCusto = @codCentroCusto";
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {

                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {

                        cmd.Parameters.AddWithValue("@nomeCentroCusto", this.nomeCentroCusto);
                        cmd.Parameters.AddWithValue("@codCentroCusto", this.codCentroCusto);

                        cmd.ExecuteNonQuery();
                    }
                    cn.Close();
                }
            }

        }
    }
}
