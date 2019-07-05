using System;
using POO_03_Enuns;
namespace POO_03_Enuns.Entidades.System {
    class Program {
        static void Main(string[] args)     {
            Console.WriteLine("Entre com os dados do Cliente: ");
            Console.Write("Nome: ");
            string clienteNome = Console.ReadLine();
            Console.Write("Email: ");
            string emailCliente = Console.ReadLine();
            Console.Write("Data de Nascimento: ");
            DateTime dataNasc = DateTime.Parse(Console.ReadLine());
            Console.Clear();
            Console.ReadKey();
            Console.WriteLine("Entre com os dados do Pedido: ");
            Console.Write("Status: ");
            StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());
            Cliente c = new Cliente(clienteNome, emailCliente, dataNasc);
            Pedido pedido = new Pedido(DateTime.Now, status, c);
            Console.Write("Quantos itens para o pedido: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++) {
                Console.Write("Entre com o " + i + "º pedido: ");
                Console.Write("Produto: ");
                string produtoN = Console.ReadLine();
                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine());
                Produto p1 = new Produto(produtoN, preco);
                Console.Write("Quantidade: ");
                int q = int.Parse(Console.ReadLine());

                ItensPedido itens = new ItensPedido(q, preco);
                pedido.AddItem(itens);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(pedido);
            Console.ReadKey();
        }
    }
}
