using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_02.Dados.System {
    class GrupoTCC {
        public GrupoTCC(int idCurso) {
            IdCurso = idCurso;
            
        }
        public GrupoTCC() { }
        public int IdCurso { get; set; }
        public List<Aluno> alunos { get; set; } = new List<Aluno>();
        public List<Professor> Professores { get; set; } = new List<Professor>();
        public List<string> AreaPesquisa { get; set; } = new List<string>();
        public List<Curso> Cursos { get; set; } = new List<Curso>();


        public void AddAreaPesquisa(string area) {
            AreaPesquisa.Add(area);
        }

        public void AddProfessor(Professor professor) {
            Professores.Add(professor);
        }

        public void AddAluno(Aluno a) {
            alunos.Add(a);
        }
        
        public void AddCurso(Curso a) {
            Cursos.Add(a);
        }

    }
}
