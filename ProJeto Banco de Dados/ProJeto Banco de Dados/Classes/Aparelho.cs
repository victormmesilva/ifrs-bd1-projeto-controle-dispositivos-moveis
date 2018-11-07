using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class Aparelho
    {
        
        public int ID_Aparelho  { get; set; }
        public string  Senha { get; set; }
        public int Imei { get; set; }
        public string NumeroDeSerie { get; set; }
        public int MacAdress { get; set; }
        public ModeloDeCelular Modelo { get; set; }
        public LinhaTelefonica Linha { get; set; }
        public Funcionario Funcionario { get; set; }

        public Aparelho(int iD_Aparelho, string senha, int imei, string numeroDeSerie, int macAdress, ModeloDeCelular modelo, LinhaTelefonica linha, Funcionario funcionario)
        {
            ID_Aparelho = iD_Aparelho;
            Senha = senha;
            Imei = imei;
            NumeroDeSerie = numeroDeSerie;
            MacAdress = macAdress;
            Modelo = modelo;
            Linha = linha;
            Funcionario = funcionario;
        }
        public Aparelho() { }


    }
}
