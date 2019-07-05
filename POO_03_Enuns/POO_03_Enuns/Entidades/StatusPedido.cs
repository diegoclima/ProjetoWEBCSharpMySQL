using System;
using System.Collections.Generic;
using System.Text;

namespace POO_03_Enuns.Entidades.System {
    enum StatusPedido:int {
        PagamentoPendente = 0,
        Processando = 1,
        Shipped = 2,
        Entregue = 3
    }
}
