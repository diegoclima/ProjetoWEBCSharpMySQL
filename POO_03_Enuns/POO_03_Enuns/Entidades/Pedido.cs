using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace POO_03_Enuns.Entidades.System {
    class Pedido {
        public Pedido(DateTime date, StatusPedido status, Cliente c) {
            this.Momento = date;
            Status = status;
            cliente = c;
        }
        
        public Pedido() { }
        public List<ItensPedido> Itens { get; set; } = new List<ItensPedido>();
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }
        public List<Cliente> Clientes { get; set; }
        public Cliente cliente { get; set; }

        public void AddItem(ItensPedido itens) {
            Itens.Add(itens);
        }
        public void RemoverItensPedido(ItensPedido itens) {
            Itens.Remove(itens);
        }

        public double Total() {
            double soma = 0;
            foreach (ItensPedido item in Itens) {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Pedido momento: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do Pedido: " + Status);
            sb.AppendLine("Cliente: " + cliente.Nome);
            sb.AppendLine("Itens do Pedido: ");
            foreach(ItensPedido item in Itens) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Valor total: R$ " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
