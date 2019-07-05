using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_05.MODEL.System {
    public class Aluno: Pessoa {
        /// <summary>
        /// alunos: DIEGO CRISTOPHER MARTINS DE LIMA - MATRICULA: 610009
        ///         VINICIOS AUGUSTO TORRES SANTOS - MATRICULA: 603435
        ///         RONILSON DE ASSIS OLIVEIRA - MATRICULA: 562782.
        /// </summary>

        //public List<Curso> Cursos { get; set; } = new List<Curso>();
        //public GrupoTCC TCC { get; set; }
        public Aluno() { }
        //public Curso Disciplinas { get; set; }
        public Aluno (string nome) {  }
        public int Id_curso { get; set; }
        public int Matricula { get; set; }
        public Aluno(string nome, int matricula):base(matricula, nome) {
            Nome = nome;
            Matricula = matricula;
        }




        //public Aluno(int matricula, string nome):base(matricula, nome) {
        //    TCC = new GrupoTCC();

        //}

        //public void AddCurso(Curso disciplinas) {
        //    if (Cursos.Contains(disciplinas)) {
        //        MessageBox.Show("Aluno já cursa a Disciplina " + disciplinas.Nome);
        //    }
        //    else {
        //        Cursos.Add(disciplinas);
        //    }

        //}


    }
}
