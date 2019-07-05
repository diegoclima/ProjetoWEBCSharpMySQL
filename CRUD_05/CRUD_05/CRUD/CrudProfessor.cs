using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CRUD_05.BLL.System;
using CRUD_05.CRUD.System;
using CRUD_05.MODEL.System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CRUD_05.CRUD.System {
    class CrudProfessor : ConexaoBD {
        MySqlCommand comando = null;
        //MySqlCommand comando2 = null;

        public void CadastrarProfessor(Professor prof) {
            try {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO bd_trabalhofinal.professor(nome_professor,idcurso) VALUES (@nome, @idcurso)", conectarBD);
                // "INSERT INTO bd_trabalhofinal.curso(nome_disciplina) VALUES(@nome_disc)
                comando.Parameters.AddWithValue("@nome", prof.Nome.ToString().ToUpper());
                comando.Parameters.AddWithValue("@idcurso", prof.Id_curso);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex) {

               MessageBox.Show("Erro: " + ex.Message);
            }
            finally {
                FecharConexao();
            }
        }

        public void CadastrarCurso(Curso curso) {
            try {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO bd_trabalhofinal.curso(nome_disciplina) VALUES(@nome_disc)", conectarBD);
                comando.Parameters.AddWithValue("@nome_disc", curso.Nome_disc.ToString().ToUpper());
                comando.ExecuteNonQuery();

            }
            catch (Exception ex) {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally {
                FecharConexao();
            }
        }

        public DataTable Listar() {
            try {
                AbrirConexao();
                DataTable dt = new DataTable();
                comando = new MySqlCommand("SELECT professor.matricula, professor.nome_professor, curso.nome_disciplina FROM professor inner join curso WHERE professor.idcurso = curso.idcurso ORDER BY matricula", conectarBD);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex) {

               throw new Exception("Erro: " + ex.Message);
            }
            finally {
                FecharConexao();
            }
        }

        public void Editar(Professor prof) {
            try {
                AbrirConexao();
                comando = new MySqlCommand("UPDATE professor SET nome_professor=@nome WHERE matricula = @idpessoa", conectarBD);
                comando.Parameters.AddWithValue("nome", prof.Nome.ToString().ToUpper());
                comando.Parameters.AddWithValue("idpessoa", prof.Matricula);
                comando.ExecuteNonQuery();

            }
            catch (Exception ex) {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally {
                FecharConexao();
            }
        }

        public void Excluir(Professor prof) {
            try {
                AbrirConexao();
                comando = new MySqlCommand("DELETE FROM professor WHERE matricula = @matricula", conectarBD);
                comando.Parameters.AddWithValue("@matricula", prof.Matricula);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally {
                FecharConexao();
            }
        }
    }
}
