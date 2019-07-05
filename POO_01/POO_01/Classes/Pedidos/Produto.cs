using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace POO_01.Classes.System {
    class Produto {
        private string nome;
        private double preco;
        private int quantidade;
        public Produto() { }
        public Produto(string nome, double preco, int quantidade) {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="quantidade"></param>
        public void AdicionarProdutos(int quantidade) {
           Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade) {
            if (quantidade > Quantidade || quantidade < 0) {
                Console.WriteLine("Quantidade Inválida");
            }
            else
                Quantidade -= quantidade;
           
        }
        /// <summary>
        /// Sobreposição: override (indica que essa operação veio de outra classe)
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return Nome + ", " + "R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
