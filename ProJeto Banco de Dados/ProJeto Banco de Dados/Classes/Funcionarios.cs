using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    class Funcionarios
    {
        
        public int ID_Funcionario { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime  DataNasc { get; set; }
        public int Telefone { get; set; }
        public string NomeMae { get; set; }
        public ModelosDeCelular Modelo { get; set; }
        public LinhasTelefonicas Linha { get; set; }
        public Cargos cargo { get; set;}
        public Generos Genero { get; set;}
        public Ruas Rua { get; set; }


        public Funcionarios(int iD_Funcionario, int cpf, int rg, string nomeCompleto, DateTime dataNasc, int telefone, string nomeMae, ModelosDeCelular modelo, LinhasTelefonicas linha, Cargos cargo, Generos genero, Ruas rua)
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
