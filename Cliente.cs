using System;
using System.Collections.Generic;

namespace SistemaGestaoProdutos
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        private List<Pedido> listaPedidos;

        public Cliente(string nomeCliente)
        {
            NomeCliente = nomeCliente;
            listaPedidos = new List<Pedido>();
        }

        public void AdicionarPedido(Pedido pedido)
        {
            listaPedidos.Add(pedido);
            Console.WriteLine("Pedido adicionado com sucesso!");
        }

        public void ApagarPedido(int indice)
        {
            if (indice >= 0 && indice < listaPedidos.Count)
            {
                listaPedidos.RemoveAt(indice);
                Console.WriteLine("Pedido apagado com sucesso!");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
        }

        public void ListarPedidos()
        {
            if (listaPedidos.Count == 0)
            {
                Console.WriteLine("Nenhum pedido registrado.");
                return;
            }

            for (int i = 0; i < listaPedidos.Count; i++)
            {
                Console.WriteLine($"Pedido {i + 1}: {listaPedidos[i].Nome_Produto}, Total: {listaPedidos[i].CalculandoTotal():C}");
            }
        }

        public void ApagarTodosOsPedidos()
        {
            listaPedidos.Clear();
            Console.WriteLine("Todos os pedidos foram apagados.");
        }

        public double CalcularTotalDeTodosOsPedidos()
        {
            double total = 0;
            foreach (var pedido in listaPedidos)
            {
                total += pedido.CalculandoTotal();
            }
            return total;
        }
    }
}
