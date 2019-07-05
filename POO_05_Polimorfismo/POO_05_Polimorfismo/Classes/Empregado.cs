using System;
using System.Collections.Generic;
using System.Text;
using POO_05_Polimorfismo.Classes;

namespace POO_05_Polimorfismo.Classes.System {
    class Empregado {
        public string  Nome { get; private set; }
        public int Horas { get; private set; }
        public double ValorPorHoras { get; private set; }
       // public List<Empregado> empregados { get; set; } = new List<Empregado>();

        public Empregado() { }

        public Empregado(string nome, int horas, double valorPorHoras) {
            Nome = nome;
            Horas = horas;
            ValorPorHoras = valorPorHoras;
        }
        public virtual double Pagamento() {
            return Horas * ValorPorHoras;
        }

        //public void AddEmpregado(Empregado emp) {
        //    empregados.Add(emp);
        //}
        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nome Funcionário: " + Nome);
            sb.AppendLine("Horas Trabalhadas: " + Horas);
            sb.AppendLine("Pagamento: R$ " + Pagamento());
            return sb.ToString();

        }

    }
}
