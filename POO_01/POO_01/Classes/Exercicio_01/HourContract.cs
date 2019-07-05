using System;
using System.Collections.Generic;
using System.Text;

namespace POO_01.Classes.Exercicio_01 {
    class HourContract {
        public DateTime Date { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public HourContract() { }

        public HourContract(DateTime date, double valorPorHora, int horas) {
            this.Date = date;
            this.ValorPorHora = valorPorHora;
            this.Horas = horas;
        }

        public double ValorTotal() {
            return Horas * ValorPorHora;
        }
    }
}
