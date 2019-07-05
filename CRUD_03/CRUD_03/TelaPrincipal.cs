using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_03.View;
using CRUD_03.Classes;
using CRUD_03.DAO;


namespace CRUD_03 {
    public partial class TelaPrincipal : Form {
        public TelaPrincipal() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void buttCliente_Click(object sender, EventArgs e) {
            FrmClientes form = new FrmClientes();
            form.Show();
        }
    }
}
