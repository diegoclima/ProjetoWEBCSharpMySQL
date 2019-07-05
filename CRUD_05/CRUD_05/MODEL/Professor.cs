using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CRUD_05.BLL.System;
using CRUD_05.CRUD.System;
using CRUD_05.MODEL.System;

namespace CRUD_05.MODEL.System {
    class Professor: Pessoa {

        public int Id_curso { get; set; }
        public string Nome { get;  set; }
        public int Matricula { get; set; }
        public Professor() { }
        public Professor(string nome, int matricula):base(matricula,nome) {


        }
    }
}
