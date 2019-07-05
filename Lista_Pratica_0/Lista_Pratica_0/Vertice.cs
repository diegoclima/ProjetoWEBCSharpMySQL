using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Pratica_0 {
    public class Vertice<T> {
        protected string nome;
        protected T elemento;

        public Vertice(string nome, T elemeno) {
            this.nome = nome;
            this.elemento = elemeno;
        }
        public Vertice(string nome, T elemento, int elem) {
            this.nome = nome;
            this.elemento = elemento;
        }
        public string getNome() {
            return nome;
        }
        public void setNome(string n) {
            this.nome = n;
        }
        public T getElemento() {
            return elemento;
        }
        public void setElemento(T elemento) {
            this.elemento = elemento;
        }
        public override string ToString() {
            return nome;
        }
    }
}
