using System;
using System.Collections.Generic;
using System.Text;


namespace POO_04_Heranca.Entidades.System {
    class ContaPessoaJuridica : Conta {

        public double LimiteConta { get; set; }

        public ContaPessoaJuridica() { }

        public ContaPessoaJuridica(int numero, string proprietario, double saldo, double limite) : base(numero,proprietario,saldo){
            LimiteConta = limite;
        }

        public void Emprestimo(double quantia) {
            if (quantia <= LimiteConta) {
                Saldo += quantia;
            }
            else
                Console.WriteLine("Excedeu Limite da conta");
           
        }
    }
}
