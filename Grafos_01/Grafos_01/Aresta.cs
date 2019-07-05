using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_01 {
    class Aresta<T> {
        private Vertice<T> v1;
        private Vertice<T> v2;

        public Aresta(Vertice<T> v1, Vertice<T> v2) {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Vertice<T> V1 { get => v1; set => v1 = value; }
        public Vertice<T> V2 { get => v2; set => v2 = value; }
    }
}
