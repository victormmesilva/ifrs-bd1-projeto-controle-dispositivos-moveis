using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class Bairro
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public Cidade Cidade { get; set; }

        public Bairro(int ID, string Nome, Cidade Cidade)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.Cidade = Cidade;
        }

        
    }
}
