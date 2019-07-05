using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafos_testes {
    class Program {
        public static List<Grafo> carregaGrafo(List<String> entrada) {
            int cont = 0;
            List<Grafo> retorno = new List<Grafo>();
            List<string> dadosGrafo = new List<string>();
           
            for (int i = 0; i < entrada.Count; i++) {
                if (!entrada[i].Contains(';')) {
                    dadosGrafo = new List<string>();
                    cont = i + 1;
                    int numVertices = int.Parse(entrada[i]);
                    dadosGrafo.Add("# " + numVertices);
                    while (numVertices>0) {
                        dadosGrafo.Add(entrada[cont]);
                        cont++;
                        numVertices--;
                    }
                }
                string[] vetor = dadosGrafo[0].Split(';');
                
               // vetor[i] = dadosGrafo[0].Split(';');
                if (vetor.Length==3) {
                    retorno.Add(new GrafoNDirigido(dadosGrafo));
                } else {
                    retorno.Add(new GrafoDirigido(dadosGrafo));
                }
                i += cont - 1;
            }
            return retorno;
        }
        static void Main(string[] args) {
            List<string> dadosLidosList = Entrada_Arquivo.carregar();
            List<Grafo> grafos = carregaGrafo(dadosLidosList);
            string resp = "";
            Grafo gd = new Grafo();
            Console.WriteLine(gd.ToString());
            
            Console.ReadKey();
            
        }
    }
}
