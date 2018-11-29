using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class Conexao
    {
        //Victor
        //private readonly string _conection = "Server=localhost;port=3306;UId=root;Database=PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS; Pwd=mysqladmin";
        //private readonly string _conection_criarBanco = "Server=localhost;port=3306;UId=root;Database=mysql; Pwd=mysqladmin";
        //Ederson
        private readonly string _conection = "Server=localhost;port=3306;UId=root;Database=PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS; Pwd=root";
        private readonly string _conection_criarBanco = "Server=localhost;port=3306;UId=root;Database=mysql; Pwd=root";

        private string fltro;

        public  MySqlConnection ObjConexao(){

         
                MySqlConnection objConexao = new MySqlConnection(this._conection);
                return objConexao;
                     
        }

        public MySqlCommand comando_banco (string comando, MySqlConnection conectar)
        {

            MySqlCommand comando_banco = new MySqlCommand(comando, conectar);
            
            return comando_banco;
        }
        public MySqlConnection open(MySqlConnection ObjConexao)
        {
            ObjConexao.Open();

            return ObjConexao;
        }
        public MySqlConnection close(MySqlConnection ObjConexao)
        {
            ObjConexao.Close();

            return ObjConexao;
        }
        public static void CriarBancoIniciar()
        {


            try
            {
                Conexao con = new Conexao();
                //Victor
                //MySqlConnection conectar = new MySqlConnection("Server=localhost;port=3306;UId=root;Database=mysql; Pwd=mysqladmin");
                //Ederson
                MySqlConnection conectar = new MySqlConnection("Server=localhost;port=3306;UId=root;Database=mysql; Pwd=root");

                string comando = "create database if not exists projeto_controle_de_dispositivos_moveis";

                MySqlCommand comando_consultar = con.comando_banco(comando, conectar);
                MySqlDataReader meu_reader;
                con.open(conectar);
                meu_reader = comando_consultar.ExecuteReader();
                con.close(conectar);
   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public static void CriarProcedure()
        {
            try { 

                Conexao con = new Conexao();
                MySqlConnection conectar = con.ObjConexao();
                //Victor 
                //string cmd_procedure = System.IO.File.ReadAllText(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\CriarBanco.txt");
                //Ederson
                string cmd_procedure = System.IO.File.ReadAllText(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\CriarBanco.txt");
                MySqlCommand comando_criarProcedure= con.comando_banco(cmd_procedure, conectar);
                MySqlDataReader meu_reader_procedure;
                con.open(conectar);
                meu_reader_procedure = comando_criarProcedure.ExecuteReader();
                con.close(conectar);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void insertDados()
        {
            try
            {

                Conexao con = new Conexao();
                MySqlConnection conectar = con.ObjConexao();

                string cmd_procedure = System.IO.File.ReadAllText(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos.txt");

                MySqlCommand comando_criarProcedure = con.comando_banco(cmd_procedure, conectar);
                MySqlDataReader meu_reader_procedure;
                con.open(conectar);
                meu_reader_procedure = comando_criarProcedure.ExecuteReader();
                con.close(conectar);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




        public static void CriarTabelas()
        {
            try
            {
                Conexao con = new Conexao();
                MySqlConnection conectar = con.ObjConexao();
                string cmd_comando = "use PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS; call PRO_CRIAR_TABELAS";
                MySqlCommand comando_criarTabela = con.comando_banco(cmd_comando, conectar);
                MySqlDataReader meu_reader_tabelas;
                con.open(conectar);
                meu_reader_tabelas = comando_criarTabela.ExecuteReader();
                con.close(conectar);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        internal class FotoModelo {
            public int IdModelo { get; set; }
            public FileStream Foto  { get; set; }
        }

        public static void CarregarFoto()
        {
            List<FotoModelo> fstream = new List<FotoModelo>{
                //new FotoModelo {IdModelo = 1,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\1.png", FileMode.Open, FileAccess.Read)},
                //new FotoModelo {IdModelo = 2,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\2.png", FileMode.Open, FileAccess.Read)},
                //new FotoModelo {IdModelo = 3,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\3.png", FileMode.Open, FileAccess.Read)},
                //new FotoModelo {IdModelo = 4,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\4.png", FileMode.Open, FileAccess.Read)},
                //new FotoModelo {IdModelo = 5,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\5.png", FileMode.Open, FileAccess.Read)},
                //new FotoModelo {IdModelo = 6,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\6.png", FileMode.Open, FileAccess.Read)},
                //new FotoModelo {IdModelo = 7,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\7.png", FileMode.Open, FileAccess.Read)},
                //new FotoModelo {IdModelo = 8,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\8.png", FileMode.Open, FileAccess.Read)},
                //new FotoModelo {IdModelo = 9,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\9.png", FileMode.Open, FileAccess.Read)},
                //new FotoModelo {IdModelo = 10,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\10.png", FileMode.Open, FileAccess.Read)},
                //new FotoModelo {IdModelo = 11,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\11.png", FileMode.Open, FileAccess.Read)},
                //new FotoModelo {IdModelo = 12,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\12.png", FileMode.Open, FileAccess.Read)},
                //new FotoModelo {IdModelo = 13,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\13.png", FileMode.Open, FileAccess.Read)},
                //new FotoModelo {IdModelo = 14,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\14.png", FileMode.Open, FileAccess.Read)},
                //new FotoModelo {IdModelo = 15,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\15.png", FileMode.Open, FileAccess.Read)},
                //new FotoModelo {IdModelo = 16,Foto = new FileStream(@"C:\Users\c1n2v\Documents\git\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\Modelos\16.png", FileMode.Open, FileAccess.Read)},

                new FotoModelo {IdModelo = 1,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\1.png", FileMode.Open, FileAccess.Read)},
                new FotoModelo {IdModelo = 2,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\2.png", FileMode.Open, FileAccess.Read)},
                new FotoModelo {IdModelo = 3,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\3.png", FileMode.Open, FileAccess.Read)},
                new FotoModelo {IdModelo = 4,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\4.png", FileMode.Open, FileAccess.Read)},
                new FotoModelo {IdModelo = 5,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\5.png", FileMode.Open, FileAccess.Read)},
                new FotoModelo {IdModelo = 6,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\6.png", FileMode.Open, FileAccess.Read)},
                new FotoModelo {IdModelo = 7,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\7.png", FileMode.Open, FileAccess.Read)},
                new FotoModelo {IdModelo = 8,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\8.png", FileMode.Open, FileAccess.Read)},
                new FotoModelo {IdModelo = 9,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\9.png", FileMode.Open, FileAccess.Read)},
                new FotoModelo {IdModelo = 10,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\10.png", FileMode.Open, FileAccess.Read)},
                new FotoModelo {IdModelo = 11,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\11.png", FileMode.Open, FileAccess.Read)},
                new FotoModelo {IdModelo = 12,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\12.png", FileMode.Open, FileAccess.Read)},
                new FotoModelo {IdModelo = 13,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\13.png", FileMode.Open, FileAccess.Read)},
                new FotoModelo {IdModelo = 14,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\14.png", FileMode.Open, FileAccess.Read)},
                new FotoModelo {IdModelo = 15,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\15.png", FileMode.Open, FileAccess.Read)},
                new FotoModelo {IdModelo = 16,Foto = new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\16.png", FileMode.Open, FileAccess.Read)},
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                //new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS-Bd1\ProJeto Banco de Dados\ProJeto Banco de Dados\Modelos\2.png", FileMode.Open, FileAccess.Read),
                //new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS-Bd1\ProJeto Banco de Dados\ProJeto Banco de Dados\Modelos\3.png", FileMode.Open, FileAccess.Read),
                //new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS-Bd1\ProJeto Banco de Dados\ProJeto Banco de Dados\Modelos\4.png", FileMode.Open, FileAccess.Read),
                //new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS-Bd1\ProJeto Banco de Dados\ProJeto Banco de Dados\Modelos\5.png", FileMode.Open, FileAccess.Read),
                //new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS-Bd1\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\6.png", FileMode.Open, FileAccess.Read),
                //new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS-Bd1\ProJeto Banco de Dados\ProJeto Banco de Dados\Modelos\7.png", FileMode.Open, FileAccess.Read),
                //new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS-Bd1\ProJeto Banco de Dados\ProJeto Banco de Dados\Modelos\8.png", FileMode.Open, FileAccess.Read),
                //new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS-Bd1\ProJeto Banco de Dados\ProJeto Banco de Dados\Modelos\9.png", FileMode.Open, FileAccess.Read),
                //new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS-Bd1\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\10.png", FileMode.Open, FileAccess.Read),
                //new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS-Bd1\ProJeto Banco de Dados\ProJeto Banco de Dados\Modelos\11.png", FileMode.Open, FileAccess.Read),
                //new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS-Bd1\ProJeto Banco de Dados\ProJeto Banco de Dados\Modelos\12.png", FileMode.Open, FileAccess.Read),
                //new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS-Bd1\ProJeto Banco de Dados\ProJeto Banco de Dados\Modelos\13.png", FileMode.Open, FileAccess.Read),
                //new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS-Bd1\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\14.png", FileMode.Open, FileAccess.Read),
                //new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS-Bd1\ProJeto Banco de Dados\ProJeto Banco de Dados\Modelos\15.png", FileMode.Open, FileAccess.Read),
                //new FileStream(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS-Bd1\ProJeto Banco de Dados\ProJeto Banco de Dados\Modelos\16.png", FileMode.Open, FileAccess.Read)
            };


            //for (int i = 1; i <= 16; i++)
            foreach(FotoModelo file in fstream)
            {
                byte[] imagem_byti = null;
                BinaryReader br = new BinaryReader(file.Foto);
                imagem_byti = br.ReadBytes((int)file.Foto.Length);                

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



                    comando_insert.Parameters.Add(new MySqlParameter("@filtro", file.IdModelo));
                    comando_insert.Parameters.Add(new MySqlParameter("@FOTO", imagem_byti));

                    // comando_insert.Parameters.Add(new MySqlParameter("@nome_Aparelho", txtNome.Text));
                    // var rowsAffecteds = comando_insert.ExecuteNonQuery();

                    meu_reader = comando_insert.ExecuteReader();

                   //MessageBox.Show("FOTO SALVA Salvo");
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


    
}
