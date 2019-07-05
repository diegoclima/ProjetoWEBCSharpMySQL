using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CRUD_02.Dados.System {
    class ConectarBanco {
        public string ConectaBD { get; set; }
        public MySqlCommand comando { get; set; } = new MySqlCommand();
        public MySqlConnection conexao { get; set; } = new MySqlConnection();
        public ConectarBanco() {
            ConectaBD = "SERVER = localhost; DATABASE = bd_crud; UID = root; PWD = Mxw34379@";
            conexao = null;
            comando = null;
        }

        public void AbrirConexao() {
            try {
                conexao = new MySqlConnection(ConectaBD);
                conexao.Open();
            }
            catch (Exception erro) {

                throw erro;
            }
        }

        public void FecharConexao() {
            try {
                conexao = new MySqlConnection(ConectaBD);
                conexao.Close();
            }
            catch (Exception erro) {

                throw erro;
            }
        }

    }
}
