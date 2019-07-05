using System;
using System.Collections.Generic;
using System.Text;

namespace POO_01.Classes.System {
    class Calculadora {
        public static double pi;
        public Calculadora() {
            Pi = 3.14;
            
        }

        public static double Pi { get => pi; set => pi = value; }

        public static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r) {
            return 4 / 3 * Pi * r * r * r;
        }

       
    }
}
