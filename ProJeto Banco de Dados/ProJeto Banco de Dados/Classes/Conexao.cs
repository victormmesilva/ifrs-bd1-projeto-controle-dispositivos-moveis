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
        private string _conection = "Server=localhost;port=3306;UId=root;Database=PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS; Pwd=root";
        private string _conection_criarBanco = "Server=localhost;port=3306;UId=root;Database=mysql; Pwd=root";
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

            Conexao con = new Conexao();
            MySqlConnection conectar = new MySqlConnection("Server=localhost;port=3306;UId=root;Database=mysql; Pwd=root");

            string comando = "create database if not exists projeto_controle_de_dispositivos_moveis";
            
                MySqlCommand comando_consultar = con.comando_banco(comando, conectar);
                MySqlDataReader meu_reader;
                con.open(conectar);
                meu_reader = comando_consultar.ExecuteReader();
                con.close(conectar);


            

           
        }


        //public MySqlParameter Parameters(MySqlParameter filtro)
        //{

        //    comando_insert.Parameters.Add(new MySqlParameter(filtro);

        //    return comando_consultar;
        //}









    }
}
