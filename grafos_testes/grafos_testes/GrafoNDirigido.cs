using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafos_testes {
    class GrafoNDirigido:Grafo {
        public GrafoNDirigido(List<String> entradas) {
            foreach (string item in entradas) {
                if (item.Contains("#")) {
                    this.total_verticesGrafo = int.Parse(item.Substring(1, item.Length - 1));
                } else {
                    string[] vetor = item.Split(';');
                    Vertice vertice = vetor[0].Equals("") ? null : new Vertice(vetor[0]);
                    Vertice vertice2 = vetor[1].Equals("") ? null : new Vertice(vetor[1]);
                    int peso = vetor[2].Equals("") ? 0 : int.Parse(vetor[2]);
                    Aresta aresta = new Aresta(vertice, vertice2, peso);
                    this.vertices.Add(aresta);
                }
            }
        }

        public bool isAdjacente(string v1, string v2) {
            foreach (Aresta aresta in this.vertices) {
                if (aresta.Ini_vertice.Nome.Equals(v1) && aresta.Fim_vertice.Nome.Equals(v2))
                    return true;
               
            }
            return false;
        }
    }
}
