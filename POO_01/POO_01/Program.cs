using System;
using POO_01.Classes.Exercicio_01;
using POO_01.Classes.System;
using System.Globalization;
using System.Collections.Generic;


namespace POO_01 {
    class Program {
        static void Main(string[] args) {
            //Produto p = new Produto();
            //Console.WriteLine("Entre os dados do produto: ");
            //Console.Write("Nome: ");
            //p.Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Console.Write("Quantidade: ");
            //p.Quantidade = int.Parse(Console.ReadLine());

            ////Dessa forma será impresso somente o namespace e classe. É necessária a utilização de toString;
            //// Console.WriteLine("Dados do Produto: " + p);

            //Console.WriteLine(p);
            //Console.Write("Digite o numero de produtos a ser adicionados ao estoque: ");
            //int qtde = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qtde);
            //Console.WriteLine("\nDados atualizados: " + p.ToString());
            //Console.Write("Digite a quantidade a ser removida do estoque: ");
            //int qt = int.Parse(Console.ReadLine());
            //p.RemoverProduto(qt);
            //Console.WriteLine("\nDados atualizados: " + p.ToString());

            Calculadora c = new Calculadora();

            //Console.Write("Raio: ");
            //double raio = double.Parse(Console.ReadLine());
            //Console.WriteLine("Circunferência: " + Calculadora.Circunferencia(raio));
            //Console.WriteLine("Volume " + Calculadora.Volume(raio));
            //Console.WriteLine("Raio: " + raio);
            //List<string> list = new List<string>();
            //list.Add("Maria");
            //    Order order = new Order {

            //        Id = 1080,
            //        Moment = DateTime.Now,
            //        Status = OrderStatus.PendingPayment


            //    };
            //Console.WriteLine(order);
            //    string txt = OrderStatus.PendingPayment.ToString();

            //    Console.WriteLine(txt);
            //    //Conversao de string para enum
            //    OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            //    Console.WriteLine(os);
            //    Console.WriteLine(txt);
            Console.Write("Entre com o departamento: ");
            string departamento = Console.ReadLine();
            Console.Write("Digite os dados do trabalhador: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nível: (Junior/MidLevel,Senior)");
            WorkerLevel nivel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Informe o salário base: ");
            double baseSalarial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Departamento dp = new Departamento(departamento);
            //Associacao;
            Worker worker = new Worker(nome, nivel, baseSalarial, dp);
            Console.Write("Quantos contratos para " + nome + ": " );
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++) {
                Console.Write($"Entre com #" + i + " dados do contrato: ");
                Console.Write("Data: (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valueperhour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duração: horas: ");
                int horas = int.Parse(Console.ReadLine());
                HourContract contrato = new HourContract(date, valueperhour, horas);
                worker.AdicionaContrato(contrato);
            }
            Console.Write("Entre com o mes e ano: ");
            string mesEano = Console.ReadLine();
            int mes = int.Parse(mesEano.Substring(0, 2));
            int ano = int.Parse(mesEano.Substring(3));
            Console.WriteLine("Nome " + worker.Nome);
            Console.WriteLine("Departamento: " + worker.departament.Nome);
            Console.WriteLine("Valor: " + mesEano + ": " + worker.Income(ano,mes).ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey();
        }

      


    }
}
