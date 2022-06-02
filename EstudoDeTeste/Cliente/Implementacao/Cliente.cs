using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDeTeste.Cliente.Implementacao {
    public class Cliente  {
        public Cliente(string nome, string telefone, string email) {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

    }
}
