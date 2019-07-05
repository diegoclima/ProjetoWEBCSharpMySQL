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
    public partial class CadastrarCurso : Form {
        public CadastrarCurso() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
           // PreencherID();
            Listar();
        }
        //private void PreencherID() {
        //    CrudCurso crudCurso = new CrudCurso();

        //    try {
        //        crudCurso.AbrirConexao();
        //        MySqlCommand comando2 = new MySqlCommand();
        //        comando2 = new MySqlCommand("SELECT curso.idcurso FROM curso ORDER BY idcurso", crudCurso.conectarBD);
        //        MySqlDataReader dr2 = comando2.ExecuteReader();
        //        DataTable dt2 = new DataTable();
        //        dt2.Load(dr2);
        //        cmbIdcurso.DisplayMember = "idcurso";
        //        cmbIdcurso.DataSource = dt2;
        //    }
        //    catch (Exception ex) {

        //        throw ex;
        //    }
        //}
        public void LimparCampos() {
           // txtIdCurso.Clear();
            txtNome.Clear();
            txtNome.BackColor = Color.White;
            txtIdcurso.BackColor = Color.White;

        }

        private void Salvar(Curso curso) {
            CrudCurso crud = new CrudCurso();
            if ((txtNome.Text.Trim() == string.Empty)) {
                MessageBox.Show("Campos Obrigatórios a serem preenchidos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
              
                curso.Nome_disc = txtNome.Text;
                //  curso.Id_curso = int.Parse(txtIdcurso.Text);
                crud.CadastrarCurso(curso);


                Listar();
                    
            }
        }

        private void Listar() {
            CursoBLL cursoBLL = new CursoBLL();
            dg_dados.DataSource = cursoBLL.Listar();

           dg_dados.Columns[0].HeaderText = "ID";
           dg_dados.Columns[1].HeaderText = "NOME DISCIPLINA";
            LimparCampos();
        }

        private void bttSalvar_Click(object sender, EventArgs e) {
            Curso c = new Curso();
            Salvar(c);
        }

        //private void dg_dados_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        //    txtIdCurso.Text = dg_dados.CurrentRow.Cells[0].Value.ToString();
        //    txtNome.Text = dg_dados.CurrentRow.Cells[1].Value.ToString();
        //}

        private void Editar(Curso curso) {
            CrudCurso crud = new CrudCurso();
            CursoBLL cursoBLL = new CursoBLL();

            if ((txtIdcurso.Text.Trim() == string.Empty) || (txtNome.Text.Trim() == string.Empty)) {
                MessageBox.Show("Campos obrigatórios a serem preenchidos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {
                curso.Id_curso = int.Parse(txtIdcurso.Text);
                curso.Nome_disc = txtNome.Text.ToUpper();

                cursoBLL.Editar(curso);
                MessageBox.Show("Dados alterados com Sucesso!!");
                Listar();
                LimparCampos();
            }
        }

        private void bttEditar_Click(object sender, EventArgs e) {
            Curso c = new Curso();
            Editar(c);
        }

        private void Excluir(Curso c) {
            CrudCurso crudCurso = new CrudCurso();

            if ((txtIdcurso.Text.Trim() == string.Empty) || (txtNome.Text.Trim() == string.Empty)) {
                MessageBox.Show("Selecione um curso para excluir!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if((MessageBox.Show("Deseja realmente excluir?","Atenção!",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.No)) {

            }
            else {
                c.Id_curso = int.Parse(txtIdcurso.Text);
                crudCurso.Excluir(c);
                MessageBox.Show("Curso excluído com sucesso!!");
                Listar();

            }
        }

        private void bttExcluir_Click(object sender, EventArgs e) {
            Curso c = new Curso();
            Excluir(c);
            LimparCampos();
        }

        private void buttCancelar_Click(object sender, EventArgs e) {
            LimparCampos();
        }

        private void buttSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dg_dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            txtIdcurso.Text = dg_dados.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dg_dados.CurrentRow.Cells[1].Value.ToString();
        }

        //private void PreencherComboBox() {
        //    CursoBLL curso = new CursoBLL();
        //    CrudCurso crd = new CrudCurso();
        //    MySqlCommand comando;
        //    try {
        //        crd.AbrirConexao();
        //        DataTable dt = new DataTable();
        //        comando = new MySqlCommand("SELECT curso.nome_disciplina FROM curso ORDER BY nome_disciplina", crd.conectarBD);
        //        MySqlDataReader dr = comando.ExecuteReader();
        //        dt.Load(dr);
        //        cmbCursos.DisplayMember = "nome_disciplina";
        //        cmbCursos.DataSource = dt;
        //    }
        //    catch (Exception ex) {

        //        throw ex;
        //    }
        //}

        //private void PreencherComboBoxID() {
        //    CursoBLL curso = new CursoBLL();
        //    CrudCurso crd = new CrudCurso();
        //    MySqlCommand comando;
        //    try {
        //        crd.AbrirConexao();
        //        DataTable dt = new DataTable();
        //        comando = new MySqlCommand("SELECT curso.idcurso FROM curso ORDER BY idcurso", crd.conectarBD);
        //        MySqlDataReader dr = comando.ExecuteReader();
        //        dt.Load(dr);
        //        cmbCursos.DisplayMember = "idcurso";
        //        cmbCursos.DataSource = dt;
        //    }
        //    catch (Exception ex) {

        //        throw ex;
        //    }
        //}
    }
}
