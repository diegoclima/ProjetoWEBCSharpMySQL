using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_04.MODEL;
using CRUD_04.DAO.System;
using System.Data;

namespace CRUD_04.BLL.System {
    class PessoaBLL {
        PessoaDAO pessoaDao = new PessoaDAO();
        /// <summary>
        /// Método para salvar
        /// </summary>
        /// <param name="pessoa"></param>
        public void Salvar(Pessoa pessoa) {
            try {
                pessoaDao.Salvar(pessoa);

            }
            catch (Exception ex) {

                throw ex;
            }
        }

        public DataTable Listar() {
            try {
                DataTable dt = new DataTable();
                dt = pessoaDao.Listar();
                return dt;
            }
            catch (Exception ex) {

                throw;
            }
            finally {
                
            }
        }
        /// <summary>
        /// Método para editar os dados da pessoa
        /// </summary>
        public void Editar(Pessoa pessoa) {
            try {
                pessoaDao.Editar(pessoa);
            }
            catch (Exception erro) {

                throw erro;
            }
        }
        /// <summary>
        /// Excluir pessoa
        /// </summary>
        //public void Excluir(Pessoa pessoa) {
        //    try {
                
        //        pessoaDao.Excluir(pessoa);
        //    }
        //    catch (Exception ex) {

        //        throw ex;
        //    }
        //}

        public void Excluir(Pessoa pessoa) {
            try {
                pessoaDao.Excluir(pessoa);
            }
            catch (Exception erro) {

                throw erro;
            }
        }
    }
}
