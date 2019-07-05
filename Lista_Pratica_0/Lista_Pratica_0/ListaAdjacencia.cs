using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Pratica_0 {
    class ListaAdjacencia<T> {
        private IndiceVertice<T> vertice;
        private NodoAresta<T> cabeca;
        private int tamanho;

        public ListaAdjacencia(IndiceVertice<T> v) {
            vertice = v;
            cabeca = null;
            tamanho = 0;
        }

        public Vertice<T> Vertices() {
            return vertice;

        }

        public void setCabeca(NodoAresta<T> n) {
            cabeca = n;
        }

        public NodoAresta<T> getCabeca() {
            return cabeca;
        }

        public void adicionaAresta(Aresta<T> a) {
            NodoAresta<T> nodo_a = new NodoAresta<T>(a, getCabeca());
            setCabeca(nodo_a);
            tamanho++;
        }
    }
}
