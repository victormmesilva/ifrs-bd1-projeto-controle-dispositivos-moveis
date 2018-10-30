using MySql.Data.MySqlClient;
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
    public partial class Form2 : Form
    {
        private string _conection = "Server=localhost;port=3306;UId=root;Database=PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS; Pwd=root";
        MySqlConnection objConexao = null;
        MySqlCommand comando_insert = null;

        public Form2()
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

            string insert = "INSERT INTO tbt_aparelhos (SENHA_APARELHO,IMEI,NUMERO_DE_SERIE,MAC_ADDRESS,FK_ID_MODELO,FK_ID_LINHA,FK_ID_FUNCIONARIO,fotos) VALUES (@SENHA_APARELHO,@IMEI,@NUMERO_DE_SERIE,@MAC_ADDRESS,@FK_ID_MODELO,@FK_ID_LINHA,@FK_ID_FUNCIONARIO,@fotos)";
            objConexao = new MySqlConnection(_conection);
            comando_insert = new MySqlCommand(insert, objConexao);
            MySqlDataReader meu_reader;
            
            try
            {
                objConexao.Open();
               // comando_insert.Parameters.Add(new MySqlParameter("@ID_APARELHO", null));
                comando_insert.Parameters.Add(new MySqlParameter("@SENHA_APARELHO", txtSenha.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@IMEI", txtImei.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@NUMERO_DE_SERIE", txtNumeroSerie.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@MAC_ADDRESS", txtMacAdress.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@FK_ID_MODELO", txtModelo.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@FK_ID_LINHA", txtLinha.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@FK_ID_FUNCIONARIO", txtFuncionario.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@fotos", imagem_byti));
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
                objConexao.Close();

            }



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
