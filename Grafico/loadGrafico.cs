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

namespace Grafico
{
    public partial class loadGrafico : Form
    {
        public loadGrafico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void loadGrafico_Load(object sender, EventArgs e)
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
