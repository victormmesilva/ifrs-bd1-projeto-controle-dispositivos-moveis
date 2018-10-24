using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    class Ruas
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public Bairros Bairro { get; set; }

        public Ruas(int iD, string Nome, Bairros Bairro)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.Bairro = Bairro;
        }

        
    }
}
