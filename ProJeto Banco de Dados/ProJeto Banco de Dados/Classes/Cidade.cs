using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class Cidade
    {
        public String Nome { get; set; }
        public int ID { get; set; }
        public int DDD { get; set; }
        public Estado Estado { get; set; }
       

        public Cidade(string Nome, int ID, int DDD, Estado Estado)
        {
            this.Nome = Nome;
            this.ID   = ID;
            this.DDD  = DDD;
            this.Estado = Estado;
            
        }

       


    }
}
