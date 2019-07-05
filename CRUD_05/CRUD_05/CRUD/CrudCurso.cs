using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CRUD_05.BLL.System;
using CRUD_05.CRUD.System;
using CRUD_05.MODEL.System;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CRUD_05.CRUD.System {
    class CrudCurso :  ConexaoBD{
        MySqlCommand comando = null;

        public void CadastrarCurso(Curso curso) {
            try {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO bd_trabalhofinal.curso(nome_disciplina) VALUES(@nome)", conectarBD);
                comando.Parameters.AddWithValue("@nome", curso.Nome_disc);
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
        //        comando = new MySqlCommand("INSERT INTO bd_trabalhofinal.curso(nome_disciplina) VALUES(@nome)", conectarBD);
        //        comando.Parameters.AddWithValue("@nome", curso.Nome_disc.ToString().ToUpper());
        //       // comando.Parameters.AddWithValue("@idcurso", curso.Id_curso);


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
                comando = new MySqlCommand("SELECT curso.idcurso, curso.nome_disciplina FROM curso ORDER BY idcurso", conectarBD);
                /// variável da que recebe os dados do banco de ados.
               // comando.Parameters.AddWithValue("@idcurso", cur)
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = comando;
                da.Fill(dt);

                return dt;

            }
            catch (Exception ex) {

               throw new Exception("Erro: " + ex.Message);
            }
        }

        public void Editar(Curso curso) {
            try {
                AbrirConexao();
                comando = new MySqlCommand("UPDATE curso SET nome_disciplina=@disciplina WHERE idcurso = @idcurso", conectarBD);
                comando.Parameters.AddWithValue("@disciplina", curso.Nome_disc.ToString().ToUpper());
                comando.Parameters.AddWithValue("@idcurso", curso.Id_curso);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally {
                FecharConexao();
            }
        }

        public void Excluir(Curso curso) {
            try {
                AbrirConexao();
                comando = new MySqlCommand("DELETE FROM curso WHERE idcurso = @idcurso", conectarBD);
                comando.Parameters.AddWithValue("@idcurso", curso.Id_curso);
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
