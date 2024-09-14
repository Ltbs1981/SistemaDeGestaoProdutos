using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoProdutos
{
    public class Pedido
    {
        public int Id_pedido { get; set; }
        public String Nome_Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco_Produto { get; set; }
        public String Data_Pedido { get; set; }

        public Pedido(int id_pedido, string nome_Produto, int quantidade, double preco_Produto, string data_Pedido)
        {
            Id_pedido = id_pedido;
            Nome_Produto = nome_Produto;
            Quantidade = quantidade;
            Preco_Produto = preco_Produto;
            Data_Pedido = data_Pedido;
        }
        public double CalculandoTotal() => Quantidade * Preco_Produto;
    }
}

