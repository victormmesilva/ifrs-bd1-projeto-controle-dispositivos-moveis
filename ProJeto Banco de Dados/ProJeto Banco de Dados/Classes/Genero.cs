using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class Genero
    {
        public int ID { get; set; }
        public String NomeGenero { get; set; }

        public Genero(int ID, string Genero)
        {
            this.ID = ID;
            this.NomeGenero = Genero;
        }

        
       
    }
}
