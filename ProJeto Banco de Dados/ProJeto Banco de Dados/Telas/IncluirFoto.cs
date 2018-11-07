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

namespace ProJeto_Banco_de_Dados.Telas
{
    public partial class IncluirFoto : Form
    {
        public IncluirFoto()
        {
            InitializeComponent();

                       
        }
    

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPEG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                txtImagem.Text = foto;
                pictureBox1.ImageLocation = foto;

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            byte[] imagem_byti = null;


            if (!this.txtImagem.Text.Equals(""))
            {

                FileStream fstream = new FileStream(this.txtImagem.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imagem_byti = br.ReadBytes((int)fstream.Length);
            }
            else
            {
                MessageBox.Show("Campo Foto Não pode ser vasio");

            }

            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao(); // chamando o metodo de conexao e atribuindo no conectar o retorno do metodo

            string insert = "update tbt_modelos_de_celular set FOTO_APARELHO =@FOTO  where ID_MODELO = @filtro";

            MySqlCommand comando_insert = con.comando_banco(insert, conectar); //chamando metodo comando_consultar do mysql e mandando o camando e a nonexao

            //objConexao = new MySqlConnection(_conection);
            //comando_insert = new MySqlCommand(insert, objConexao);
            MySqlDataReader meu_reader;

            try
            {
                con.open(conectar);// abrindo conexao

                Aparelho aparelho = new Aparelho();



                comando_insert.Parameters.Add(new MySqlParameter("@filtro", txtFiltro.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@FOTO", imagem_byti));

                // comando_insert.Parameters.Add(new MySqlParameter("@nome_Aparelho", txtNome.Text));
                // var rowsAffecteds = comando_insert.ExecuteNonQuery();

                meu_reader = comando_insert.ExecuteReader();

                MessageBox.Show("FOTO SALVA Salvo");
                // TelaCadastrarAparelho.ActiveForm.Close();


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
    }
}
