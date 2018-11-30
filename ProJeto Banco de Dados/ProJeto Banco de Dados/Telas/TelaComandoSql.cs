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

namespace ProJeto_Banco_de_Dados.Telas
{
    public partial class TelaComandoSql : Form
    {
        public TelaComandoSql()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            grdResultadoBanco();

        }

        public void grdResultadoBanco()
        {
           


                Conexao con = new Conexao();
                MySqlConnection conectar = con.ObjConexao();

                string select = tbxComando.Text.ToString();

                MySqlCommand comando_consultar = con.comando_banco(select, conectar);
                
                try
                {
                    MySqlDataAdapter objAdp = new MySqlDataAdapter(comando_consultar);
                    DataTable consultaView = new DataTable();
                    objAdp.Fill(consultaView);

                    grdResultado.DataSource = consultaView;
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
        
    }
}
