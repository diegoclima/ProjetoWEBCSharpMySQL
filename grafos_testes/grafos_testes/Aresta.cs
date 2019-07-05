using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafos_testes {
    class Aresta {
        private int peso;
        private Vertice ini_vertice;
        private Vertice fim_vertice;
        private int direcao;

        public Aresta(Vertice ini_vertice, Vertice fim_vertice, int peso) {
            this.Peso = peso;
            this.Ini_vertice = ini_vertice;
            this.Fim_vertice = fim_vertice;
           // this.direcao = direcao;
        }

        public Aresta(Vertice ini_vertice, Vertice fim_vertice,int peso, int direcao) {
            this.Peso = peso;
            this.Ini_vertice = ini_vertice;
            this.Fim_vertice = fim_vertice;
            this.Direcao = direcao;
        }

        public int Peso { get => peso; set => peso = value; }
        public int Direcao { get => direcao; set => direcao = value; }
        public Vertice Ini_vertice { get => ini_vertice; set => ini_vertice = value; }
        public Vertice Fim_vertice { get => fim_vertice; set => fim_vertice = value; }
    }
}
