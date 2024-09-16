using System;

namespace SistemaGestaoProdutos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à plataforma de pedidos");

            
            Console.Write("Por favor, informe o nome do cliente: ");
            string nomeCliente = Console.ReadLine();
            Cliente cliente = new Cliente(nomeCliente);

            int opcao = -1; // Inicializa a variável 'opcao'


            while (opcao != 0)
            {
                Console.WriteLine("\nSelecione uma opção:");
                Console.WriteLine("1 - Adicionar Pedido Nacional");
                Console.WriteLine("2 - Adicionar Pedido Internacional");
                Console.WriteLine("3 - Listar seus pedidos");
                Console.WriteLine("4 - Apagar um pedido");
                Console.WriteLine("5 - Apagar todos os pedidos");
                Console.WriteLine("0 - Sair");

                
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        // Adiciona pedido nacional
                        Console.Write("Informe o nome do produto: ");
                        string nomeProdutoNacional = Console.ReadLine();
                        Console.Write("Informe a quantidade: ");
                        int quantidadeNacional = int.Parse(Console.ReadLine());
                        Console.Write("Informe o preço do produto: ");
                        double precoNacional = double.Parse(Console.ReadLine());
                        Console.Write("Informe a data do pedido: ");
                        string dataPedidoNacional = Console.ReadLine();

                        
                        PedidoNacional pedidoNacional = new PedidoNacional(1, nomeProdutoNacional, quantidadeNacional, precoNacional, dataPedidoNacional, 0.10);
                        cliente.AdicionarPedido(pedidoNacional);
                        break;

                    case 2:

                        Console.Write("Informe o nome do produto: ");
                        string nomeProdutoInternacional = Console.ReadLine();
                        Console.Write("Informe a quantidade: ");
                        int quantidadeInternacional = int.Parse(Console.ReadLine());
                        Console.Write("Informe o preço do produto: ");
                        double precoInternacional = double.Parse(Console.ReadLine());
                        Console.Write("Informe a data do pedido: ");
                        string dataPedidoInternacional = Console.ReadLine();

                        
                        PedidoInternacional pedidoInternacional = new PedidoInternacional(2, nomeProdutoInternacional, quantidadeInternacional, precoInternacional, dataPedidoInternacional, 0.20);
                        cliente.AdicionarPedido(pedidoInternacional);
                        break;

                    case 3:
                        
                        Console.WriteLine($"Pedidos de: {nomeCliente}");
                        cliente.ListarPedidos();
                        Console.WriteLine($"Total de todos os pedidos: {cliente.CalcularTotalDeTodosOsPedidos():C}");
                        break;

                    case 4:
                        // Apaga um pedido específico
                        Console.Write("Informe o índice do pedido que deseja apagar: ");
                        int indice = int.Parse(Console.ReadLine());
                        cliente.ApagarPedido(indice);
                        break;

                    case 5:
                        // Apaga todos os pedidos
                        cliente.ApagarTodosOsPedidos();
                        break;

                    case 0:
                                                Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
