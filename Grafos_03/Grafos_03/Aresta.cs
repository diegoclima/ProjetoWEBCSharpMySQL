using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_03 {
    public class Aresta {
        private int peso;
        private Vertice v_incial;
        private Vertice v_final;
        private int direcao;

        public Aresta(Vertice v_incial, Vertice v_final, int peso) {
            this.Peso = peso;
            this.V_incial = v_incial;
            this.V_final = v_final;
            //this.direcao = direcao;
        }

        public int Peso { get => peso; set => peso = value; }
        public Vertice V_incial { get => v_incial; set => v_incial = value; }
        public Vertice V_final { get => v_final; set => v_final = value; }
        public int Direcao { get => direcao; set => direcao = value; }

        public Aresta(Vertice v1, Vertice v2, int peso, int dir) {
            this.Peso = peso;
            this.V_incial = v_incial;
            this.V_final = v_final;
            this.Direcao = direcao;
        }
    }
}
