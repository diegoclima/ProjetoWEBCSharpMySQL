namespace CRUD_02 {
    partial class CRUD {
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
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.butSalvar = new System.Windows.Forms.Button();
            this.butEditar = new System.Windows.Forms.Button();
            this.buttExcluir = new System.Windows.Forms.Button();
            this.butPesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.rbProf = new System.Windows.Forms.RadioButton();
            this.rbAluno = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(66, 29);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(132, 26);
            this.txtMatricula.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricula";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(292, 26);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(576, 26);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Curso :";
            // 
            // cmbCurso
            // 
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "POO",
            "Arquitetura",
            "Banco de Dados",
            "Requisitos",
            "Modelagem de Processos",
            "Fundamentos de Sistemas de Informação",
            "Fundamentos Matemáticos",
            "Introdução à Informática",
            "Filosofia",
            "Religiao 1",
            "Religiao 2",
            "Filosofia 2"});
            this.cmbCurso.Location = new System.Drawing.Point(51, 94);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(313, 28);
            this.cmbCurso.TabIndex = 6;
            // 
            // butSalvar
            // 
            this.butSalvar.Location = new System.Drawing.Point(40, 186);
            this.butSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSalvar.Name = "butSalvar";
            this.butSalvar.Size = new System.Drawing.Size(100, 35);
            this.butSalvar.TabIndex = 11;
            this.butSalvar.Text = "Salvar";
            this.butSalvar.UseVisualStyleBackColor = true;
            // 
            // butEditar
            // 
            this.butEditar.Location = new System.Drawing.Point(161, 186);
            this.butEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butEditar.Name = "butEditar";
            this.butEditar.Size = new System.Drawing.Size(100, 35);
            this.butEditar.TabIndex = 12;
            this.butEditar.Text = "Editar";
            this.butEditar.UseVisualStyleBackColor = true;
            // 
            // buttExcluir
            // 
            this.buttExcluir.Location = new System.Drawing.Point(292, 186);
            this.buttExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttExcluir.Name = "buttExcluir";
            this.buttExcluir.Size = new System.Drawing.Size(100, 35);
            this.buttExcluir.TabIndex = 13;
            this.buttExcluir.Text = "Excluir";
            this.buttExcluir.UseVisualStyleBackColor = true;
            // 
            // butPesquisar
            // 
            this.butPesquisar.Location = new System.Drawing.Point(425, 186);
            this.butPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butPesquisar.Name = "butPesquisar";
            this.butPesquisar.Size = new System.Drawing.Size(100, 35);
            this.butPesquisar.TabIndex = 14;
            this.butPesquisar.Text = "Pesquisar";
            this.butPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(897, 325);
            this.dataGridView1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rbProf
            // 
            this.rbProf.AutoSize = true;
            this.rbProf.Location = new System.Drawing.Point(12, 145);
            this.rbProf.Name = "rbProf";
            this.rbProf.Size = new System.Drawing.Size(85, 24);
            this.rbProf.TabIndex = 18;
            this.rbProf.TabStop = true;
            this.rbProf.Text = "Professor";
            this.rbProf.UseVisualStyleBackColor = true;
            // 
            // rbAluno
            // 
            this.rbAluno.AutoSize = true;
            this.rbAluno.Location = new System.Drawing.Point(103, 145);
            this.rbAluno.Name = "rbAluno";
            this.rbAluno.Size = new System.Drawing.Size(61, 24);
            this.rbAluno.TabIndex = 19;
            this.rbAluno.TabStop = true;
            this.rbAluno.Text = "Aluno";
            this.rbAluno.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 186);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 22;
            this.button2.Text = "Listar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Area de Pesquisa: ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(513, 138);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(363, 28);
            this.comboBox2.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(513, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(355, 28);
            this.comboBox1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Grupo TCC :";
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(929, 571);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rbAluno);
            this.Controls.Add(this.rbProf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butPesquisar);
            this.Controls.Add(this.buttExcluir);
            this.Controls.Add(this.butEditar);
            this.Controls.Add(this.butSalvar);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatricula);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "CRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Button butSalvar;
        private System.Windows.Forms.Button butEditar;
        private System.Windows.Forms.Button buttExcluir;
        private System.Windows.Forms.Button butPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbProf;
        private System.Windows.Forms.RadioButton rbAluno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}

