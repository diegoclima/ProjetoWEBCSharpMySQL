using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_02.Dados.System {
    class Curso {
        public List<Aluno> alunos { get; set; } = new List<Aluno>();
        public List<Professor> professor { get; set; } = new List<Professor>();
        public List<GrupoTCC> grupoTCC { get; set; } = new List<GrupoTCC>();

        public string NomeCurso { get; set; }
        public int Id_curso { get; set; }

        public void addProfessor(Professor p) {
            if (professor.Contains(p)) {
                MessageBox.Show("Professor "+ p.Nome + " já cadastrado!");
            }
            else {
                professor.Add(p);
                MessageBox.Show("Professor: " + p.Nome + " cadastrado com sucesso!");
            }
        }
        public void addAluno(Aluno a) {
            if (alunos.Contains(a)) {
                MessageBox.Show("Aluno " + a.Nome + " já cadastrado!");
            }
            else {
                alunos.Add(a);
                MessageBox.Show("Aluno: " + a.Nome + " cadastrado com sucesso!");
            }
        }

        public void AddGrupoTCC(GrupoTCC tcc) {
            if (grupoTCC.Contains(tcc)) {
                MessageBox.Show("Grupo " + tcc.AreaPesquisa + " já cadastrada!");
               
            }
            else {
              grupoTCC.Add(tcc);
                MessageBox.Show("Grupo cadastrado com Sucesso!!");

            }
           

        }

    }
}
