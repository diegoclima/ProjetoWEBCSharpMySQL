using System;
using System.Collections.Generic;
using System.Text;

namespace POO_05_Polimorfismo.Classes.System {
    class EmpregadoTerceirizado : Empregado{

        public double DespesaAdicional { get; private set; }

        public EmpregadoTerceirizado() { }

        public EmpregadoTerceirizado(string n, int hr, double vlrPHor, double despAdicional): base(n,hr,vlrPHor) {
            DespesaAdicional = despAdicional;
        }

        public override double Pagamento() {
            return base.Pagamento() + 1.1 * DespesaAdicional;
        }
    }
}
