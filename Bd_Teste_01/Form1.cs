using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;



namespace Bd_Teste_01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            CarregarGrid();
        }
      
        private void CarregarGrid() {
            try {
                using (var comn = AbrirConxexao()) {
                    comn.Open();
                    using (var comm = comn.CreateCommand()) {
                        
                        comm.CommandText = "SELECT ID; NomeArquivo FROM Arquivos ";
                        var reader = comm.ExecuteReader();
                        var table = new DataTable();
                        table.Load(reader);
                        dataGridView1.DataSource = table;
                            
                    }
                }
                    
            } catch (Exception erro) {
               
                    MessageBox.Show("Erro:  " + erro);
            }
        }

        MySqlConnection conexao = null;
        MySqlCommand comando = null;
        string conecta = "DATABASE= teste; SERVER = localhost; UID=root; PWID = mxw34379 ";

        public IDbConnection AbrirConxexao() {
           
            return new MySqlConnection(conecta);            
        }

        public IDbConnection Fechar_Conexao() {
            try {
                conexao = new MySqlConnection(conecta);
                conexao.Close();
            } catch (Exception erro) {

                MessageBox.Show("Erro: " + erro);
            }

            return conexao;
        }


    }
}
