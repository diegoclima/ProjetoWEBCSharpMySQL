using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Pratica_0 {
   public class Aresta<T> {
        protected Vertice<T> u;
        protected Vertice<T> v;

        public Aresta(Vertice<T> u, Vertice<T> v) {
            this.u = u;
            this.v = v;
        }
        public Vertice<T> GetVerticeU() {
            return u;
        }
        public void setVerticeU(Vertice<T> u) {
            this.u = u;
        }
        public Vertice<T> GetVerticeV() {
            return v;
        }

        public void setVerticeV(Vertice<T> v) {
            this.v = v;
        }

        public override string ToString() {
            return "(" + u + "," + v + ")";
        }
    }
}
