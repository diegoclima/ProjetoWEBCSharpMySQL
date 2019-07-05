using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_05 {
    public partial class MENU : Form {
        public MENU() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
           
         //   Listar();
        }

        private void buttCurso_Click(object sender, EventArgs e) {
            CadastrarCurso ccurso = new CadastrarCurso();
            ccurso.Show();
        }

        

        private void buttAluno_Click(object sender, EventArgs e) {
            CadastrarAluno ca = new CadastrarAluno();
            
                ca.Show();
            

        }

        private void buttProf_Click(object sender, EventArgs e) {
            CadastrarProfessor cp = new CadastrarProfessor();
            
                cp.Show();
           
        }

        private void buttSair_Click(object sender, EventArgs e) {
            this.Close();
        }





        //private void button1_Click(object sender, EventArgs e) {

        //    CadastrarAluno ca = new CadastrarAluno();
        //    ca.Show();
        //}

        //private void button2_Click(object sender, EventArgs e) {
        //    CadastrarProfessor cp = new CadastrarProfessor();
        //    cp.Show();
        //}

        //private void button3_Click(object sender, EventArgs e) {
        //    CadastrarCurso ccurso = new CadastrarCurso();
        //    ccurso.Show();
        //}

        //private void button1_Click_1(object sender, EventArgs e) {
        //    this.Close();
        //}
    }
}
