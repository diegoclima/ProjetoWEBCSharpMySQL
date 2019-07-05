using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using CRUD_05.MODEL.System;
using CRUD_05.BLL.System;
using System.Windows.Forms;

namespace CRUD_05.CRUD.System {
    public class Crud : ConexaoBD {
        MySqlCommand comando = null;
        //MySqlCommand comando2 = null;

        public void CadastrarAluno(Aluno aluno) {
            try {
                AbrirConexao();

                comando = new MySqlCommand("INSERT INTO bd_trabalhofinal.aluno(nome, curso_id) VALUES (@nome, @idcurso)", conectarBD);
                // "INSERT INTO bd_trabalhofinal.curso(nome_disciplina) VALUES(@nome_disc)
                comando.Parameters.AddWithValue("@nome", aluno.Nome.ToString().ToUpper());
                comando.Parameters.AddWithValue("@idcurso", aluno.Id_curso);

                comando.ExecuteNonQuery();
            }
            catch (Exception ex) {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally {
                FecharConexao();
            }
        }

        //public void CadastrarCurso(Curso curso) {
        //    try {
        //        AbrirConexao();
        //        comando = new MySqlCommand("INSERT INTO bd_trabalhofinal.curso(nome_disciplina) VALUES(@nome_disc)", conectarBD);
        //        comando.Parameters.AddWithValue("@nome_disc", curso.Nome_disc.ToString().ToUpper());
        //        comando.ExecuteNonQuery();

        //    }
        //    catch (Exception ex) {

        //        throw ex;
        //    }
        //    finally {
        //        FecharConexao();
        //    }
        //}

        public DataTable Listar() {
            try {
                AbrirConexao();
                DataTable dt = new DataTable();
                comando = new MySqlCommand("SELECT aluno.matricula ,aluno.nome, curso.nome_disciplina FROM aluno inner join curso WHERE aluno.curso_id = curso.idcurso ORDER BY matricula", conectarBD);
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
        
        public void Editar(Aluno aluno) {
            try {
                AbrirConexao();
                comando = new MySqlCommand("UPDATE aluno SET nome=@nome WHERE matricula = @idpessoa", conectarBD);
                comando.Parameters.AddWithValue("nome", aluno.Nome.ToString().ToUpper());
                comando.Parameters.AddWithValue("idpessoa", aluno.Matricula);
                comando.ExecuteNonQuery();

            }
            catch (Exception ex) {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally {
                FecharConexao();
            }
        }

        public void Excluir(Aluno aluno) {
            try {
                AbrirConexao();
                comando = new MySqlCommand("DELETE FROM aluno WHERE matricula = @matricula", conectarBD);
                comando.Parameters.AddWithValue("@matricula", aluno.Matricula);
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
