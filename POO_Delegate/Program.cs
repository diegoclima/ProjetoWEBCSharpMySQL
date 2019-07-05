using POO_Delegate.Services.System;
using System;
using System.Linq;

namespace POO_Delegate {
    /// <summary>
    /// Especifica que será uma função que recebe dois números
    /// e retorna um double. 
    /// </summary>
    /// <param name="n1"></param>
    /// <param name="n2"></param>
    /// <returns></returns>
    delegate double OpBinNumerica(double n1, double n2);

    class Program {
        static void Main(string[] args) {
            //double a = 10;
            //double b = 12;
            ////op é referencia para o obj calculadora.
            //// Só funciona com as funções que casam com a assintura.
            //OpBinNumerica op = CalculadoraServicos.Sum;
            //// double result = CalculadoraServicos.Sum(a, b);

            string strNormal = "", strInvertido = "";

            int[] vet = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,32,44,56,76,78,99,232,435,6778,494994 };

            for (int i = 0; i < vet.Length; i++) {
                strNormal += vet[i] + ",";
            }
            Console.WriteLine(strNormal);
            int[] vetInvertido = new int[vet.Length];
            for (int i = 0; i < vet.Length; i++) {

                //Subtrai 1 pois os índices começam com 0.
                vetInvertido[i] = vet[vet.Length - 1 - i];
            }
            // guardar no vetorinvertido na string
            for (int i = 0; i < vetInvertido.Length; i++) {
                strInvertido += vetInvertido[i] + ",";
                Console.WriteLine(strInvertido);
            }

            
            Console.WriteLine(strInvertido);
            Console.ReadKey();
        }
    }
}
