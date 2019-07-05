using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_03 {
    class Program {
        
            public static List<Grafo> carregaGrafos(List<string> entradas) {
                List<Grafo> retorno = new List<Grafo>();
                List<string> dadosGrafo = new List<string>();
                for (int i = 0; i < entradas.Count; i++) {
                    if (!entradas[i].Contains(';')) {
                        dadosGrafo = new List<string>();
                        int j = i + 1;
                        int numVertices = int.Parse(entradas[i]);
                        dadosGrafo.Add("#" + numVertices);
                        while (numVertices > 0) {
                            dadosGrafo.Add(entradas[j]);
                            j++;
                            numVertices--;
                        }
                        string[] vetor = dadosGrafo[1].Split(';');

                        if (vetor.Length == 3) {
                            retorno.Add(new GrafoNDirigido(dadosGrafo));
                        } else {
                            retorno.Add(new GrafoDirigido(dadosGrafo));
                        }

                        i += j - 1;
                    }
                }
                return retorno;
            }
            static void Main(string[] args) {
                List<string> dadosLidosList = LerArquivo.carregar();
                List<Grafo> grafosList = carregaGrafos(dadosLidosList);
                string resp = "";
                Grafo gd = null;
                Console.Clear();
                Home.getCabecalho();
                if (grafosList[0].GetType().Equals(typeof(GrafoNDirigido))) {
                    gd = (GrafoNDirigido)grafosList[0];
                    Home.getMenuNaoDirigido();
                } else {
                    gd = (GrafoDirigido)grafosList[0];
                    Home.getMenuDirigido();
                }
                do {


                    resp = gd.setResposta(Console.ReadLine());
                    Console.ReadKey();

                } while (!resp.Equals("0"));

            }
    }
}
    

