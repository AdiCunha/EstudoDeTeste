using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoDeTeste.Cliente.Interface {
    public interface ICliente<T> where T : class {
        void Cadastrar(T cliente);
        void Excluir(T cliente);
    }
}
