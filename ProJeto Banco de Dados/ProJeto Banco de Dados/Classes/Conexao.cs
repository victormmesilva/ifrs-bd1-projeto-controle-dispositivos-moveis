using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class Conexao
    {
        private string _conection = "Server=localhost;port=3306;UId=root;Database=PROJETO_CONTROLE_DE_DISPOSITIVOS_MOVEIS; Pwd=root";
        private string fltro;

        public  MySqlConnection ObjConexao(){
             
            MySqlConnection objConexao = new MySqlConnection(this._conection);
            return objConexao;
        }

        public MySqlCommand comando_consultar (string comando, MySqlConnection conectar)
        {

            MySqlCommand comando_consultar = new MySqlCommand(comando, conectar);
            
            return comando_consultar;
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

        //public MySqlParameter Parameters(MySqlParameter filtro)
        //{

        //    comando_insert.Parameters.Add(new MySqlParameter(filtro);

        //    return comando_consultar;
        //}









    }
}
