using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    class Cidades
    {
        public String Nome { get; set; }
        public int ID { get; set; }
        public int DDD { get; set; }
        public Estados Estado { get; set; }
       

        public Cidades(string Nome, int ID, int DDD, Estados Estado)
        {
            this.Nome = Nome;
            this.ID   = ID;
            this.DDD  = DDD;
            this.Estado = Estado;
            
        }

       


    }
}
