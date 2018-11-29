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

        private void CarregaComboMarca()
        {
            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao();
            List<ModeloComboBox> lstMarcas = new List<ModeloComboBox>
            {
                new ModeloComboBox { ID = 0, Descricao = "SELECIONE" }
            };

            string comando =    " SELECT    ID_MARCA," +
                                "           NOME_MARCA " +
                                "FROM TBT_MARCAS_DE_CELULAR";

            MySqlCommand comando_marca = con.comando_banco(comando, conectar);

            MySqlDataReader meu_reader;
            con.open(conectar);
            meu_reader = comando_marca.ExecuteReader();

            if (meu_reader.HasRows)
            {
                while (meu_reader.Read())
                {
                    lstMarcas.Add(
                        new ModeloComboBox
                        {
                            ID = Int32.Parse(meu_reader.GetString("ID_MARCA")),
                            Descricao = meu_reader.GetString("NOME_MARCA")
                        });
                }
                cbxMarca.DataSource = lstMarcas;
                cbxMarca.ValueMember = "ID";
                cbxMarca.DisplayMember = "Descricao"; 
                cbxMarca.Enabled = true;
            }
            con.close(conectar);           
        }

        private void CarregaComboOperadora()
        {
            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao();

            List<ModeloComboBox> lstOperadoras = new List<ModeloComboBox>
            {
                new ModeloComboBox { ID = 0, Descricao = "SELECIONE" }
            };

            string comando =    " SELECT    ID_OPERADORA, " +
                                "           NOME_OPERADORA " +
                                " FROM TBT_OPERADORAS_TELEFONICAS";

            MySqlCommand comando_operadora = con.comando_banco(comando, conectar);

            MySqlDataReader meu_reader;
            con.open(conectar);
            meu_reader = comando_operadora.ExecuteReader();

            
                if (meu_reader.HasRows)
                {
                    while (meu_reader.Read())
                    {
                        lstOperadoras.Add(new ModeloComboBox
                        {
                            ID = Int32.Parse(meu_reader.GetString("ID_OPERADORA")),
                            Descricao = meu_reader.GetString("NOME_OPERADORA")
                        });
                    }
                    cbxOperadora.DataSource = lstOperadoras;
                    cbxOperadora.ValueMember = "ID";
                    cbxOperadora.DisplayMember = "Descricao";
                    cbxOperadora.Enabled = true;
                }
            
            con.close(conectar);            
        }

        private void CarregaComboDDI()
        {
            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao();

            List<ModeloComboBox> lstDDI = new List<ModeloComboBox>
            {
                new ModeloComboBox { ID = 0, Descricao = "SELECIONE" }
            };


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
                    lstDDI.Add(
                        new ModeloComboBox {
                            ID = Int32.Parse(meu_reader.GetString("ID_PAIS")),
                            Descricao = meu_reader.GetString("DDI")
                        });
                }
                cbxDDI.DataSource = lstDDI;
                cbxDDI.ValueMember = "ID";
                cbxDDI.DisplayMember = "Descricao";
                cbxDDI.Enabled = true;
            }
            con.close(conectar);            
        }

        private void CarregaComboDDD()
        {
            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao();

            List<ModeloComboBox> lstDDD = new List<ModeloComboBox>
            {
                new ModeloComboBox { ID = 0, Descricao = "SELECIONE" }
            };

            //string comando = "select numero_telefone from tbt_linhas_telefonicas order by id_linha";
            string comando = " SELECT ID_CIDADE, " +
                             "        CONCAT(DDD, ' - ', NOME_CIDADE) AS DDD " +
                             " FROM TBT_CIDADES " +
                             " ORDER BY NOME_CIDADE ";

            MySqlCommand comando_ddd = con.comando_banco(comando, conectar);

            MySqlDataReader meu_reader;
            con.open(conectar);
            meu_reader = comando_ddd.ExecuteReader();

           // int i = 0;
            if (meu_reader.HasRows)
            {
                while (meu_reader.Read())
                {
                    lstDDD.Add(
                        new ModeloComboBox {
                            ID = Int32.Parse(meu_reader.GetString("ID_CIDADE")),
                            Descricao = meu_reader.GetString("DDD")
                        });
                }
                cbxDDD.DataSource = lstDDD;
                cbxDDD.ValueMember = "ID";
                cbxDDD.DisplayMember = "Descricao";
                cbxDDD.Enabled = true;
            }
            con.close(conectar);            
        }
        
        private void BtnSalvar_Click(object sender, EventArgs e)
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
        
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            TelaDistribuirAparelho.ActiveForm.Close();
        }
        
        private void CarregaComboLinha()
        {
            Conexao con = new Conexao();    // criando objeto de conexao
            MySqlConnection conectar = con.ObjConexao();

            List<ModeloComboBox> lstLinhas = new List<ModeloComboBox>
            {
                new ModeloComboBox { ID = 0, Descricao = "SELECIONE" }
            };

            string comando =    " SELECT     " +
                                " l.ID_LINHA AS ID_LINHA, " +
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
                    lstLinhas.Add(
                    new ModeloComboBox
                    {
                        ID = Int32.Parse(meu_reader.GetString("ID_LINHA")),
                        Descricao = meu_reader.GetString("TELEFONE")
                    });                    
                }
                Dados_insert.Id_linha = Int32.Parse(meu_reader.GetString("ID_LINHA"));
                cbxLinha.DataSource = lstLinhas;
                cbxLinha.ValueMember = "ID";
                cbxLinha.DisplayMember = "Descricao";
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

        private void carregaComboModelo(string id_marca)
        {
                Conexao con = new Conexao();    // criando objeto de conexao
                MySqlConnection conectar = con.ObjConexao();
                List<ModeloComboBox> lstModelos = new List<ModeloComboBox> {
                        new ModeloComboBox { ID = 0, Descricao = "SELECIONE" }
                    };

                string comando = " SELECT a.ID_APARELHO, " +
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
                comando_modelo.Parameters.Add(new MySqlParameter("@ID_MARCA", id_marca));


                meu_reader = comando_modelo.ExecuteReader();


                if (meu_reader.HasRows)
                {

                    while (meu_reader.Read())
                    {

                        lstModelos.Add(new ModeloComboBox
                        {

                            ID = Int32.Parse(meu_reader.GetString("ID_APARELHO")),
                            Descricao = meu_reader.GetString("NOME_MODELO")
                        });
                    }
                    Dados_insert.Id_aparelho = Int32.Parse(meu_reader.GetString("ID_APARELHO"));
                    con.close(conectar);
                    cbxModelo.DataSource = lstModelos;
                    cbxModelo.ValueMember = "ID";
                    cbxModelo.DisplayMember = "Descricao";
                }
                else
                {
                    MessageBox.Show("Nao há Modelos Disponivel para essa marca");
                }

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
            if (cbxModelo.SelectedIndex != 0)
            {
                CarregaComboDDI();
                cbxDDI.Enabled = true;
                CarregaFichaTecnica(cbxModelo.SelectedValue.ToString());

            }
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


            if (cbxMarca.SelectedIndex != 0)
            {
                carregaComboModelo(cbxMarca.SelectedValue.ToString());
                cbxModelo.Enabled = true;
            }
        }

        private void cbxFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaComboMarca();
            cbxMarca.Enabled = true;            
        }

        private void cbxDDI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDDI.SelectedIndex != 0)
            {
                CarregaComboDDD();
                cbxDDD.Enabled = true;
            }
        }

        private void cbxDDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDDD.SelectedIndex != 0)
            {
                CarregaComboOperadora();
                cbxOperadora.Enabled = true;
            }
        }

        private void cbxOperadora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOperadora.SelectedIndex != 0)
            {
                CarregaComboLinha();
                cbxLinha.Enabled = true;
            }
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
                CarregaComboMarca();                
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
