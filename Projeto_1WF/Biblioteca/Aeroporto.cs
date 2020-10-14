using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Aeroporto
    {
        public string ID { get; set; }

        public string AeroportoNome { get; set; }

        public string Cidade { get; set; }

        public string País { get; set; }

        public const string FicheiroAeroportos = "aeroportos.txt";

        public override string ToString()
        {
            return AeroportoNome;
        }

        public Aeroporto(string aeroporto)
        {
            AeroportoNome = aeroporto;
        }

        public Aeroporto()
        {

        }
    }
}
