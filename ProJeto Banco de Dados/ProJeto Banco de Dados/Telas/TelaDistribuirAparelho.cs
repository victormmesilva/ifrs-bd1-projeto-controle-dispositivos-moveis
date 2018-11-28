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
    public partial class TelaDistribuirAparelho : Form
    {
        Dados Dados_insert;

        internal class Dados{
            public int Id_funcionario { get; set; }
            public int Id_aparelho { get; set; }
            public int Id_linha { get; set; }
        }

        public TelaDistribuirAparelho()
        {
            InitializeComponent();            
            carregaComboFuncionario();
            Dados_insert = new Dados();
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
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao(); // chamando o metodo de conexao e atribuindo no conectar o retorno do metodo

            string insert = " INSERT INTO tbt_funcionarios_aparelhos(   FK_ID_FUNCIONARIO, " +
                                                                      " FK_ID_APARELHO) " +
                                                                      " VALUES (    @ID_FUNCIONARIO," +
                                                                                  " @ID_APARELHO );" +
                            " UPDATE tbt_linhas_telefonicas " +
                            " SET fk_id_aparelho = @ID_APARELHO" +
                            " WHERE id_linha = @ID_LINHA;";


            MySqlCommand comando_insert = con.comando_banco(insert, conectar); //chamando metodo comando_consultar do mysql e mandando o camando e a nonexao
            MySqlDataReader meu_reader;
            try
            {
                con.open(conectar);// abrindo conexao

                comando_insert.Parameters.Add(new MySqlParameter("@ID_FUNCIONARIO", Dados_insert.Id_funcionario));
                comando_insert.Parameters.Add(new MySqlParameter("@ID_APARELHO", Dados_insert.Id_aparelho));
                comando_insert.Parameters.Add(new MySqlParameter("@ID_LINHA", Dados_insert.Id_linha));

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
        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            TelaDistribuirAparelho.ActiveForm.Close();
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
            List<ModeloComboBox> lstModelos = new List<ModeloComboBox>();


            //string comando =    " SELECT ID_MODELO," +
            //                    " NOME_MODELO" +
            //                    " FROM tbt_modelos_de_celular MD " +
            //                    " INNER JOIN tbt_marcas_de_celular MC " +
            //                    " ON MC.ID_MARCA = MD.FK_ID_MARCA_CELULAR " +
            //                    " WHERE NOME_MARCA = @filtro " +
            //                    " ORDER BY NOME_MARCA ";

            string comando =    " SELECT a.ID_APARELHO, " +
                                " mc.NOME_MODELO " +
                                " FROM tbt_funcionarios_aparelhos fa " +
                                " RIGHT JOIN tbt_aparelhos a " +
                                " ON fa.FK_ID_APARELHO = a.ID_APARELHO " +
                                " INNER JOIN tbt_modelos_de_celular mc " +
                                " ON a.FK_ID_MODELO = mc.ID_MODELO " +
                                " WHERE fa.FK_ID_APARELHO IS NULL " +
                                " AND fa.FK_ID_FUNCIONARIO IS NULL " +
                                " AND mc.FK_ID_MARCA_CELULAR = @ID_MARCA ";

            MySqlCommand comando_modelo = con.comando_banco(comando, conectar);

            MySqlDataReader meu_reader;
            con.open(conectar);
            comando_modelo.Parameters.Add(new MySqlParameter("@filtro", filtro));


            meu_reader = comando_modelo.ExecuteReader();
            lstModelos.Clear();

            if (meu_reader.HasRows)
            {
                while (meu_reader.Read())
                {
                    lstModelos.Add(new ModeloComboBox
                    {
                        ID = Int32.Parse(meu_reader.GetString("ID_MODELO")),
                        Descricao = meu_reader.GetString("NOME_MODELO")
                    });
                }
            }  
            con.close(conectar);
            cbxModelo.DataSource = lstModelos;
            cbxModelo.ValueMember = "ID";
            cbxModelo.DisplayMember = "Descricao";
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
            carregaComboDDI();
            cbxDDI.Enabled = true;
            CarregaFichaTecnica(cbxModelo.SelectedValue.ToString());
        }

        private void CarregaFichaTecnica(string idModelo)
        {
            Conexao con = new Conexao();
            MySqlConnection conectar = con.ObjConexao();

            string comando = " SELECT NUMERO_CHIP, " +
                             " FOTO_APARELHO, " +
                             " PROCESSADOR, " +
                             " MEMORIA_RAM, " +
                             " MEMORIA_INTERNA, " +
                             " SISTEMA_OPERACIONAL " +
                             " FROM TBT_MODELOS_DE_CELULAR " +
                             " WHERE ID_MODELO = @filtro";

            MySqlCommand comando_consultar = con.comando_banco(comando, conectar);
            MySqlDataReader meu_reader;
            con.open(conectar);

            comando_consultar.Parameters.Add(new MySqlParameter("@filtro", idModelo));
            meu_reader = comando_consultar.ExecuteReader();
            if (meu_reader.Read())
            {
                try
                {
                    byte[] imagem = (byte[])(meu_reader["FOTO_APARELHO"]);
                    MemoryStream msTream = new MemoryStream(imagem);
                    pictureBox1.Image = System.Drawing.Image.FromStream(msTream);
                    lblNumChips.Text = meu_reader["NUMERO_CHIP"].ToString();
                    lblChipset.Text = meu_reader["PROCESSADOR"].ToString();
                    lblRam.Text = meu_reader["MEMORIA_RAM"].ToString();
                    lblSO.Text = meu_reader["SISTEMA_OPERACIONAL"].ToString();
                    lblArmazenamento.Text = meu_reader["MEMORIA_INTERNA"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Celular sem Foto");
                }
            }
            con.close(conectar);
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


            string comando =    " SELECT  id_funcionario, " +
                                        " nome_completo " +
                                " FROM TBT_FUNCIONARIOS " +
                                " WHERE CPF = @cpf";

            MySqlCommand comando_modelo = con.comando_banco(comando, conectar);

            MySqlDataReader meu_reader;
            con.open(conectar);
            comando_modelo.Parameters.Add(new MySqlParameter("@cpf", cpf));


            meu_reader = comando_modelo.ExecuteReader();
            if (meu_reader.HasRows && meu_reader.Read())
            {
                Dados_insert.Id_funcionario = Int32.Parse(meu_reader.GetString("id_funcionario"));
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
