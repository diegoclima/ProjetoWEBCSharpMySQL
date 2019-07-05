using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CRUD_04.DAO.System {
   public class Conexao {
        string conecta = "DATABASE=escola; SERVER=localhost; UID=root; PWD=Mxw34379@";
       
       protected MySqlConnection conectar = null;

        public Conexao() { }
        public void AbrirConexao() {
            try {
                conectar = new MySqlConnection(conecta);
                conectar.Open();
            }
            catch ( Exception ex) {

                throw ex;
            }
        }

        public void FecharConexao() {
            try {
                conectar = new MySqlConnection(conecta);
                conectar.Close();
            }
            catch (Exception ex) {

                throw ex;
            }
        }


    }
}
