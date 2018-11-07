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
    public partial class TelaCadastrarAparelho : Form
    {
        //private string _conection = "Server=localhost;port=3306;UId=root;Database=PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS; Pwd=root";
        //MySqlConnection objConexao = null;
        //MySqlCommand comando_insert = null;

        public TelaCadastrarAparelho()
        {
            InitializeComponent();
        }

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPEG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                txtImagem.Text = foto;
                pictureBox1.ImageLocation = foto;

            }



        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            byte[] imagem_byti= null;
            FileStream fstream = new FileStream(this.txtImagem.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imagem_byti = br.ReadBytes((int)fstream.Length);



            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao(); // chamando o metodo de conexao e atribuindo no conectar o retorno do metodo

            string insert = "INSERT INTO tbt_aparelhos (SENHA_APARELHO,IMEI,NUMERO_DE_SERIE,MAC_ADDRESS,FK_ID_MODELO,FK_ID_LINHA,FK_ID_FUNCIONARIO,FOTO) VALUES (@SENHA_APARELHO,@IMEI,@NUMERO_DE_SERIE,@MAC_ADDRESS,@FK_ID_MODELO,@FK_ID_LINHA,@FK_ID_FUNCIONARIO,@FOTO)";

            MySqlCommand comando_insert = con.comando_banco(insert, conectar); //chamando metodo comando_consultar do mysql e mandando o camando e a nonexao

            //objConexao = new MySqlConnection(_conection);
            //comando_insert = new MySqlCommand(insert, objConexao);
            MySqlDataReader meu_reader;
            
            try
            {
                con.open(conectar);// abrindo conexao
                


                comando_insert.Parameters.Add(new MySqlParameter("@SENHA_APARELHO", txtSenha.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@IMEI", txtImei.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@NUMERO_DE_SERIE", txtNumeroSerie.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@MAC_ADDRESS", txtMacAdress.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@FK_ID_MODELO", txtModelo.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@FK_ID_LINHA", txtLinha.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@FK_ID_FUNCIONARIO", txtFuncionario.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@FOTO", imagem_byti));

               // comando_insert.Parameters.Add(new MySqlParameter("@nome_Aparelho", txtNome.Text));
               // var rowsAffecteds = comando_insert.ExecuteNonQuery();

                meu_reader = comando_insert.ExecuteReader();

                MessageBox.Show("Cadastro Salvo");


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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            TelaCadastrarAparelho.ActiveForm.Close();
        }
    }
}
