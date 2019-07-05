using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace POO_LAMBDA.Entities.System {
    class Product {
        public int Id { get; set; }
        public string  Nome { get; set; }
        public double  Preco { get; set; }
        // associacao.
        public Categoria _Categoria { get; set; }



        public override string ToString() {
            return Id
                + ", "
                + Nome
                + ", "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _Categoria.Nome
                + ", "
                + _Categoria.Tier;
        }


    }
}
