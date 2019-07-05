using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafo_02 {
    class Vertice {
        private int id_vertice;
        private List<Vertice> vertices;

        public Vertice(int id_vertice) {
            this.id_vertice = id_vertice;
            vertices = new List<Vertice>();
        }

        public int Id_vertice { get => id_vertice; set => id_vertice = value; }
        public List<Vertice> Vertices { get => vertices; set => vertices = value; }
    }
}
