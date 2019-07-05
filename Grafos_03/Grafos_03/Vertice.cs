using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_03 {
   public class Vertice {
        private string nome;
        private List<Aresta> adjacentes;
        public Vertice() {
            adjacentes = new List<Aresta>();
        }

        public Vertice(string n) {
            this.nome = n;
            this.Adjacentes = new List<Aresta>();
        }

        public string Nome { get => nome; set => nome = value; }
        public List<Aresta> Adjacentes { get => adjacentes; set => adjacentes = value; }
    }
}
