using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafos_testes {
     class Grafo {
        protected List<Aresta> vertices = new List<Aresta>();
        protected int total_verticesGrafo = 0;
        public Grafo() { }

        //public Grafo(List<Aresta> vertices, int total_verticesGrafo) {
        //    this.vertices = vertices;
        //    this.total_verticesGrafo = total_verticesGrafo;
        //}

        public override string ToString() {
            string retorno = " ";
            foreach (Aresta item in this.vertices) {
                retorno += "| " + item.Ini_vertice.Nome + " -> " + (item.Fim_vertice == null ? "" : item.Fim_vertice.Nome);
            }
            return retorno;
        }


        public virtual string Set_Resp(string resp) {
            return resp;
        }
    }
}
