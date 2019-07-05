using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafos_testes {
    class GrafoDirigido_c:Grafo {

        public GrafoDirigido_c(List<String> entrada) {
            foreach (string item in entrada) {
                if (item.Contains("#")) {
                    this.total_verticesGrafo = int.Parse(item.Substring(1, item.Length - 1));
                } else {
                    string[] vetString = item.Split(';');
                    Vertice vertice1 = vetString[0].Equals("") ? null : new Vertice(vetString[0]);
                    Vertice vertice2 = vetString[1].Equals("") ? null : new Vertice(vetString[1]);
                    int peso = vetString[2].Equals("") ? 0 : int.Parse(vetString[2]);
                    int dir = vetString[3].Equals("") ? 0 : int.Parse(vetString[3]);
                    Aresta aresta = null;
                    if (dir==-1) {
                        aresta = new Aresta(vertice2, vertice1, peso);
                    } else if (dir ==1) {
                        aresta = new Aresta(vertice1, vertice2, peso);
                    }
                    

                    
                        this.vertices.Add(aresta);

                }
            }
        }

        public int getGrauVertice(string v1) {
            int grau = 0;
            foreach (Aresta item in this.vertices) {
                if (item.Fim_vertice != null && item.Fim_vertice.Nome.Equals(v1)) {
                    grau++;
                } else
                    return 0;

            }
            return grau;
        }
    }
}
