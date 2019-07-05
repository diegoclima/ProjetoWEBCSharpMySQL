using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Pratica_0 {
    class Peso_Aresta<T>:Aresta<T> {
        protected int peso;
        public Peso_Aresta(Vertice<T> u, Vertice<T> v, int peso): 
            base(u,v){
            this.peso = peso;
        }

        public int getPeso() {
            return peso;
        }
        public void setPeso(int peso) {
            this.peso = peso;
        }
    }
}
