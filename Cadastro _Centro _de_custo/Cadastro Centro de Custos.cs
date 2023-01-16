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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Cadastro__Centro__de_custo
{
    public partial class Cadastro_Centro_de_Custos : Form
    {
        private int indexRow;

        public Cadastro_Centro_de_Custos()
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

                    string sqlQuery = "SELECT codCentroCusto, nomeCentroCusto FROM CadCentroCusto";
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

            this.dataGridView1.Columns["codCentroCusto"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridView1.Columns["nomeCentroCusto"]
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dataGridView1.Columns["codCentroCusto"].HeaderText = "Código";
            this.dataGridView1.Columns["nomeCentroCusto"].HeaderText = "Nome";

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
            func(Controls);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            var Cadastro_Centro_de_custos = new CentroCustos()
            {
                nomeCentroCusto = this.txtNome.Text,

                codCentroCusto = string.IsNullOrEmpty(this.txtcodCustos.Text)
               ? 0
               : int.Parse(this.txtcodCustos.Text)

            };

            if (txtNome.Text == "")
            {
                MessageBox.Show("Todos os campos obrigatorios devem ser preenchidos", "Cadastro Centro de Custo");
                return;
            }
            
            Cadastro_Centro_de_custos.Salvar();
            SelectTable();
            ClearTextBoxes();

            MessageBox.Show("Cadastro feito com sucesso!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente DELETAR o Cadastro do Centro de Custos? ", "Cadastro Centro de custos", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.Strcon))
                {
                    cn.Open();

                    var sqlQuery = "DELETE CadCentroCusto Where codCentroCusto = '" + txtcodCustos.Text + "'" + "SELECT codCentroCusto FROM CadCentroCusto" +
                        "";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            txtcodCustos.Text = $"{row.Cells["codCentroCusto"].Value}";
            txtNome.Text = $"{row.Cells["nomeCentroCusto"].Value}";
        }
    }
}
