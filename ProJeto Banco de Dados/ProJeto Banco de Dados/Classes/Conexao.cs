using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class Conexao
    {
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

                string cmd_procedure = System.IO.File.ReadAllText(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\TextFile1.txt");

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

                string cmd_procedure = System.IO.File.ReadAllText(@"D:\Projetos\PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS\ProJeto Banco de Dados\ProJeto Banco de Dados\Recursos\InserirDados.txt");

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
    }
}
