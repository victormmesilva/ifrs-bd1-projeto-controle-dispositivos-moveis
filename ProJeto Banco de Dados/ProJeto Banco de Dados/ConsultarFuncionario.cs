using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProJeto_Banco_de_Dados
{
    public partial class ConsultarFuncionario : Form
    {
        private string _conection = "Server=localhost;port=3306;UId=root;Database=PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS; Pwd=root";
        MySqlConnection objConexao = null;
        MySqlCommand objcomando = null;

        public ConsultarFuncionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaGrid();
        }

        public void listaGrid()
        {
            string select = "select * from view_funcionarios";
            objConexao = new MySqlConnection(_conection);
            objcomando = new MySqlCommand(select, objConexao);

            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objcomando);
                DataTable consultaView = new DataTable();
                objAdp.Fill(consultaView);

                dgView.DataSource = consultaView;
            }
            catch
            {
                MessageBox.Show("não conectado");
            }

        }
    }
}
