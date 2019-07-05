using System; using System.Collections.Generic;
using System.ComponentModel; using System.Data;
using System.Drawing; using System.Linq;
using System.Text; using System.Threading.Tasks;
using System.Windows.Forms; using CRUD_05.BLL.System;
using CRUD_05.CRUD.System; using CRUD_05.MODEL.System;
using MySql.Data.MySqlClient;



namespace CRUD_05 {
    public partial class CadastrarAluno : Form {
        public CadastrarAluno() {
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
        private void Salvar(Aluno a, Curso curso)
            {
            Crud crud = new Crud();
           // CadastrarAluno ca = new CadastrarAluno();

            if ((txtNome.Text.Trim()==string.Empty)||(cmbCursos.Text.Trim()==string.Empty)||(cmIdCurso.Text.Trim()==string.Empty)) {
                MessageBox.Show("Campos obrigatórios a serem preenchidos!","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                a.Nome = txtNome.Text;
                cmbCursos.Text = curso.Nome_disc;
                a.Id_curso = int.Parse(cmIdCurso.Text);
               // curso.Id_curso = int.Parse(cmbCursos.Text);
                
                crud.CadastrarAluno(a);
               // crud.CadastrarCurso(curso);
                  Listar();
            }
          
            
        }
        private void Listar() {
            AlunoBLL pessoaBLL = new AlunoBLL();
            dg_dados.DataSource = pessoaBLL.Listar();
            CursoBLL cursoBLL = new CursoBLL();
            Curso c = new Curso();
            dg_dados.Columns[0].HeaderText = "MATRICULA";
            dg_dados.Columns[1].HeaderText = "ALUNO";
            dg_dados.Columns[2].HeaderText = "DISCIPLINA";
            dg_dados.Columns[0].Width = 80;
            dg_dados.Columns[1].Width = 300;
            dg_dados.Columns[2].Width = 200;




           // cmbCursos.DataSource = cursoBLL.Listar();
           // var dtCursos = new DataTable();
           // dtCursos.Columns.Add("DISCIPLINA");
           //// dtCursos.Rows.Add(dg_dados.CurrentRow.Cells[1]);
           // cmbCursos.ValueMember = "nome_disciplina";
           // cmbCursos.DisplayMember = "DISCIPLINA";
           // cmbCursos.DataSource = dtCursos;

           // cmbCursos.ValueMember = "nome_disciplina";
           // cmbCursos.DisplayMember = "DISCIPLINA";
           // //CadastrarAluno ca = new CadastrarAluno();
           // //ca.Teste(dg_dados.Rows[e.RowIndex].Cells[2].Value.ToString());
            LimparCampos();
           
        }

        private void bttSalvar_Click(object sender, EventArgs e) {
            Aluno aluno = new Aluno();
            Curso curso = new Curso();
            Salvar(aluno, curso);
        }

       

        private void dg_dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            txtMatricula.Text = dg_dados.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dg_dados.CurrentRow.Cells[1].Value.ToString();
            cmIdCurso.Text = dg_dados.CurrentRow.Cells[2].Value.ToString();
            // cmbCursos.DisplayMember = "DISCIPLINA";
            //mbCursos.DataSource = dg_dados.CurrentRow.Cells[1].ToString();
            //cmbCursos.Text = dg_dados.CurrentRow.Cells[5].Value.ToString();
            //CadastrarAluno ca = new CadastrarAluno();
            //ca.Teste(dg_dados.Rows[e.RowIndex].Cells[2].Value.ToString());
           
          
            

        }

        private void Teste(string e) {
            cmbCursos.Items.Add(e);
            cmbCursos.SelectedItem = e;
        }

        private void Editar(Aluno aluno) {
            Crud crud = new Crud();
            Curso curso = new Curso();
            AlunoBLL pessoaBLL = new AlunoBLL();

            if((txtNome.Text.Trim()==string.Empty)||(cmbCursos.Text.Trim() == string.Empty)||(cmIdCurso.Text.Trim()==string.Empty)) {
                MessageBox.Show("Campos Obrigatórios a serem preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.BackColor = Color.Yellow;
                txtMatricula.BackColor = Color.Yellow;
                cmbCursos.BackColor = Color.Yellow;
                cmIdCurso.BackColor = Color.Yellow;
               

            }
            else {
                aluno.Id_curso = int.Parse(cmIdCurso.Text);
                aluno.Nome = txtNome.Text.ToUpper();
                curso.Nome_disc = cmbCursos.Text.ToUpper();
                curso.Id_curso = int.Parse(cmIdCurso.Text);
                aluno.Matricula = int.Parse(txtMatricula.Text);
                
                pessoaBLL.Editar(aluno);
                MessageBox.Show("Dados alterados com Sucesso!");
                Listar();
                LimparCampos();
            }
        }
        private void bttEditar_Click(object sender, EventArgs e) {
            Aluno aluno = new Aluno();
            Editar(aluno);
        }

        private void Excluir(Aluno aluno) {
            Crud crud = new Crud();

            if (txtMatricula.Text.Trim() == string.Empty) {
                MessageBox.Show("Selecione um aluno para excluir!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if ((MessageBox.Show("Deseja realmente excluir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)) {

            }
            else {
                aluno.Matricula = int.Parse(txtMatricula.Text);
                crud.Excluir(aluno);
                MessageBox.Show("Aluno excluído com sucesso!!");
                Listar();
            }
        }

        private void bttExcluir_Click(object sender, EventArgs e) {
            Aluno a = new Aluno();
            Excluir(a);
            LimparCampos();
        }

       
        private void buttSair_Click(object sender, EventArgs e) {
            this.Close();
            
        }

        private void buttCancelar_Click(object sender, EventArgs e) {
            LimparCampos();
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
                //Object[] cursos = new Object[20];
                //cmbCursos.Items.AddRange(cursos);
               //Curso cursrro = (Curso)cmbCursos.SelectedItem;

            }
            catch (Exception ex) {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void PreencherComboBoxID() {
            CursoBLL curso = new CursoBLL();
            CrudCurso crd = new CrudCurso();
            MySqlCommand comando;
            try {
                crd.AbrirConexao();
                DataTable dt = new DataTable();
                comando = new MySqlCommand("SELECT curso.idcurso FROM curso ORDER BY idcurso", crd.conectarBD);
                MySqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                cmIdCurso.DisplayMember = "idcurso";
                cmIdCurso.DataSource = dt;
            }
            catch (Exception ex) {

                throw ex;
            }
        }
    }
}
