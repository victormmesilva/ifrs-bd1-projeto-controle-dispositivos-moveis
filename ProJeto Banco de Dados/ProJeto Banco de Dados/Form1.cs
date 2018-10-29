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

namespace ProJeto_Banco_de_Dados
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

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
            Form2 cadastro_celular = new Form2();
            cadastro_celular.Show();
            
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCelular consultar_celular = new ConsultarCelular();
            consultar_celular.Show();
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarFuncionario consulta_funcionario = new ConsultarFuncionario();
            consulta_funcionario.Show();
        }
    }
}
