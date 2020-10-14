using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
   public class Cliente
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public string DN { get; set; }

        public string Documento { get; set; }

        public string Genero { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public const string FicheiroClientes = "clientes.txt";
    }
}
