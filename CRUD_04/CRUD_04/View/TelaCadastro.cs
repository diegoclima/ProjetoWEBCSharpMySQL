using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_04.BLL.System;
using CRUD_04.MODEL;
using CRUD_04.DAO.System;

namespace CRUD_04.View {
    public partial class TelaCadastro : Form {
        public TelaCadastro() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Listar();
        }
        private void LimparCampos() {
            txtCod.Clear();
            txtNome.Clear();
            cmbSexo.SelectedIndex = -1;
            cmUf.SelectedIndex = -1;
            txtEndereco.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            mskCelular.Clear();
            mskTelefone.Clear();
            txtNome.BackColor = Color.White;
            txtEndereco.BackColor = Color.White;

        }
        private void Salvar(Pessoa pessoa) {
            PessoaDAO pessoaDAO = new PessoaDAO();
            if ((txtNome.Text.Trim() == string.Empty) || (cmbSexo.Text.Trim() == string.Empty) || (txtEndereco.Text.Trim()) == string.Empty) {
                MessageBox.Show("Campos obrigatórios a serem preenchidos!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.BackColor = Color.Yellow;
                txtEndereco.BackColor = Color.Yellow;
                cmbSexo.BackColor = Color.Yellow;


            }
             
            else {
                pessoa.Nome = txtNome.Text;
                pessoa.Sexo = cmbSexo.Text;
                // pessoa.Id = int.Parse(txtCod.Text);
                pessoa.Telefone = mskTelefone.Text;
                pessoa.Celular = mskCelular.Text;
                pessoa.UF = cmUf.Text;
                pessoa.Bairro = txtBairro.Text;
                pessoa.Cidade = txtCidade.Text;
                pessoa.Endereco = txtEndereco.Text;
                pessoaDAO.Salvar(pessoa);
                MessageBox.Show("Pesssoa salva com sucesso!");
                Listar();
                LimparCampos();
            }
           
        }

        private void buttSalvar_Click(object sender, EventArgs e) {
            Pessoa pessoa = new Pessoa();
            Salvar(pessoa);
            
        }
        /// <summary>
        /// Método para listar as pessoas cadastradas no BD.
        /// </summary>
        private void Listar() {
            PessoaBLL pessoaBLL = new PessoaBLL();
            dg_dados.DataSource = pessoaBLL.Listar();
            dg_dados.Columns[0].HeaderText = "Cod";
            dg_dados.Columns[1].HeaderText = "Nome";
            dg_dados.Columns[2].HeaderText = "Tel.Fixo";
            dg_dados.Columns[3].HeaderText = "Cel.";
            dg_dados.Columns[4].HeaderText = "Bairro";
            dg_dados.Columns[5].HeaderText = "Cidade";
            dg_dados.Columns[6].HeaderText = "UF";
            dg_dados.Columns[7].HeaderText = "Sexo";
            dg_dados.Columns[8].HeaderText = "Endereço";

            dg_dados.Columns[0].Width = 40;
            dg_dados.Columns[1].Width = 200;
            dg_dados.Columns[7].Width = 40;
            dg_dados.Columns[6].Width = 40;
            dg_dados.Columns[4].Width = 60;
            LimparCampos();

        }


        private void dg_dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            txtCod.Text = dg_dados.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dg_dados.CurrentRow.Cells[1].Value.ToString();
            cmbSexo.Text = dg_dados.CurrentRow.Cells[7].Value.ToString();
            mskTelefone.Text = dg_dados.CurrentRow.Cells[2].Value.ToString();
            cmUf.Text = dg_dados.CurrentRow.Cells[6].Value.ToString();
            txtBairro.Text = dg_dados.CurrentRow.Cells[5].Value.ToString();
            txtCidade.Text = dg_dados.CurrentRow.Cells[4].Value.ToString();
            txtEndereco.Text = dg_dados.CurrentRow.Cells[8].Value.ToString();
            mskCelular.Text = dg_dados.CurrentRow.Cells[3].Value.ToString();

        }

        /// <summary>
        /// Método para editar os dados
        /// </summary>
        private void Editar(Pessoa pessoa) {
            PessoaBLL pessoaBLL = new PessoaBLL();

            //.Trim não deixa salvar só um dado, ao dar um espaço aceita como caracter. Com o Trim,
            //mesmo com espaço ele não irá salvar.
            if ((txtNome.Text.Trim() == string.Empty) || (cmbSexo.Text.Trim() == string.Empty) || (txtEndereco.Text.Trim()) == string.Empty) {
                MessageBox.Show("Campos obrigatórios a serem preenchidos!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.BackColor = Color.Yellow;
                txtEndereco.BackColor = Color.Yellow;
                cmbSexo.BackColor = Color.Yellow;


            }
            else {
                pessoa.Id = Convert.ToInt32(txtCod.Text);
                pessoa.Nome = txtNome.Text;
                pessoa.Sexo = cmbSexo.Text;
                // pessoa.Id = int.Parse(txtCod.Text);
                pessoa.Telefone = mskTelefone.Text;
                pessoa.Celular = mskCelular.Text;
                pessoa.UF = cmUf.Text;
                pessoa.Bairro = txtBairro.Text;
                pessoa.Cidade = txtCidade.Text;
                pessoa.Endereco = txtEndereco.Text;
                pessoaBLL.Editar(pessoa);
                MessageBox.Show("Dados alterados com Sucesso!");
                Listar();
                LimparCampos();
            }

            
        }

        private void buttAlterar_Click(object sender, EventArgs e) {
            Pessoa pessoa = new Pessoa();
            Editar(pessoa);
            
        }
        /// <summary>
        /// Método para excluir
        /// </summary>
        /// <param name="pessoa"></param>
        //private void Excluir(Pessoa pessoa) {
        //    PessoaBLL pessoaBLL = new PessoaBLL();
        //   pessoa.Id = int.Parse(txtCod.Text);
        //    pessoaBLL.Excluir(pessoa);
        //    MessageBox.Show("Excluído com Sucesso!");
        //    Listar();
        //    LimparCampos();
        //}
        private void Excluir(Pessoa pessoa) {
            PessoaBLL pessoaBLL = new PessoaBLL();
            if (txtCod.Text.Trim()==string.Empty) {
                MessageBox.Show("Selecione uma pessoa para excluir!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if((MessageBox.Show("Deseja realmente excluir essa pessoa?","Alera",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)) {

            }
            else {
                pessoa.Id = int.Parse(txtCod.Text);
                pessoaBLL.Excluir(pessoa);
                MessageBox.Show("Pessoa excluída com sucesso!");
                Listar();
            }
            
        }


        private void buttExcluir_Click(object sender, EventArgs e) {
            Pessoa pessoa = new Pessoa();
            Excluir(pessoa);
            LimparCampos();
        }

        private void buttCancelar_Click(object sender, EventArgs e) {
            LimparCampos();
        }
    }
}
