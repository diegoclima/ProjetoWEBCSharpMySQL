using System;
using System.Linq;

namespace LINQ_POO {
    class Program {
        static void Main(string[] args) {

            //Define o banco de dados
            int[] numbers = new int[] { 2, 3, 4, 5 };
            // define as expressões de consultas 
            // encontrar um numero par e mult por 10.
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);
            //executar a consulta.
            foreach(int x in result) {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
