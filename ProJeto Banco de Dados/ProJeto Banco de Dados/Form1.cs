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
            try
            {
                MySqlConnection objConexao = new MySqlConnection("Server=localhost;port=3306;UId=root;Database=PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS; Pwd=root");
                objConexao.Open();
                MessageBox.Show("conectado");
                objConexao.Close();
            }
            catch {
                MessageBox.Show("não conectado");
            }
        }
    }
}
