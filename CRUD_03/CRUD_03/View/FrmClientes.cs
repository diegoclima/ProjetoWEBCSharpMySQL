using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_03.View {
    public partial class FrmClientes : Form {
        public FrmClientes() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void FrmClientes_Load(object sender, EventArgs e) {
            Listar();
        }

        public Listar() {

        }
    }
}
