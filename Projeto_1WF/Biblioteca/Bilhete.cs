using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Bilhete
    {
        public Voo Id { get; set; }

        public string IdBilhete { get; set; }

        public string Nome { get; set; }

        public string Documento { get; set; }

        public string Lugar { get; set; }

        public string Classe { get; set; }

        public const string FicheiroBilhetes = "bilhetes.txt";
    }
}
