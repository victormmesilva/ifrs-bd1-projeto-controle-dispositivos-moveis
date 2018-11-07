using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class TipoDeChip
    {
        public int ID { get; set; }
        public String NomeTipoShip { get; set; }

        public TipoDeChip(int ID, string NomeTipoShip)
        {
            this.ID = ID;
            this.NomeTipoShip = NomeTipoShip;
        }
    }
}
