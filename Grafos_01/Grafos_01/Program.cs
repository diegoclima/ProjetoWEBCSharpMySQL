using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_01 {
    class Program {
        static void Main(string[] args) {
            GrafosDirigidos<string, string> grafo = new GrafosDirigidos<string,string>();
            grafo.addVertice(new[] { "A", "B", "C", "D"});
            grafo.addAresta("1", "2", "valor1");
            grafo.addAresta("1", "2", "valor2");
            foreach (string item in grafo.getVerticeSet()) {
                Console.WriteLine(item);
            }
            foreach (var p in grafo.getArestasSet()) {
                Console.WriteLine(p.getPrimeiro() + "-> " + p.getSegundo());

            }
            Console.ReadKey();
        }
    }
}
