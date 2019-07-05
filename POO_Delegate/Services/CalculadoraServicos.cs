using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Delegate.Services.System {
    /// <summary>
    /// Uso de delegate
    /// </summary>
    class CalculadoraServicos {
        /// <summary>
        /// Recebe dois numeros e retonra o maior
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Max(double x, double y) {
            return (x > y) ? x : y; 
        }
        /// <summary>
        /// Recebe dois numeros e retorna a soma
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Sum(double x, double y) {
            return x + y;
        }
        /// <summary>
        /// Quadrado recebe a mult entre dois numeros.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double Square(double x) {
            return x * x;
        }
    }
}
