using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_02.Dados;

namespace CRUD_02.Dados.System {
    class Professor: Pessoa {
        public List<Curso> cursos { get; set; } = new List<Curso>();
        public GrupoTCC grupoTCC { get; set; } = new GrupoTCC();
        public string areaPesquisa { get; set; }
        public List<GrupoTCC> tccs { get; set; } = new List<GrupoTCC>();
       // public List<Curso> cursos { get; set; } = new List<Curso>();
        public Professor() { }
        Professor(string nome, int matricula, string email, string areaPesquisa) : base(matricula, nome, email) {
            grupoTCC.AddAreaPesquisa(areaPesquisa);
           
        }


        public override string EnviarEmail(string mensagem) {
            return mensagem;
        }

    }
}
