using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class LinhaTelefonica
    {
        public int ID { get; set; }
        public int NumeroTelefone { get; set; }
        public Cidade Cidade { get; set; }
        public Pais Pais { get; set; }
        public OperadoraTelefonica Operadora { get; set; }

        public LinhaTelefonica(int ID, int NumeroTelefone, Cidade Cidade, Pais Pais, OperadoraTelefonica Operadora)
        {
            this.ID = ID;
            this.NumeroTelefone = NumeroTelefone;
            this.Cidade = Cidade;
            this.Pais = Pais;
            this.Operadora = Operadora;
        }

        

    }
}
