using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados
{
    public class Pais
    {
        public string Nome { get; set; }
        public int ID { get; set; }
        public int DDI { get; set; }


        public Pais(string Nome, int ID, int DDI)
        {
            this.Nome = Nome;
            this.ID   = ID;
            this.DDI  = DDI;
        }

        
       
    }
}
