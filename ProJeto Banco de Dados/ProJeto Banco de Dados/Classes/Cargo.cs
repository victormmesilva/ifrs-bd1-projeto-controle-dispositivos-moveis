using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class Cargos
    {
        public int ID { get; set; }
        public Genero Genero { get; set; }

        public Cargos(int ID, Genero Genero)
        {
            this.ID = ID;
            this.Genero = Genero;
        }

        




    }
}
