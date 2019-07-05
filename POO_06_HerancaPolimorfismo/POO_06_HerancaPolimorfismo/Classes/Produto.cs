using System;
using System.Collections.Generic;
using System.Text;
using POO_06_HerancaPolimorfismo.Classes;

namespace POO_06_HerancaPolimorfismo.Classes.System {
    class Produto {
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
        public Produto() { }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public virtual string EtiquetaDePreco() {

        }

    }
}
