using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class Rua
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public Bairro Bairro { get; set; }

        public Rua(int ID, string Nome, Bairro Bairro)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.Bairro = Bairro;
        }

        
    }
}
