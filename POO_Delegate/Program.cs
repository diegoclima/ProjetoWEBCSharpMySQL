using POO_Delegate.Services.System;
using System;

namespace POO_Delegate {
    class Program {
        static void Main(string[] args) {
            double a = 10;
            double b = 12;

            double result = CalculadoraServicos.Sum(a, b);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
