using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_05.CRUD;
using CRUD_05.MODEL;
using System.Windows.Forms;

namespace CRUD_05.MODEL.System {
   public class Curso {
        public int Id_curso { get; set; }
        //public List<Aluno> Alunos { get; set; } = new List<Aluno>();
        //public List<Orientador> Orientadores { get; set; } = new List<Orientador>();
        //public List<GrupoTCC> Curso_TCC { get; set; } = new List<GrupoTCC>();
        //public List<string> Disciplinas { get; set; } = new List<string>();
        public string Nome_disc { get; set; }

        public Curso() {

        }
        public Curso(int id, string nome) {
            Id_curso = id;
            Nome_disc = nome;
        }

       


    }
}
