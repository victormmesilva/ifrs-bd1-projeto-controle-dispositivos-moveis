using MySql.Data.MySqlClient;
using ProJeto_Banco_de_Dados.Classes;
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
    public partial class TelaConsultarFuncionario : Form
    {
        //private string _conection = "Server=localhost;port=3306;UId=root;Database=PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS; Pwd=root";
        //MySqlConnection objConexao = null;
        //MySqlCommand objcomando = null;

        public TelaConsultarFuncionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string view = "select * from view_funcionarios";
            listaGrid(view);
        }

        public void listaGrid(string view)
        {
            Conexao con = new Conexao();
            MySqlConnection conectar = con.ObjConexao();

            string select = view;

            MySqlCommand comando_consultar = con.comando_banco(select, conectar);
            //objConexao = new MySqlConnection(_conection);
            //objcomando = new MySqlCommand(select, objConexao);

            try
            {
                MySqlDataAdapter objAdp = new MySqlDataAdapter(comando_consultar);
                DataTable consultaView = new DataTable();
                objAdp.Fill(consultaView);

                dgView.DataSource = consultaView;
            }
            catch
            {
                MessageBox.Show("não conectado");
            }
            finally
            {
                con.close(conectar);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string view = "select * from tbt_Aparelhos";
            listaGrid(view);
        }

        private void btnRelatorioGeral_Click(object sender, EventArgs e)
        {
            string view = "select * from view_relatorio";
            listaGrid(view);
        }

        private void btnAparelhosFuncionarios_Click(object sender, EventArgs e)
        {
            string view = "select * from view_funcionariosAparelhos";
            listaGrid(view);
        }

        private void btnConsultaLinhas_Click(object sender, EventArgs e)
        {
            string view = "select * from view_linha";
            listaGrid(view);
        }

        private void tbnFila_Click(object sender, EventArgs e)
        {
            string view = "select * from view_fila_espera";
            listaGrid(view);
        }
    }
}
