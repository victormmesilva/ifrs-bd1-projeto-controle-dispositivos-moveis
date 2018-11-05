using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    class Aparelhos
    {
        
        public int ID_Aparelho  { get; set; }
        public string  Senha { get; set; }
        public int Imei { get; set; }
        public string NumeroDeSerie { get; set; }
        public int MacAdress { get; set; }
        public ModelosDeCelular Modelo { get; set; }
        public LinhasTelefonicas Linha { get; set; }
        public Funcionarios Funcionario { get; set; }

        public Aparelhos(int iD_Aparelho, string senha, int imei, string numeroDeSerie, int macAdress, ModelosDeCelular modelo, LinhasTelefonicas linha, Funcionarios funcionario)
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
        public Aparelhos() { }


    }
}
