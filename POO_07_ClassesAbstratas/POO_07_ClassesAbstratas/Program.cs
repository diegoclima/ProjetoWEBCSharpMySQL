using System;
using POO_04_Heranca.Entidades.System;

namespace POO_07_ClassesAbstratas {
    class Program {
        static void Main(string[] args) {
            Conta acc = new Conta(1001, "Alex", 0.0);
            ContaPessoaJuridica pj = new ContaPessoaJuridica(1002, "CB", 0.0, 1000);

            acc.Deposito(1000);
            //upcasting - conversao da superClasse; 
            Conta acc1 = pj;
            ContaPoupanca cpj = new ContaPoupanca(1003, "Alex", 0.0, 1.50);
            pj.Deposito(1000);
            cpj.Deposito(1000);
            cpj.AtualizaSaldo();
            cpj.Saque(1102);
            Console.WriteLine(pj);
            Console.WriteLine(cpj);
            Console.ReadKey();
        }
    }
}
