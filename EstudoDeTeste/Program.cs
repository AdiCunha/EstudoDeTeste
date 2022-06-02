using EstudoDeTeste.Cliente.Implementacao;
using Newtonsoft.Json;
using System.Text.Json;

namespace Program {


    public class Program {
        public static void Main(string[] args) {

            Tabela tabela = new Tabela {
                ListaCliente = new List<Cliente>()
            };

            Console.WriteLine("[1] Adicionar, [0] Excluir");
            int op = int.Parse(Console.ReadLine());

            switch (op) {
                case 0:
                    Console.WriteLine("Boa tarde, Cliente, insira os seguintes dados: ");
                    Console.Write("Insira seu nome: ");
                    string nomeUsuario = Console.ReadLine();

                    Console.Write("Insira seu Telefone: ");
                    string telUsuario = Console.ReadLine();

                    Console.Write("Insira seu Email: ");
                    string emailUsuario = Console.ReadLine();

                    Cliente ClienteMaisBonito = new Cliente(nomeUsuario, telUsuario, emailUsuario);
                    tabela.Excluir(ClienteMaisBonito);
                    var CLienteJson = JsonConvert.SerializeObject(tabela);
                    Console.WriteLine(CLienteJson);
                    break;

                case 1:
                    Console.WriteLine("Boa tarde, Cliente, insira os seguintes dados: ");
                    Console.Write("Insira seu nome: ");
                    string nomeUsuarioC = Console.ReadLine();

                    Console.Write("Insira seu Telefone: ");
                    string telUsuarioC = Console.ReadLine();

                    Console.Write("Insira seu Email: ");
                    string emailUsuarioC = Console.ReadLine();

                    Cliente ClienteMaisBonitoC = new Cliente(nomeUsuarioC, telUsuarioC, emailUsuarioC);
                    tabela.Cadastrar(ClienteMaisBonitoC);
                    var CLienteJson = JsonConvert.SerializeObject(tabela);
                    Console.WriteLine(CLienteJson);
                    break;
            }
        }
    }
}