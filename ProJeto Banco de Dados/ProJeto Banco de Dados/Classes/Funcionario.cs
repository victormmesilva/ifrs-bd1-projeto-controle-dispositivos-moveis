using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class Funcionario
    {
        
        public int ID_Funcionario { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime  DataNasc { get; set; }
        public int Telefone { get; set; }
        public string NomeMae { get; set; }
        public ModeloDeCelular Modelo { get; set; }
        public LinhaTelefonica Linha { get; set; }
        public Cargos cargo { get; set;}
        public Genero Genero { get; set;}
        public Rua Rua { get; set; }


        public Funcionario(int iD_Funcionario, int cpf, int rg, string nomeCompleto, DateTime dataNasc, int telefone, string nomeMae, ModeloDeCelular modelo, LinhaTelefonica linha, Cargos cargo, Genero genero, Rua rua)
        {
            ID_Funcionario = iD_Funcionario;
            Cpf = cpf;
            Rg = rg;
            NomeCompleto = nomeCompleto;
            DataNasc = dataNasc;
            Telefone = telefone;
            NomeMae = nomeMae;
            Modelo = modelo;
            Linha = linha;
            this.cargo = cargo;
            Genero = genero;
            Rua = rua;
        }


    }
}
