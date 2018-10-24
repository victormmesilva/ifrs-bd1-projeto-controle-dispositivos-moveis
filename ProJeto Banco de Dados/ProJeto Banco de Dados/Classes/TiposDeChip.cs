using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    class TiposDeChip
    {
        public int ID { get; set; }
        public String NomeTipoShip { get; set; }

        public TiposDeChip(int ID, string NomeTipoShip)
        {
            this.ID = ID;
            this.NomeTipoShip = NomeTipoShip;
        }

        


    }
}
