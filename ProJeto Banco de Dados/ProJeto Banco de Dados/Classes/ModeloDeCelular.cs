using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class ModeloDeCelular
    {
        public int ID { get; set; }
        public String NomeModelo { 

            set {
                Conexao con = new Conexao();
                MySqlConnection conectar = con.ObjConexao();
                string comando = "select * from tbt_modelos where ";
                //con.objConexao = new MySqlConnection();
                MySqlCommand comando_consultar = con.comando_banco(comando, conectar);
                MySqlDataReader meu_reader;
            }
        }
        public int NumeroChip { get; set; }
        public MarcaDeCelular MarcaCelular { get; set; }
        public TipoDeChip TipoDeChip { get; set; }


        public ModeloDeCelular(int ID, string NomeModelo, int NumeroChip, MarcaDeCelular MarcaCelular, TipoDeChip TipoDeChip)
        {
            this.ID = ID;
            this.NomeModelo = NomeModelo;
            this.NumeroChip = NumeroChip;
            this.MarcaCelular = MarcaCelular;
            this.TipoDeChip = TipoDeChip;
        }



      

    }
}
