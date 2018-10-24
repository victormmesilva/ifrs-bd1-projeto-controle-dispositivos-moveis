using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    class ModelosDeCelular
    {
        public int ID { get; set; }
        public String NomeModelo { get; set; }
        public int NumeroChip { get; set; }
        public MarcasDeCelular MarcaCelular { get; set; }
        public TiposDeChip TipoDeChip { get; set; }


        public ModelosDeCelular(int ID, string NomeModelo, int NumeroChip, MarcasDeCelular MarcaCelular, TiposDeChip TipoDeChip)
        {
            this.ID = ID;
            this.NomeModelo = NomeModelo;
            this.NumeroChip = NumeroChip;
            this.MarcaCelular = MarcaCelular;
            this.TipoDeChip = TipoDeChip;
        }

      

    }
}
