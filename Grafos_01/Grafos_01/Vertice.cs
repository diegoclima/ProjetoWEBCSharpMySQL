using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_01 {
    public class Vertice<T> {
        private T dado;
        private List<Vertice<T>> vizitados;

        public Vertice(T dado, List<Vertice<T>> vizitados) {
            this.dado = dado;
            this.vizitados = vizitados;
        }

        public T Dado { get => dado; set => dado = value; }
        public List<Vertice<T>> Vizitados { get => vizitados; set => vizitados = value; }
    }
}
