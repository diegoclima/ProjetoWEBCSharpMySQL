using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_02.Dados.System {
    class Aluno : Pessoa {
        public List<GrupoTCC> Tcc { get; set; } = new List<GrupoTCC>();
        public Curso Curso { get; set; } = new Curso();
        public GrupoTCC tCC { get; set; }
        public Aluno() { }

        public Aluno(int matricula, string nome, string email, Curso curso, GrupoTCC tcc) : base(matricula,nome,email) {
            Curso = curso;
            tcc = new GrupoTCC();


        }

        public override string EnviarEmail(string mensagem) {
            return mensagem;
        }
        
       



    }
}
