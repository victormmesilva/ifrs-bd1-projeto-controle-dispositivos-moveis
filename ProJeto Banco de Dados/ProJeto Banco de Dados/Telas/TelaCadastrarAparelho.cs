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
            carregaComboFuncionario();            
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

        private void carregaComboOperadora()
        {
            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao();
            List<String> strList = new List<String>();


            //string comando = "select numero_telefone from tbt_linhas_telefonicas order by id_linha";
            string comando = "SELECT * FROM TBT_OPERADORAS_TELEFONICAS";

            MySqlCommand comando_operadora = con.comando_banco(comando, conectar);

            MySqlDataReader meu_reader;
            con.open(conectar);
            meu_reader = comando_operadora.ExecuteReader();

            int i = 0;
            if (meu_reader.HasRows)
            {
                while (meu_reader.Read())
                {
                    strList.Add(meu_reader.GetString("NOME_OPERADORA"));
                    cbxOperadora.Items.Add(strList[i++]);
                }
            }
            con.close(conectar);
        }

        private void carregaComboDDI()
        {
            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao();
            List<String> strList = new List<String>();


            //string comando = "select numero_telefone from tbt_linhas_telefonicas order by id_linha";
            string comando = " SELECT ID_PAIS, " +
                             "        CONCAT(DDI, ' - ', NOME_PAIS) AS DDI " +  
                             " FROM TBT_PAISES " +
                             " ORDER BY NOME_PAIS ";

            MySqlCommand comando_ddi = con.comando_banco(comando, conectar);

            MySqlDataReader meu_reader;
            con.open(conectar);
            meu_reader = comando_ddi.ExecuteReader();

            int i = 0;
            if (meu_reader.HasRows)
            {
                while (meu_reader.Read())
                {
                    strList.Add(meu_reader.GetString("DDI"));
                    cbxDDI.Items.Add(strList[i++]);
                }
            }
            con.close(conectar);
        }

        private void carregaComboDDD()
        {
            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao();
            List<String> strList = new List<String>();


            //string comando = "select numero_telefone from tbt_linhas_telefonicas order by id_linha";
            string comando = " SELECT ID_CIDADE, " +
                             "        CONCAT(DDD, ' - ', NOME_CIDADE) AS DDD " +
                             " FROM TBT_CIDADES " +
                             " ORDER BY NOME_CIDADE ";

            MySqlCommand comando_ddd = con.comando_banco(comando, conectar);

            MySqlDataReader meu_reader;
            con.open(conectar);
            meu_reader = comando_ddd.ExecuteReader();

            int i = 0;
            if (meu_reader.HasRows)
            {
                while (meu_reader.Read())
                {
                    strList.Add(meu_reader.GetString("DDD"));
                    cbxDDD.Items.Add(strList[i++]);
                }
            }
            con.close(conectar);
        }

        //private void btnInserirImagem_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dialog = new OpenFileDialog();
        //    dialog.Filter = "JPEG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string foto = dialog.FileName.ToString();
        //        pictureBox1.ImageLocation = foto;

        //    }
        //}

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //byte[] imagem_byti = null;

            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao(); // chamando o metodo de conexao e atribuindo no conectar o retorno do metodo

            string insert = " INSERT INTO tbt_aparelhos(SENHA_APARELHO,IMEI,NUMERO_DE_SERIE,MAC_ADDRESS,FK_ID_MODELO,FK_ID_LINHA,FK_ID_FUNCIONARIO) " +
                            " VALUES (@SENHA_APARELHO,@IMEI,@NUMERO_DE_SERIE,@MAC_ADDRESS,@FK_ID_MODELO); ";

            MySqlCommand comando_insert = con.comando_banco(insert, conectar); //chamando metodo comando_consultar do mysql e mandando o camando e a nonexao

            //objConexao = new MySqlConnection(_conection);
            //comando_insert = new MySqlCommand(insert, objConexao);
            MySqlDataReader meu_reader;

            try
            {
                con.open(conectar);// abrindo conexao

                Aparelho aparelho = new Aparelho();
                //comando_insert.Parameters.Add(new MySqlParameter("@SENHA_APARELHO", txtSenha.Text));
                //comando_insert.Parameters.Add(new MySqlParameter("@IMEI", txtImei.Text));
                //comando_insert.Parameters.Add(new MySqlParameter("@NUMERO_DE_SERIE", txtNumeroSerie.Text));
                //comando_insert.Parameters.Add(new MySqlParameter("@MAC_ADDRESS", txtMacAdress.Text));

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void carregaComboLinha()
        {
            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao();
            List<String> strList = new List<String>();
           
            string comando =    " SELECT     " +
                                " l.ID_LINHA, " +
                                " CONCAT('(', p.DDI, ') ', c.DDD, ' ', l.NUMERO_TELEFONE) AS TELEFONE " +
                                " from tbt_linhas_telefonicas l " +
                                " INNER JOIN tbt_cidades c " +
                                " ON c.ID_CIDADE = l.FK_ID_CIDADE " +
                                " INNER JOIN tbt_estados e " +
                                " ON e.ID_ESTADO = c.FK_ID_ESTADO " +
                                " INNER JOIN tbt_paises p " +
                                " ON p.ID_PAIS = e.FK_ID_PAIS " +
                                " where l.FK_ID_APARELHO IS NULL " +
                                " ORDER BY TELEFONE; "; 

            MySqlCommand comando_LInha = con.comando_banco(comando, conectar);

            MySqlDataReader meu_reader;
            con.open(conectar);
            meu_reader = comando_LInha.ExecuteReader();

            int i = 0;
            if (meu_reader.HasRows)
            {
                while (meu_reader.Read())
                {
                    strList.Add(meu_reader.GetString("TELEFONE"));
                    cbxLinha.Items.Add(strList[i++]);
                }
            }
            else
                MessageBox.Show("Nenhuma linha disponível!", "Linha Indisponível", MessageBoxButtons.OK);
            con.close(conectar);
        }

        private void carregaComboFuncionario()
        {
            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao();
            List<String> strList = new List<String>();


            string comando = "select NOME_COMPLETO from tbt_funcionarios order by NOME_COMPLETO";

            MySqlCommand comando_nome = con.comando_banco(comando, conectar);

            MySqlDataReader meu_reader;
            con.open(conectar);
            meu_reader = comando_nome.ExecuteReader();

            int i = 0;

            if (meu_reader.HasRows)
            {
                while (meu_reader.Read())
                {
                    strList.Add(meu_reader.GetString("NOME_COMPLETO"));
                    //cbxFuncionario.Items.Add(strList[i++]);
                }
            }
            con.close(conectar);
        }

        private void carregaComboModelo(string filtro)
        {
            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao();
            List<String> strList = new List<String>();


            string comando = "select * from tbt_modelos_de_celular MD inner join tbt_marcas_de_celular MC on MC.ID_MARCA = MD.FK_ID_MARCA_CELULAR where NOME_MARCA= @filtro order by NOME_MARCA ";

            MySqlCommand comando_modelo = con.comando_banco(comando, conectar);

            MySqlDataReader meu_reader;
            con.open(conectar);
            comando_modelo.Parameters.Add(new MySqlParameter("@filtro", filtro));


            meu_reader = comando_modelo.ExecuteReader();

            int i = 0;
            strList.Clear();
            cbxModelo.Items.Clear();
            if (meu_reader.HasRows)
            {
                while (meu_reader.Read())
                {
                    strList.Add(meu_reader.GetString("nome_modelo"));
                    cbxModelo.Items.Add(strList[i++]);
                }
            }

            

            con.close(conectar);
        }

        private void carregaFoto(string index)
        {
            Conexao con = new Conexao();
            MySqlConnection conectar = con.ObjConexao();

            string comando = "select FOTO_APARELHO from tbt_modelos_de_celular where NOME_MODELO=@filtro";
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
                    pictureBox1.Image = System.Drawing.Image.FromStream(msTream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Celular sem Foto");
                }
            }
           
                con.close(conectar);

            
        }
        
        private void TelaCadastrarAparelho_Load(object sender, EventArgs e)
        {

        }

        private void cbxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {            
            carregaFoto(cbxModelo.Text.Trim());
            carregaComboDDI();
            cbxDDI.Enabled = true;
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaComboModelo(cbxMarca.Text.Trim());
            cbxModelo.Enabled = true;           
        }

        private void cbxFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaComboMarca();
            cbxMarca.Enabled = true;            
        }

        private void cbxDDI_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaComboDDD();
            cbxDDD.Enabled = true;
        }

        private void cbxDDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaComboOperadora();
            cbxOperadora.Enabled = true;
        }

        private void cbxOperadora_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaComboLinha();
            cbxLinha.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String cpf = mTxtCPF.Text.Trim().Replace(".","").Replace("-","").Replace(",", "");

            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao();
            List<String> strList = new List<String>();


            string comando = "SELECT NOME_COMPLETO " +
                "FROM TBT_FUNCIONARIOS " +
                "WHERE CPF = @cpf";

            MySqlCommand comando_modelo = con.comando_banco(comando, conectar);

            MySqlDataReader meu_reader;
            con.open(conectar);
            comando_modelo.Parameters.Add(new MySqlParameter("@cpf", cpf));


            meu_reader = comando_modelo.ExecuteReader();
            if (meu_reader.HasRows && meu_reader.Read())
            {
                lblNome.Text = meu_reader.GetString("NOME_COMPLETO");
                lblNome.ForeColor = System.Drawing.Color.Black;
                carregaComboMarca();                
            }
            else {
                lblNome.Text = "CPF INVÁLIDO";
                lblNome.ForeColor = System.Drawing.Color.Red;
                cbxMarca.Enabled = false;
            }
            con.close(conectar);
        }
    }
}
