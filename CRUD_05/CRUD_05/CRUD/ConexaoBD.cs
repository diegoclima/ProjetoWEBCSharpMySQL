using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace CRUD_05.CRUD.System {
    public class ConexaoBD {
        string strConectarBD = "DATABASE=bd_trabalhofinal; SERVER=localhost; UID=root; PWD=Mxw34379@";
        public MySqlConnection conectarBD { get; set; }
        public ConexaoBD() { }
        public void AbrirConexao() {
            try {
                conectarBD = new MySqlConnection(strConectarBD);
                conectarBD.Open();
            }
            catch (Exception ex) {

                MessageBox.Show("Erro: " + ex.Message);
            }

        }
        public void FecharConexao() {
            try {
                conectarBD = new MySqlConnection(strConectarBD);
                conectarBD.Close();
            }
            catch (Exception ex) {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

    }
}
