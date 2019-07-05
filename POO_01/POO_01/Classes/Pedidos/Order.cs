using System;
using System.Collections.Generic;
using System.Text;
using POO_01.Classes.System;

namespace POO_01.Classes.System {
    class Order {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString() {
            return Id + ", "
                + Moment + ","
                + Status;
        }


    }
}
