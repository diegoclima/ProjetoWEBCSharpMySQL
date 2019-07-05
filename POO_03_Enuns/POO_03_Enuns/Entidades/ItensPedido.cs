using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace POO_03_Enuns.Entidades.System {
    class ItensPedido {
        public ItensPedido(int quantidade, double preco) {
            Quantidade = quantidade;
            Preco = preco;
        }

        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produtos { get; set; } = new Produto();

        public double SubTotal() {
           return Quantidade * Preco;
        }
        
        
        public override string ToString() {
            return Produtos.Nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + Quantidade
                + ", SubTotal: R$ "
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
                

        }
    }
}
