using System;
using System.Collections.Generic;
using System.Text;

namespace POO_03_Enuns.Entidades.System {
    class Produto {
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
        public Produto() { }

        public string Nome { get; set; }
        public double Preco { get; set; }

    
    }
}
