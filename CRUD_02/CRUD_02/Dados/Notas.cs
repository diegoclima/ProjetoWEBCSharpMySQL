using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_02.Dados {
    class Notas {
        public double  Valor { get; set; }
        public string AreaPesquisa { get; set; }

        public List<Notas> notas { get; set; }

        public void CadastarNotas(Notas valor) {
            notas.Add(valor);
        }


    }
}
