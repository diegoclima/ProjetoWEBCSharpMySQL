using System;
using System.Collections.Generic;
using System.Text;

namespace POO_04_Heranca.Entidades.System {
    /// <summary>
    /// 
    /// </summary>
    class Conta {
        public Conta(int numero, string proprietario, double saldo) {
            Numero = numero;
            Proprietario = proprietario;
            Saldo = saldo;
        }
        public Conta() { }
        public int Numero { get; private set; }
        public string Proprietario { get; private set; }
        public double  Saldo { get; protected set; }

        public virtual void Saque(double quantia) {
            if (quantia > Saldo) {
                Console.WriteLine("Valor Insuficiente");
            }
            else {
                Saldo -= (quantia + 5.00);
            }
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Proprietario);
            sb.AppendLine("Número da Conta: " + Numero);
            sb.AppendLine("Saldo da Conta: " + Saldo);
            return sb.ToString();
        }

    }
}
