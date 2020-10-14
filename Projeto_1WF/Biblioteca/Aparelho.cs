using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Aparelho
    {
        public string Id { get; set; }

        public int Quantidade { get; set; }

        public string Modelo { get; set; }

        public int LugaresEconomicos { get; set; }

        public int LugaresExecutivos { get; set; }

        

        public const string FicheiroAparelhos = "aparelhos.txt";

        public override string ToString()
        {
            return Modelo;
        }
        public Aparelho(string modelo)
        {
            Modelo = modelo;
        }

        public Aparelho()
        {

        }
    }
}
