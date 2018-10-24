using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    class OperadorasTelefonicas
    {
        public int ID { get; set; }
        public String Operadora { get; set; }

        public OperadorasTelefonicas(int ID, string Operadora)
        {
            this.ID = ID;
            this.Operadora = Operadora;
        }

        


    }
}
