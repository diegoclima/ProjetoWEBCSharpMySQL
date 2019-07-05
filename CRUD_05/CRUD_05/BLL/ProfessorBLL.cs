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
    class ProfessorBLL {
        CrudProfessor crud_prof = new CrudProfessor();
        CrudCurso crudcurso = new CrudCurso();

        public void Salvar(Professor prof, Curso curso) {
            try {
                crud_prof.CadastrarProfessor(prof);
                crudcurso.CadastrarCurso(curso);
               crud_prof.CadastrarCurso(curso);
            }
            catch (Exception ex) {

                throw ex;
            }
        }

        public DataTable Listar() {
            try {
                DataTable dt = new DataTable();
                dt = crud_prof.Listar();
                return dt;
            }
            catch (Exception ex) {

                throw ex;
            }
        }

        public void Editar(Professor prof) {
            try {
                crud_prof.Editar(prof);
            }
            catch (Exception ex) {

                throw ex;
            }
        }
    }
}

