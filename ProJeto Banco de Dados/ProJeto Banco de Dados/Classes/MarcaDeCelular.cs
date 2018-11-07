using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class MarcaDeCelular
    {
        public int ID { get; set; }
        public String NomeMarca { get; set; }

        public MarcaDeCelular(int ID, string NomeMarca)
        {
            this.ID = ID;
            this.NomeMarca = NomeMarca;
        }

        

    }
}
