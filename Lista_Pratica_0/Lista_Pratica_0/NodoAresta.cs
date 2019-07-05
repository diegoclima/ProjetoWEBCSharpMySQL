using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Pratica_0 {
    class NodoAresta<T> {
        protected Aresta<T> aresta;
        protected NodoAresta<T> prox;

        public NodoAresta(Aresta<T> a) {
           
        }

        public NodoAresta(Aresta<T> aresta, NodoAresta<T> prox) {
            this.aresta = aresta;
            this.prox = prox;
        }

        public Aresta<T> getAresta() {
            return aresta;
        }

        public void setAresta(Aresta<T> a) {
            this.aresta = a;
        }

        public NodoAresta<T> getProx() {
            return prox;
        }

        public void setProx(NodoAresta<T> prox) {
            this.prox = prox;
        }
    }
}
