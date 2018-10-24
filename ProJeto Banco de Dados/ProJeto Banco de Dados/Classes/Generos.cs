using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    class Generos
    {
        public int ID { get; set; }
        public String Genero { get; set; }

        public Generos(int ID, string Genero)
        {
            this.ID = ID;
            this.Genero = Genero;
        }

        
       
    }
}
