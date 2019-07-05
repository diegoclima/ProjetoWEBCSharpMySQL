using System;
using POO_05_Polimorfismo.Classes;
using System.Collections.Generic;
using POO_05_Polimorfismo.Classes.System;
using System.Globalization;

namespace POO_05_Polimorfismo {
    class Program {
        /// <summary>
        /// Polimorfismo recurso que permite que variáveis de um mesmo tipo mais genérico possam apontar para 
        /// objetos de tipos específicos diferentes, com comportamentos diferentes conforme cada tipo específico.
        /// Conta c1 = new ContaPoupanca(...)
        /// Conta c2 = new Conta(...)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            List<Empregado> empregados = new List<Empregado>();

            Console.Write("Digite a quantidade de elementos: ");
            //For para leitura dos n funcionarios.
            int n = int.Parse(Console.ReadLine ());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Empregados #{i} dados: ");
                Console.Write("Terceirizado (s/n): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Valor por Hora: ");
                double vlr = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Horas Trabalhadas: ");
                int h = int.Parse(Console.ReadLine());
                if (ch == 's') {
                    Console.Write("Valor Adicional: ");
                    double addValor = double.Parse(Console.ReadLine());
                    empregados.Add(new EmpregadoTerceirizado(nome, h, vlr, addValor));
                }
                else {
                    empregados.Add(new Empregado(nome, h, vlr));
                }

            }
            Console.WriteLine("Pagamentos");
            foreach(Empregado empregado in empregados){
                Console.WriteLine(empregado.ToString());
               
            }
            Console.ReadKey();
        }
    }
}
