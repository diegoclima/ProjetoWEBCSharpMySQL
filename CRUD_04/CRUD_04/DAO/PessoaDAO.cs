using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_04.MODEL;
using MySql.Data.MySqlClient;
using CRUD_04.DAO;
using System.Data;


namespace CRUD_04.DAO.System {
    /// <summary>
    /// Classe que vai buscar no Banco os dados.
    /// </summary>
    public class PessoaDAO : Conexao {
        MySqlCommand comando = null;
        /// <summary>
        /// Salvar os dados de uma pessoa;
        /// </summary>
        public void Salvar(Pessoa pessoa) {
            try {
                AbrirConexao();
                // comando para inserir
                comando = new MySqlCommand("INSERT INTO pessoa (nome, telefone, celular, bairro, cidade, uf, sexo, endereco) VALUES(@nome, @tel, @cel, @bairro, @cidade, @uf, @sexo, @end)", conectar);
                comando.Parameters.AddWithValue("@nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@tel", pessoa.Telefone);
                comando.Parameters.AddWithValue("@cel", pessoa.Celular);
                comando.Parameters.AddWithValue("@bairro", pessoa.Bairro);
                comando.Parameters.AddWithValue("@cidade", pessoa.Cidade);
                comando.Parameters.AddWithValue("@uf", pessoa.UF);
                comando.Parameters.AddWithValue("@sexo", pessoa.Sexo);
                comando.Parameters.AddWithValue("@end", pessoa.Endereco);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) {

                throw ex;
            }
           
        }

        /// <summary>
        /// Listar os dados
        /// </summary>
        /// <returns></returns>
        public DataTable Listar() {
            try {
                AbrirConexao();
                DataTable dt = new DataTable();
                comando = new MySqlCommand("SELECT * FROM pessoa ORDER BY id", conectar);
                
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = comando;
                da.Fill(dt);
                return dt;
            }
            catch (Exception erro) {

                throw erro;
            }
        }
        /// <summary>
        /// Editar dados da pessoa.
        /// </summary>
        public void Editar(Pessoa pessoa) {
            try {
                AbrirConexao();
                // comando para inserir
                comando = new MySqlCommand("UPDATE pessoa SET nome =@nome, telefone=@tel, celular=@cel, bairro=@bairro, cidade=@cidade, uf=@uf, sexo=@sexo, endereco=@end WHERE(id = @idpessoa)", conectar);
                comando.Parameters.AddWithValue("@idpessoa", pessoa.Id);
                comando.Parameters.AddWithValue("@nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@tel", pessoa.Telefone);
                comando.Parameters.AddWithValue("@cel", pessoa.Celular);
                comando.Parameters.AddWithValue("@bairro", pessoa.Bairro);
                comando.Parameters.AddWithValue("@cidade", pessoa.Cidade);
                comando.Parameters.AddWithValue("@uf", pessoa.UF);
                comando.Parameters.AddWithValue("@sexo", pessoa.Sexo);
                comando.Parameters.AddWithValue("@end", pessoa.Endereco);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex) {

                throw ex;
            }
            finally {
                FecharConexao();
            }
        }
        //public void Excluir(Pessoa pessoa) {
        //    try {
        //        AbrirConexao();
        //        comando = new MySqlCommand("DELETE FROM pessoa WHERE id= @idpessoa)", conectar);
        //        comando.Parameters.AddWithValue("@idpessoa", pessoa.Id);
        //        comando.ExecuteNonQuery();

        //    }
        //    catch (Exception ex) {

        //        throw ex;
        //    }
        //    finally {
        //        FecharConexao();
        //    }

        //}

        public void Excluir(Pessoa pessoa) {
            try {
                AbrirConexao();
                comando = new MySqlCommand("DELETE FROM pessoa WHERE id = @id", conectar);
                comando.Parameters.AddWithValue("@id", pessoa.Id);
                comando.ExecuteNonQuery();

            }
            catch (Exception erro) {

                throw erro;
            }
            finally {
                FecharConexao();
            }
        }




    }
}
