using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafos_testes {
    class Home {
        public static void getCabecalho() {
            Console.WriteLine("+******************************************+");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t DIEGO ");

        }

        public void getMenuNaoDirigido() {
            int op;
            Console.WriteLine("Informe uma opção> ");
            Console.Write("1 - Validar se os vertices são ADJACENTES: ");
            Console.Write("2 - Quantidade de Graus do Vértice: ");
            Console.Write("3 - Vértice é isolado: ");
            Console.Write("4 - Grafo é Regular: ");
            Console.Write("5 - Grafo é completo: ");
            Console.Write("6 - Grafo é euleriano: ");
            Console.Write("7 - Grafo Unicursal: ");
            Console.Write("8- Grafo Complementar: ");
            op = int.Parse(Console.ReadLine());


            
        }
    }
}
