using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    class LinhasTelefonicas
    {
        public int ID { get; set; }
        public int NumeroTelefone { get; set; }
        public Cidades Cidade { get; set; }
        public Pais Pais { get; set; }
        public OperadorasTelefonicas Operadora { get; set; }

        public LinhasTelefonicas(int ID, int NumeroTelefone, Cidades Cidade, Pais Pais, OperadorasTelefonicas Operadora)
        {
            this.ID = ID;
            this.NumeroTelefone = NumeroTelefone;
            this.Cidade = Cidade;
            this.Pais = Pais;
            this.Operadora = Operadora;
        }

        

    }
}
