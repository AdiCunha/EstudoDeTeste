
using EstudoDeTeste.Cliente.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDeTeste.Cliente.Implementacao {
    public class Tabela : ICliente <Cliente> {
        public List<Cliente> ListaCliente { get; set; }

        public void Cadastrar(Cliente cliente) {
            ListaCliente.Add(cliente);
            }

        public void Excluir(Cliente cliente) {
            ListaCliente.Remove(cliente);   
        }
    }
}
