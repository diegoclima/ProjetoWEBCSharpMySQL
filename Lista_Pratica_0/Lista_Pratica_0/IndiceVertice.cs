using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Pratica_0 {
    class IndiceVertice<T> : Vertice<T> {
        public static int indexDesc = -1;
        protected int index;
        public IndiceVertice(string nome, T elemento): base(nome, elemento, indexDesc) {

        }
        public IndiceVertice(string nome, T elemento, int index):base(nome,elemento ){
            this.index = index;
        }

        public int Index() {
            return index;
        }
    }
}
