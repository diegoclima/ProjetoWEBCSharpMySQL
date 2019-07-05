using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_05.CRUD.System;
using CRUD_05.MODEL.System;
using CRUD_05.BLL.System;
using System.Data;

namespace CRUD_05.BLL.System {
    class CursoBLL {

        CrudCurso crud = new CrudCurso();

        public void Salvar(Curso curso) {
            try {
                //crud.CadastrarAluno(a);
                crud.CadastrarCurso(curso);
            }
            catch (Exception ex) {

                throw ex;
            }
        }

        public DataTable Listar() {
            try {
                DataTable dt = new DataTable();
                dt = crud.Listar();
                return dt;
            }
            catch (Exception ex) {

                throw ex;
            }
        }

        public void Editar(Curso c) {
            try {
                crud.Editar(c);
            }
            catch (Exception ex) {

                throw ex;
            }
        }
    }
}

