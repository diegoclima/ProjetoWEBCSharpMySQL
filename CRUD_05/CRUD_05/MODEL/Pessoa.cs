using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_05.MODEL.System {
   public abstract class Pessoa {
        public int Matricula { get; private set; }
        public string Nome { get; set; }
       public Pessoa() { }
        public Pessoa(int matricula, string nome) {
            Matricula = matricula;
            Nome = nome;
        }
    }
}
