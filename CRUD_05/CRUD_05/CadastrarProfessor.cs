using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_05.BLL.System;
using CRUD_05.CRUD.System;
using CRUD_05.MODEL.System;
using MySql.Data.MySqlClient;



namespace CRUD_05 {
    public partial class CadastrarProfessor : Form {
        public CadastrarProfessor() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            PreencherComboBox();
            PreencherComboBoxID();
            Listar();

        }
        public void LimparCampos() {
            txtMatricula.Clear();
            txtNome.Clear();
            cmbCursos.SelectedIndex = -1;
            cmIdCurso.SelectedIndex = -1;
            txtNome.BackColor = Color.White;
            cmIdCurso.BackColor = Color.White;
            cmbCursos.BackColor = Color.White;

        }

        private void Salvar(Professor prof, Curso curso) {
            CrudProfessor crud = new CrudProfessor();
           // CrudCurso cursoCrud = new CrudCurso();

            if ((txtNome.Text.Trim() == string.Empty) || (cmbCursos.Text.Trim() == string.Empty) || (cmIdCurso.Text.Trim() == string.Empty)) {
                MessageBox.Show("Campos obrigatórios a serem preenchidos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                prof.Nome = txtNome.Text;
                curso.Nome_disc = cmbCursos.Text;
                prof.Id_curso = int.Parse(cmIdCurso.Text);
               // prof.Matricula = int.Parse(txtMatricula.Text);
                crud.CadastrarProfessor(prof);
                crud.CadastrarCurso(curso);
                Listar();
            }


        }
        private void Listar() {
            ProfessorBLL professorBLL = new ProfessorBLL();
            dg_dados.DataSource = professorBLL.Listar();

            dg_dados.Columns[0].HeaderText = "MATRICULA";
            dg_dados.Columns[1].HeaderText = "PROFESSOR";
            dg_dados.Columns[2].HeaderText = "DISCIPLINA";
            dg_dados.Columns[0].Width = 80;
            dg_dados.Columns[1].Width = 300;
            dg_dados.Columns[2].Width = 200;
            LimparCampos();

        }

        //private void bttSalvar_Click(object sender, EventArgs e) {
        //    Professor professor = new Professor();
        //    Curso curso = new Curso();
        //    Salvar(professor, curso);
        //}

        private void dg_dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            txtMatricula.Text = dg_dados.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dg_dados.CurrentRow.Cells[1].Value.ToString();
            cmIdCurso.Text = dg_dados.CurrentRow.Cells[2].Value.ToString();
            //cmbCursos.Text = dg_dados.CurrentRow.Cells[5].Value.ToString();




        }

        private void Editar(Professor prof) {
            CrudProfessor professor = new CrudProfessor();
            Curso curso = new Curso();
            ProfessorBLL professorBLL = new ProfessorBLL();

            if ((txtNome.Text.Trim() == string.Empty) || (cmbCursos.Text.Trim() == string.Empty) || (cmIdCurso.Text.Trim() == string.Empty)) {
                MessageBox.Show("Campos Obrigatórios a serem preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.BackColor = Color.Yellow;
                txtMatricula.BackColor = Color.Yellow;
                cmbCursos.BackColor = Color.Yellow;
                cmIdCurso.BackColor = Color.Yellow;


            }
            else {
                prof.Id_curso = int.Parse(cmIdCurso.Text);
                prof.Nome = txtNome.Text.ToUpper();
                curso.Nome_disc = cmbCursos.Text.ToUpper();
                curso.Id_curso = int.Parse(cmIdCurso.Text);
                prof.Matricula = int.Parse(txtMatricula.Text);

                professorBLL.Editar(prof);
                MessageBox.Show("Dados alterados com Sucesso!");
                Listar();
                LimparCampos();
            }
        }
        
        private void Excluir(Professor prof) {
            CrudProfessor crud = new CrudProfessor();

            if (txtMatricula.Text.Trim() == string.Empty) {
                MessageBox.Show("Selecione um professor para excluir!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if ((MessageBox.Show("Deseja realmente excluir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)) {

            }
            else {
                prof.Matricula = int.Parse(txtMatricula.Text);
                crud.Excluir(prof);
                MessageBox.Show("Professor(a) excluído(a) com sucesso!!");
                Listar();
            }
        }

        //private void buttCancelar_Click(object sender, EventArgs e) {
        //    LimparCampos();
        //}

       

        private void bttSalvar_Click_1(object sender, EventArgs e) {
            Professor professor = new Professor();
            Curso curso = new Curso();
            Salvar(professor, curso);
        }

        private void bttEditar_Click_1(object sender, EventArgs e) {
            Professor prof = new Professor();
            Editar(prof);
        }

        private void bttExcluir_Click_1(object sender, EventArgs e) {
            Professor p = new Professor();
            Excluir(p);
            LimparCampos();
        }

        private void buttCancelar_Click(object sender, EventArgs e) {
            LimparCampos();
        }

        private void butSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void PreencherComboBoxID() {
            CursoBLL curso = new CursoBLL();
            CrudCurso crd = new CrudCurso();
            MySqlCommand comando;
            try {
                crd.AbrirConexao();
                DataTable dt = new DataTable();
                //comando = new MySqlCommand("SELECT curso.idcurso FROM curso ORDER BY idcurso", crd.conectarBD);
                comando = new MySqlCommand("select curso.nome_disciplina, curso.idcurso from curso GROUP BY nome_disciplina", crd.conectarBD);
                MySqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                cmIdCurso.DisplayMember = "idcurso";

                cmIdCurso.DataSource = dt;
            }
            catch (Exception ex) {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void PreencherComboBox() {
            CursoBLL curso = new CursoBLL();
            CrudCurso crd = new CrudCurso();
            MySqlCommand comando;
            try {
                crd.AbrirConexao();
                DataTable dt = new DataTable();
                comando = new MySqlCommand("SELECT curso.nome_disciplina FROM curso ORDER BY nome_disciplina", crd.conectarBD);
                MySqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                cmbCursos.DisplayMember = "nome_disciplina";
                cmbCursos.DataSource = dt;
            }
            catch (Exception ex) {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }

    


}
