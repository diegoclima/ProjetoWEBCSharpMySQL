using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CRUD_03.DAO.System {
    /// <summary>
    /// Comunicacao Direta com BD.
    /// </summary>
    public class ClienteDAO {
        public string Conexao { get; set; }
        public MySqlConnection con { get; set; }
        public MySqlCommand sql { get; set; }
        public ClienteDAO() {

            Conexao = "SERVER=localhost; DATABASE= sistemaclientes; UID=root; PWD= Mxw34379@ ";
            con = null;
            sql = null;

        }
        /// <summary>
        /// Busca dados, pega os dados da tabela e lista no gridView
        /// </summary>
        /// <returns></returns>
        public DataTable Listar() {
            try {
                // instancia e passa a string de conexao. Que estão armazanados os dados
                con = new MySqlConnection(Conexao);
                sql = new MySqlCommand("SELECT * FROM cliente", con);
                // recebe os dados e joga no grid.
                MySqlDataAdapter da = new MySqlDataAdapter();
                // seleciona um comando.
                da.SelectCommand = sql;
                // deve ser relacionado a alguma tabela e mostra em algum local. 
                DataTable dt = new DataTable();
                // inserece na execucao do comando.DataTable será preenchido por um adapter. Vai inserir no GRid
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex) {

                throw ex;
            }
        }



    }
}
