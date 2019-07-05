namespace CRUD_05 {
    partial class CadastrarProfessor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.cmIdCurso = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_dados = new System.Windows.Forms.DataGridView();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttCancelar = new System.Windows.Forms.Button();
            this.bttExcluir = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            this.bttSalvar = new System.Windows.Forms.Button();
            this.butSair = new System.Windows.Forms.Button();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // cmIdCurso
            // 
            this.cmIdCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmIdCurso.FormattingEnabled = true;
            this.cmIdCurso.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmIdCurso.Location = new System.Drawing.Point(580, 98);
            this.cmIdCurso.Name = "cmIdCurso";
            this.cmIdCurso.Size = new System.Drawing.Size(102, 21);
            this.cmIdCurso.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(493, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "ID Curso:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(159, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(596, 20);
            this.txtNome.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome Professor :";
            // 
            // dg_dados
            // 
            this.dg_dados.AllowUserToAddRows = false;
            this.dg_dados.AllowUserToDeleteRows = false;
            this.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dados.Location = new System.Drawing.Point(16, 162);
            this.dg_dados.Name = "dg_dados";
            this.dg_dados.ReadOnly = true;
            this.dg_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_dados.Size = new System.Drawing.Size(636, 314);
            this.dg_dados.TabIndex = 25;
            this.dg_dados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dados_CellDoubleClick);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(96, 12);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Matricula: ";
            // 
            // buttCancelar
            // 
            this.buttCancelar.BackgroundImage = global::CRUD_05.Properties.Resources.Excluir;
            this.buttCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttCancelar.Location = new System.Drawing.Point(658, 366);
            this.buttCancelar.Name = "buttCancelar";
            this.buttCancelar.Size = new System.Drawing.Size(140, 59);
            this.buttCancelar.TabIndex = 28;
            this.toolTip1.SetToolTip(this.buttCancelar, "Cancelar");
            this.buttCancelar.UseVisualStyleBackColor = true;
            this.buttCancelar.Click += new System.EventHandler(this.buttCancelar_Click);
            // 
            // bttExcluir
            // 
            this.bttExcluir.BackgroundImage = global::CRUD_05.Properties.Resources.excluir_lix;
            this.bttExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttExcluir.Location = new System.Drawing.Point(658, 301);
            this.bttExcluir.Name = "bttExcluir";
            this.bttExcluir.Size = new System.Drawing.Size(140, 59);
            this.bttExcluir.TabIndex = 24;
            this.toolTip1.SetToolTip(this.bttExcluir, "Excluir");
            this.bttExcluir.UseVisualStyleBackColor = true;
            this.bttExcluir.Click += new System.EventHandler(this.bttExcluir_Click_1);
            // 
            // bttEditar
            // 
            this.bttEditar.BackgroundImage = global::CRUD_05.Properties.Resources.Editar2;
            this.bttEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttEditar.Location = new System.Drawing.Point(658, 228);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(140, 58);
            this.bttEditar.TabIndex = 23;
            this.toolTip1.SetToolTip(this.bttEditar, "Editar");
            this.bttEditar.UseVisualStyleBackColor = true;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click_1);
            // 
            // bttSalvar
            // 
            this.bttSalvar.BackgroundImage = global::CRUD_05.Properties.Resources.Salvar;
            this.bttSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttSalvar.Location = new System.Drawing.Point(657, 162);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(140, 60);
            this.bttSalvar.TabIndex = 22;
            this.toolTip1.SetToolTip(this.bttSalvar, "Salvar");
            this.bttSalvar.UseVisualStyleBackColor = true;
            this.bttSalvar.Click += new System.EventHandler(this.bttSalvar_Click_1);
            // 
            // butSair
            // 
            this.butSair.BackgroundImage = global::CRUD_05.Properties.Resources.sair;
            this.butSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butSair.Location = new System.Drawing.Point(658, 431);
            this.butSair.Name = "butSair";
            this.butSair.Size = new System.Drawing.Size(140, 59);
            this.butSair.TabIndex = 30;
            this.toolTip1.SetToolTip(this.butSair, "Sair");
            this.butSair.UseVisualStyleBackColor = true;
            this.butSair.Click += new System.EventHandler(this.butSair_Click);
            // 
            // cmbCursos
            // 
            this.cmbCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Items.AddRange(new object[] {
            "INTRODUÇÃO À INFORMÁTICA",
            "PROG. ORIENTADA A OBJETOS",
            "ALG. E ESTRUTURA DE DADOS",
            "ALG. EM GRAFOS",
            "BANCO DE DADOS",
            "INTRODUÇÃO À PESQUISA EM INFORMÁTICA",
            "TCC"});
            this.cmbCursos.Location = new System.Drawing.Point(77, 101);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(395, 21);
            this.cmbCursos.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Curso:";
            // 
            // CadastrarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 488);
            this.Controls.Add(this.butSair);
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
            this.Name = "CadastrarProfessor";
            this.Text = "CadastrarProfessor";
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttCancelar;
        private System.Windows.Forms.ComboBox cmIdCurso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttExcluir;
        private System.Windows.Forms.Button bttEditar;
        private System.Windows.Forms.Button bttSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_dados;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butSair;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}