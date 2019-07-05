namespace CRUD_05 {
    partial class CadastrarAluno {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.dg_dados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttCancelar = new System.Windows.Forms.Button();
            this.bttExcluir = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            this.bttSalvar = new System.Windows.Forms.Button();
            this.cmIdCurso = new System.Windows.Forms.ComboBox();
            this.buttSair = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula: ";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(84, 9);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // dg_dados
            // 
            this.dg_dados.AllowUserToAddRows = false;
            this.dg_dados.AllowUserToDeleteRows = false;
            this.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dados.Location = new System.Drawing.Point(4, 159);
            this.dg_dados.Name = "dg_dados";
            this.dg_dados.ReadOnly = true;
            this.dg_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_dados.Size = new System.Drawing.Size(636, 310);
            this.dg_dados.TabIndex = 11;
            this.dg_dados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dados_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(0, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(596, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(0, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Curso:";
            // 
            // cmbCursos
            // 
            this.cmbCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Location = new System.Drawing.Point(84, 102);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(395, 21);
            this.cmbCursos.TabIndex = 3;
            // 
            // buttCancelar
            // 
            this.buttCancelar.BackgroundImage = global::CRUD_05.Properties.Resources.Excluir;
            this.buttCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttCancelar.Location = new System.Drawing.Point(646, 363);
            this.buttCancelar.Name = "buttCancelar";
            this.buttCancelar.Size = new System.Drawing.Size(140, 59);
            this.buttCancelar.TabIndex = 15;
            this.toolTip1.SetToolTip(this.buttCancelar, "Cancelar");
            this.buttCancelar.UseVisualStyleBackColor = true;
            this.buttCancelar.Click += new System.EventHandler(this.buttCancelar_Click);
            // 
            // bttExcluir
            // 
            this.bttExcluir.BackgroundImage = global::CRUD_05.Properties.Resources.excluir_lix;
            this.bttExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttExcluir.Location = new System.Drawing.Point(646, 298);
            this.bttExcluir.Name = "bttExcluir";
            this.bttExcluir.Size = new System.Drawing.Size(140, 59);
            this.bttExcluir.TabIndex = 9;
            this.toolTip1.SetToolTip(this.bttExcluir, "Excluir");
            this.bttExcluir.UseVisualStyleBackColor = true;
            this.bttExcluir.Click += new System.EventHandler(this.bttExcluir_Click);
            // 
            // bttEditar
            // 
            this.bttEditar.BackgroundImage = global::CRUD_05.Properties.Resources.Editar2;
            this.bttEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttEditar.Location = new System.Drawing.Point(646, 225);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(140, 58);
            this.bttEditar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.bttEditar, "Editar");
            this.bttEditar.UseVisualStyleBackColor = true;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
            // 
            // bttSalvar
            // 
            this.bttSalvar.BackgroundImage = global::CRUD_05.Properties.Resources.Salvar;
            this.bttSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttSalvar.Location = new System.Drawing.Point(646, 159);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(140, 60);
            this.bttSalvar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.bttSalvar, "Salvar");
            this.bttSalvar.UseVisualStyleBackColor = true;
            this.bttSalvar.Click += new System.EventHandler(this.bttSalvar_Click);
            // 
            // cmIdCurso
            // 
            this.cmIdCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmIdCurso.FormattingEnabled = true;
            this.cmIdCurso.Location = new System.Drawing.Point(578, 101);
            this.cmIdCurso.Name = "cmIdCurso";
            this.cmIdCurso.Size = new System.Drawing.Size(102, 21);
            this.cmIdCurso.TabIndex = 14;
            // 
            // buttSair
            // 
            this.buttSair.BackgroundImage = global::CRUD_05.Properties.Resources.sair;
            this.buttSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttSair.Location = new System.Drawing.Point(646, 428);
            this.buttSair.Name = "buttSair";
            this.buttSair.Size = new System.Drawing.Size(140, 59);
            this.buttSair.TabIndex = 30;
            this.buttSair.UseVisualStyleBackColor = true;
            this.buttSair.Click += new System.EventHandler(this.buttSair_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(491, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID Curso:";
            // 
            // CadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 481);
            this.Controls.Add(this.buttSair);
            this.Controls.Add(this.buttCancelar);
            this.Controls.Add(this.cmIdCurso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttExcluir);
            this.Controls.Add(this.bttEditar);
            this.Controls.Add(this.bttSalvar);
            this.Controls.Add(this.cmbCursos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_dados);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CadastrarAluno";
            this.Text = "Cadastrar Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.DataGridView dg_dados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.Button bttSalvar;
        private System.Windows.Forms.Button bttEditar;
        private System.Windows.Forms.Button bttExcluir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmIdCurso;
        private System.Windows.Forms.Button buttCancelar;
        private System.Windows.Forms.Button buttSair;
        private System.Windows.Forms.Label label7;
    }
}

