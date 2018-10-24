using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class Estados
    {
        public string NomeEstado { get; set; }
        public int  IdEstado     { get; set; }
        public int  SiglaEstado  { get; set; }
        public Pais PaisEstado   { get; set; }

    }
}
