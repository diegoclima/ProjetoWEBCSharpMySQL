using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_03.DAO.System;
using System.Data;

namespace CRUD_03.MODEL.System {
    public class ClienteModel {
        public ClienteDAO DAO { get; set; }

        public ClienteModel() {
            DAO = new ClienteDAO();

        }

        public DataTable Listar() {
            try {
                DataTable dt = new DataTable();
                DAO.Listar(); // listagem dos dados.
                return dt;

            }
            catch (Exception ex) {

                throw ex;
            }
        }
    }
}
