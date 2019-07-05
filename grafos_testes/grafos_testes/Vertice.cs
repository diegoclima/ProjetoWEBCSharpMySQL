using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafos_testes {
    class Vertice {
        private string nome;
        private List<Aresta> adjacentes;

        public string Nome { get => nome; set => nome = value; }
        public List<Aresta> Adjacentes { get => adjacentes; set => adjacentes = value; }

        public Vertice(string n) {
            this.Nome = n;
            this.Adjacentes = new List<Aresta>();
        }
        public Vertice() {

        }


    }
}
