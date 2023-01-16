using Cadastro__Centro__de_custo;
using Cadastro_paciente;
using Consultar_Pacientes;
using Registro_de_internação;
using Registro_de_Movimentação;
using Registros_Obito;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro_Centro_de_Custos tela = new Cadastro_Centro_de_Custos();
            tela.Show();
        }

        private void btnCadastroPaciente_Click(object sender, EventArgs e)
        {
            CadastroPaciente tela = new CadastroPaciente();
            tela.Show();
        }

        private void btnConsultarPacientes_Click(object sender, EventArgs e)
        {
            ConsultarPacientes tela = new ConsultarPacientes();
            tela.Show();
        }

        private void btnRegistroInternacao_Click(object sender, EventArgs e)
        {
            RegistroInternacao tela = new RegistroInternacao();
            tela.Show();
        }

        private void btnRegistrosMovimentacao_Click(object sender, EventArgs e)
        {
            RegistroMovitencao tela = new RegistroMovitencao();
            tela.Show();
        }

        private void loadRegObito_Click(object sender, EventArgs e)
        {
            RegistroObito tela = new RegistroObito();
            tela.Show();
        }

        private void btnEvasao_Click(object sender, EventArgs e)
        {
            RegistroEvasao tela = new RegistroEvasao();
            tela.Show();
        }

        private void btnLoadAlta_Click(object sender, EventArgs e)
        {
            RegistroAlta tela = new RegistroAlta();
            tela.Show();
        }
    }
}
