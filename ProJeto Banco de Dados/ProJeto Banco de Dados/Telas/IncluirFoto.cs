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
            carregaComboMarca();
            // Set to no text.  
            txtSenha.Text = "";
            // The password character is an asterisk.  
            txtSenha.PasswordChar = '*';
            // The control will allow no more than 14 characters.  
            txtSenha.MaxLength = 14;

        }

        
        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPEG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
               // txtImagem.Text = foto;
                imgModelo.ImageLocation = foto;

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao(); // chamando o metodo de conexao e atribuindo no conectar o retorno do metodo

            string insert = " INSERT INTO tbt_aparelhos(SENHA_APARELHO,IMEI,NUMERO_DE_SERIE,MAC_ADDRESS,FK_ID_MODELO,BLOQUEADO) " +
                            " VALUES (@SENHA_APARELHO,@IMEI,@NUMERO_DE_SERIE,@MAC_ADDRESS,@FK_ID_MODELO,@BLOQUEADO); ";

            MySqlCommand comando_insert = con.comando_banco(insert, conectar); //chamando metodo comando_consultar do mysql e mandando o camando e a nonexao

            //objConexao = new MySqlConnection(_conection);
            //comando_insert = new MySqlCommand(insert, objConexao);
            MySqlDataReader meu_reader;

            try
            {
                con.open(conectar);// abrindo conexao

                Aparelho aparelho = new Aparelho();
                comando_insert.Parameters.Add(new MySqlParameter("@SENHA_APARELHO", txtSenha.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@IMEI", txtImei.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@NUMERO_DE_SERIE", txtNumeroSerie.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@MAC_ADDRESS", txtMacAdress.Text));
                comando_insert.Parameters.Add(new MySqlParameter("@FK_ID_MODELO", cbxModelo.SelectedValue));
                comando_insert.Parameters.Add(new MySqlParameter("@BLOQUEADO", '0'));


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

        private void carregaComboMarca()
        {
            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao();
            List<String> strList = new List<String>();


            //string comando = "select numero_telefone from tbt_linhas_telefonicas order by id_linha";
            string comando = "SELECT * FROM TBT_MARCAS_DE_CELULAR";

            MySqlCommand comando_marca = con.comando_banco(comando, conectar);

            MySqlDataReader meu_reader;
            con.open(conectar);
            meu_reader = comando_marca.ExecuteReader();

            int i = 0;
            if (meu_reader.HasRows)
            {
                while (meu_reader.Read())
                {
                    strList.Add(meu_reader.GetString("NOME_MARCA"));
                    cbxMarca.Items.Add(strList[i++]);
                }
            }
            con.close(conectar);
            cbxMarca.Enabled = true;
        }

        private void carregaComboModelo(string filtro)
        {
            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao();
            List<String> strList = new List<String>();


            string comando =    "select id_modelo, " +
                                "nome_modelo " +
                                "from tbt_modelos_de_celular MD " +
                                "inner join tbt_marcas_de_celular MC " +
                                "on MC.ID_MARCA = MD.FK_ID_MARCA_CELULAR " +
                                "where NOME_MARCA= @filtro " +
                                "order by NOME_MARCA ";

            MySqlCommand comando_modelo = con.comando_banco(comando, conectar);

            MySqlDataReader meu_reader;
            con.open(conectar);
            comando_modelo.Parameters.Add(new MySqlParameter("@filtro", filtro));


            meu_reader = comando_modelo.ExecuteReader();
            List<GenericCombo> lst = new List<GenericCombo>{ new GenericCombo { Codigo = "0", Descricao = "Selecione" } };
            int i = 0;
            
         
            if (meu_reader.HasRows)
            {
                while (meu_reader.Read())
                {                    
                    lst.Add(
                        new GenericCombo {
                            Codigo = meu_reader.GetString("ID_MODELO"),
                            Descricao = meu_reader.GetString("NOME_MODELO")
                        }
                    );
                    //cbxModelo.Items.Add(strList[i++]);


                }
            }
           

            cbxModelo.DataSource = lst;
            cbxModelo.DisplayMember = "Descricao";
            cbxModelo.ValueMember = "Codigo";

            con.close(conectar);
        }

        class GenericCombo {
            public string Codigo { get; set; }
            public string Descricao { get; set; }
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaComboModelo(cbxMarca.Text.Trim());
            cbxModelo.Enabled = true;
        }

        private void cbxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indexFoto = cbxModelo.SelectedValue.ToString();
            carregaFoto(indexFoto);
        }

        private void carregaFoto(string index)
        {
            Conexao con = new Conexao();
            MySqlConnection conectar = con.ObjConexao();

            string comando = "select FOTO_APARELHO from tbt_modelos_de_celular where ID_MODELO=@filtro";
            //con.objConexao = new MySqlConnection();
            MySqlCommand comando_consultar = con.comando_banco(comando, conectar);
            MySqlDataReader meu_reader;
            con.open(conectar);

            comando_consultar.Parameters.Add(new MySqlParameter("@filtro", index));
            meu_reader = comando_consultar.ExecuteReader();
            if (meu_reader.Read())
            {
                try
                {
                    byte[] imagem = (byte[])(meu_reader["FOTO_APARELHO"]);
                    MemoryStream msTream = new MemoryStream(imagem);
                    imgModelo.Image = System.Drawing.Image.FromStream(msTream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Celular sem Foto");
                }
            }

            con.close(conectar);


        }

        private void IncluirFoto_Load(object sender, EventArgs e)
        {

        }
    }
}
