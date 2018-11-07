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
            string comando = "select AP.SENHA_APARELHO,AP.IMEI,AP.NUMERO_DE_SERIE,AP.MAC_ADDRESS,AP.FK_ID_MODELO,AP.FK_ID_LINHA,FU.NOME_COMPLETO,AP.FOTO from  tbt_funcionarios FU INNER JOIN tbt_aparelhos AP ON FU.ID_FUNCIONARIO = AP.FK_ID_FUNCIONARIO where ID_APARELHO = @filtro";
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
                    string modelo = meu_reader.GetString("FK_ID_MODELO");
                    txtModelo.Text = modelo.ToString();

                    string linha = meu_reader.GetString("FK_ID_LINHA");
                    txtLinha.Text = linha.ToString();
                    string funcionario = meu_reader.GetString("NOME_COMPLETO");
                    txtFuncionario.Text = funcionario.ToString();
                    try
                    {
                        byte[] imagem = (byte[])(meu_reader["FOTO"]);
                        MemoryStream msTream = new MemoryStream(imagem);
                        pictureBox1.Image = System.Drawing.Image.FromStream(msTream);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Celular sem Foto");
                    }



                    

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
    }
}
