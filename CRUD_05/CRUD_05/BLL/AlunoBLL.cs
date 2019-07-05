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
    /// <summary>
    /// Classe que o crud usa para editar e salvar dados dos alunos.
    /// </summary>
    public class AlunoBLL {
        Crud crud = new Crud();

        public void Salvar(Aluno a) {
            try {
                crud.CadastrarAluno(a);
               // crud.CadastrarCurso(curso);
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

        public void Editar(Aluno aluno) {
            try {
                crud.Editar(aluno);
            }
            catch (Exception ex) {

                throw ex;
            }
        }
    }
}
