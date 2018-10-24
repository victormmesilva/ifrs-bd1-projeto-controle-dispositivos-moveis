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
        public int IdEstado { get; set; }
        public int SiglaEstado { get; set; }
        public Pais PaisEstado { get; set; }

        public Estados(string NomeEstado, int IdEstado, int SiglaEstado, Pais PaisEstado)
        {
            this.NomeEstado = NomeEstado;
            this.IdEstado   = IdEstado;
            this.SiglaEstado= SiglaEstado;
            this.PaisEstado = PaisEstado;
        }

        

    }


}
