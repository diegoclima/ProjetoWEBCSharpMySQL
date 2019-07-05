using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_02.Dados {
    abstract class Pessoa {
        protected Pessoa(int matricula, string nome, string email) {
            Matricula = matricula;
            Nome = nome;
            Email = email;
        }
        public Pessoa() { }
        public List<Notas> notas { get; set; } = new List<Notas>();
        public int Matricula { get; protected set; }
        public string Nome { get; protected set; }
        public string Email { get; protected set; }

        public abstract string EnviarEmail(string mensagem);
               
       
    
         

    }
}
