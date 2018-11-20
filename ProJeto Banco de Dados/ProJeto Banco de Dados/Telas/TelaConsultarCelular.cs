using MySql.Data.MySqlClient;
using ProJeto_Banco_de_Dados.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProJeto_Banco_de_Dados
{
    public partial class TelaConsultarCelular : Form
    {
        //private string _conection = "Server=localhost;port=3306;UId=root;Database=PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS; Pwd=root";
        //MySqlConnection objConexao = null;
        //MySqlCommand comando_consultar = null;

       
        public TelaConsultarCelular()
        {
            InitializeComponent();
        }
        

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            MySqlConnection conectar = con.ObjConexao();
            string comando = " SELECT AP.SENHA_APARELHO, " +
                                " AP.IMEI," +
                                " AP.NUMERO_DE_SERIE, " +
                                " AP.MAC_ADDRESS, " +
                                " MD.NOME_MODELO, " +
                                " FU.NOME_COMPLETO, " +
                                " MD.FOTO_APARELHO, " +
                                " AP.BLOQUEADO " +
                                " FROM  tbt_aparelhos AP " +
                                " INNER JOIN TBT_FUNCIONARIOS_APARELHOS FUN_AP " +
                                " ON FUN_AP.FK_ID_APARELHO = AP.ID_APARELHO " +
                                " INNER JOIN tbt_funcionarios FU " +
                                " ON FU.ID_FUNCIONARIO = FUN_AP.FK_ID_FUNCIONARIO " +
                                " INNER JOIN tbt_modelos_de_celular MD " +
                                " ON AP.FK_ID_MODELO = MD.ID_MODELO " +
                                " WHERE AP.ID_APARELHO = @filtro";
            //con.objConexao = new MySqlConnection();
            MySqlCommand comando_consultar = con.comando_banco(comando, conectar);


            //string consultar_celular = "select * from tbt_aparelhos WHERER ID_APARELHO = '@filtro'";
            // con.objConexao = new MySqlConnection();
            MySqlDataReader meu_reader;

            try
            {
                con.open(conectar);
                comando_consultar.Parameters.Add(new MySqlParameter("@filtro", txtFiltro.Text.Trim()));


                // comando_insert.Parameters.Add(new MySqlParameter("@ID_APARELHO", null));

                // var rowsAffecteds = comando_insert.ExecuteNonQuery();
                meu_reader = comando_consultar.ExecuteReader();

                if (meu_reader.Read())
                {
                    //string nome = meu_reader.GetString("nome_Aparelho");
                    //txtNome.Text = nome.ToString();
                    string senha = meu_reader.GetString("SENHA_APARELHO");
                    txtSenha.Text = senha.ToString();
                    string imei = meu_reader.GetString("IMEI");
                    txtImei.Text = imei.ToString();

                    string numeroSerie = meu_reader.GetString("NUMERO_DE_SERIE");
                    txtNumeroSerie.Text = numeroSerie.ToString();
                    string macAddres = meu_reader.GetString("MAC_ADDRESS");
                    txtMacAdress.Text = macAddres.ToString();
                    string modelo = meu_reader.GetString("NOME_MODELO");
                    txtModelo.Text = modelo.ToString();

                    //string linha = meu_reader.GetString("NUMERO_TELEFONE");
                    txtLinha.Text = "Em manutenção";//linha.ToString();
                    string funcionario = meu_reader.GetString("NOME_COMPLETO");
                    txtFuncionario.Text = funcionario.ToString();
                    string situacaoAparelho = meu_reader.GetString("BLOQUEADO");

                    if(situacaoAparelho.Equals("1"))
                    {
                        txtBloqueado.Text = "Bloqueado";
                    }else
                    {
                        txtBloqueado.Text = "Normal";
                    }


                    
                    try
                    {
                        byte[] imagem = (byte[])(meu_reader["FOTO_APARELHO"]);
                        MemoryStream msTream = new MemoryStream(imagem);
                        pictureBox1.Image = System.Drawing.Image.FromStream(msTream);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Celular sem Foto");
                    }

                    txtFuncionario.Enabled = true;
                    txtSenha.Enabled = true;
                    txtImei.Enabled = true;
                    txtNumeroSerie.Enabled = true;
                    txtMacAdress.Enabled = true;
                    txtModelo.Enabled = true;
                    txtLinha.Enabled = true;
                    txtBloqueado.Enabled = true;


                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.close(conectar);

            }




        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            TelaConsultarCelular.ActiveForm.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBloquearAparelho_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Realmente Bloquear o Aparelho", "Bloquear Aparelho", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
                {
                Conexao con = new Conexao();    // criando objeto de conexao
                MySqlConnection conectar = con.ObjConexao();
                List<String> strList = new List<String>();

                string idAparelho = txtFiltro.Text.Trim();
                string comando = "update tbt_aparelhos set BLOQUEADO = 1 where ID_APARELHO =@idAparelho ";


                MySqlCommand comando_Bloquear = con.comando_banco(comando, conectar);
                MySqlDataReader meu_reader;


                con.open(conectar);
                comando_Bloquear.Parameters.Add(new MySqlParameter("@idAparelho", idAparelho));

                meu_reader = comando_Bloquear.ExecuteReader();
                MessageBox.Show("Aparelho Bloqueado!");

            }






        }
    }
}
