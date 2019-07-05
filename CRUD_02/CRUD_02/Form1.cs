using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_02.Dados.System;

namespace CRUD_02 {
    public partial class CRUD : Form {
        public CRUD() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            

            
        }

       

        private void txtNome_TextChanged(object sender, EventArgs e) {
            Aluno a = new Aluno();
            Professor p = new Professor();

            if (rbAluno.Capture) {
               a.Nome = txtNome.
            }
        }
    }
}
