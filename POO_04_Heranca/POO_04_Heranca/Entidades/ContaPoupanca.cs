using System;
using System.Collections.Generic;
using System.Text;

namespace POO_04_Heranca.Entidades.System {
    class ContaPoupanca : Conta {
        public double Juros { get; set; }

        public ContaPoupanca() { }
        public ContaPoupanca(int numero, string proprietario, double saldo, double juros): base(numero, proprietario, saldo) {
            Juros = juros;
        }
        public void AtualizaSaldo() {
            Saldo += Saldo * Juros;
        }

        public override void Saque(double quantia) {
            base.Saque(quantia);
            Saldo -= 2.0;
        }
    }
}
