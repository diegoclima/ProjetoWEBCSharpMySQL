using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_06 {
    public partial class Validacao : Form {
        public Validacao() {
            
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void buttLogin_Click(object sender, EventArgs e) {
            if (textUsuario.Text.Equals("12345") && (textUsuario.Equals("admin"))) {
                this.Hide();
                Form1 menu = new Form1();
                menu.ShowDialog();
                this.Close();
                DialogResult = DialogResult.OK;
            }
            else {
                MessageBox.Show("Senha ou usuário inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUsuario.Clear();
                textSenha.Clear();
            }
        }

        private void buttSair_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
