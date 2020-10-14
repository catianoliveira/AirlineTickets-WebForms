using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Voo
    {
        public string Id { get; set; }

        public Aeroporto AeroportoOrigem { get; set; }

        public Aeroporto AeroportoDestino { get; set; }

        public string Dia { get; set; }

        public string Hora { get; set; }

        public Aparelho Aparelho { get; set; }

        public Bilhete ListaBilhetes { get; set; }

        public override string ToString()
        {
            return Id;
        }

        public Voo(string voo)
        {
            Id = voo;
        }

        public Voo()
        {

        }

        public const string FicheiroVoos = "voos.txt";
    }
}
