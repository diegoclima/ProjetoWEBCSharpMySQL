using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Pratica_0 {
    class ListaAdjacenciaPonderada<T>:ListaAdjacenciaGrafo<T>, IGrafo<T> {

        public ListaAdjacenciaPonderada(int max, bool dir):
            base(max, dir) {

        }
        public int IndiceVertice (Vertice<T> u) {
            return ((IndiceVertice<T>)u).Index();
        }

        public override void adicionaAresta(int u, int v) {
            adicionaAresta(u, v, 0);
        }

        public void adicionaAresta(int u, int v, int peso) {
            Peso_Aresta<T> a = new Peso_Aresta<T>(GetVertice(u), GetVertice(v), peso);
            adj[u].adicionaAresta(a);
            if (!dirigido) {
                a = new Peso_Aresta<T>(GetVertice(v), GetVertice(u), peso);
                adj[v].adicionaAresta(a);
            }
            nArestas++;
        }
        public void adicionaAresta(Vertice<T> u, Vertice<T> v, int peso) {
            adicionaAresta(IndiceVertice(u), IndiceVertice(v), peso;
        }
        public 


    }
}
