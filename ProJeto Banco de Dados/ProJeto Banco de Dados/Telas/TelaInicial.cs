using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProJeto_Banco_de_Dados.Classes;
using ProJeto_Banco_de_Dados.Telas;

namespace ProJeto_Banco_de_Dados
{
    public partial class TelaInicial : Form
    {
        

        public TelaInicial()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Conexao.CriarBancoIniciar();
            Conexao.CriarProcedure();
            Conexao.CriarTabelas();
            Conexao.CarregarFoto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }


        private void casdastroCelularToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDistribuirAparelho cadastro_celular = new TelaDistribuirAparelho();
            cadastro_celular.Show();
            
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaConsultarAparelho consultar_celular = new TelaConsultarAparelho();
            consultar_celular.ShowDialog();
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaConsultarFuncionario consulta_funcionario = new TelaConsultarFuncionario();
            consulta_funcionario.Show();

           
        }

        private void inserirFotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarAparelho consultar_celular = new TelaCadastrarAparelho();
            consultar_celular.Show();
        }
    }
}
