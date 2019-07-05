using System;
using POO_LAMBDA.Entities.System;
using System.Collections.Generic;
using System.Linq;
namespace POO_LAMBDA {
    class Program {
        static void Print<T>(string messagem, IEnumerable<T> colecao) {
            Console.WriteLine(messagem);
            foreach(T obj in colecao) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args) {
            Categoria c1 = new Categoria() { Id = 1, Nome = "Ferramentas ", Tier = 2 };
            Categoria c2 = new Categoria() { Id = 2, Nome = "Computador ", Tier = 1 };
            Categoria c3 = new Categoria() { Id = 3, Nome = "Eletrônicos ", Tier = 1 };
            List<Product> produtos = new List<Product>() {
                new Product(){Id = 1, Nome = "Computador", Preco = 1100.0, _Categoria = c2},
                 new Product(){Id = 2, Nome = "Hammer", Preco = 90.0, _Categoria = c1},
                  new Product(){Id = 3, Nome = "TV", Preco = 1700.0, _Categoria = c3},
                   new Product(){Id = 4, Nome = "NoteBook", Preco = 1300.0, _Categoria = c2},
                    new Product(){Id = 5, Nome = "Saw", Preco = 80.0, _Categoria = c1},
                     new Product(){Id = 6, Nome = "Tablet", Preco = 700.0, _Categoria = c2},
                      new Product(){Id = 7, Nome = "Camera", Preco = 700.0, _Categoria = c3},
                       new Product(){Id = 8, Nome = "Impressora", Preco = 350.0, _Categoria = c3},
                        new Product(){Id = 9, Nome = "MacBook", Preco = 1800.0, _Categoria = c2},
                         new Product(){Id = 10, Nome = "Sound Bar", Preco = 700.0, _Categoria = c3},
                          new Product(){Id = 11, Nome = "Level", Preco = 70.0, _Categoria = c1}
            };
            //var r1 = produtos.Where(p => p._Categoria.Tier == 1 && p.Preco < 900.00);
            //Print("TIER 1 E PRECO < 900", r1);
            //// DATA SOURCE produtos.. filtrar usa where e um predicado
            var r1 =
                from p in produtos
                where p._Categoria.Tier == 1 && p.Preco < 900
                select p;
            Print("TIER 1 E PRECO < 900", r1);

            //  var r2 = produtos.Where(p => p._Categoria.Nome == "Ferramentas ").Select(p => p.Nome);
            var r2 =
                  from p in produtos
                  where p._Categoria.Nome == "Ferramentas "
                  select p.Nome;
            Print("Nome dos produtos da FROM ferramentas", r2);

            // var r3 = produtos.Where(p => p.Nome[0] == 'C').Select(p => new { p.Nome, p.Preco, CategoriaNome = p._Categoria.Nome });
            var r3 =
                from p in produtos
                where p.Nome[0] == 'C'
                select new {
                    p.Nome,
                    p.Preco,
                    CategoriaNome = p._Categoria.Nome
                };

            Print("Produtos que começam com C ", r3);

            // var r4 = produtos.Where(p => p._Categoria.Tier == 1).OrderBy(p => p.Preco).ThenBy(p => p.Nome);
            var r4 =
                from p in produtos
                where p._Categoria.Tier == 1
                orderby p.Nome
                orderby p.Preco
                select p;

            Print("Ordenador por preco ", r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 =
                (from p in r4
                 select p).Skip(2).Take(4);


            Print("Ordenador por preco ", r5);
            var r6 = produtos.First();
            Console.WriteLine("Primeiro produto" + r6);
            //var r7 = produtos.Where(p => p.Preco > 3000).FirstOrDefault();

            //var r7 =
            //    (from p in produtos
            //     where p.Preco > 3000
            //     )

            Console.WriteLine("Primeiro" + r7);
            Console.ReadKey();
                               
        }
   }
    
    
}
