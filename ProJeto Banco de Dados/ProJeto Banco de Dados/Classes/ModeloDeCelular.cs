using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProJeto_Banco_de_Dados.Classes
{
    public class ModeloDeCelular
    {
        public int ID { get; set; }
        public String NomeModelo { get; set; }
        public int NumeroChip { get; set; }
        public MarcaDeCelular MarcaCelular { get; set; }
        public TipoDeChip TipoDeChip { get; set; }


        public ModeloDeCelular(int ID, string NomeModelo, int NumeroChip, MarcaDeCelular MarcaCelular, TipoDeChip TipoDeChip)
        {
            this.ID = ID;
            this.NomeModelo = NomeModelo;
            this.NumeroChip = NumeroChip;
            this.MarcaCelular = MarcaCelular;
            this.TipoDeChip = TipoDeChip;
        }

      

    }
}
