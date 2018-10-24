using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    class Cargos
    {
        public int ID { get; set; }
        public Generos Genero { get; set; }

        public Cargos(int ID, Generos Genero)
        {
            this.ID = ID;
            this.Genero = Genero;
        }

        




    }
}
