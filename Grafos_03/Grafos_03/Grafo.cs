using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_03 {
   public class Grafo {
        protected List<Aresta> vertices;
        protected int totalVerticesGrafo;

        public Grafo() {
            vertices = new List<Aresta>();
            totalVerticesGrafo = 0;
        }

        public string toString() {
            string retorno = "";
            foreach(Aresta a in vertices) {
                return retorno += "| " + a.V_incial.Nome + "-> " + (a.V_final == null ? "" : a.V_final.Nome);
            }
            return retorno;
        }

        public virtual string setResposta(string msg) {
            return msg;
        }
    }
}
