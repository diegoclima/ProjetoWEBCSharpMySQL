namespace CRUD_05 {
    partial class CadastrarCurso {
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_dados = new System.Windows.Forms.DataGridView();
            this.buttCancelar = new System.Windows.Forms.Button();
            this.bttExcluir = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            this.bttSalvar = new System.Windows.Forms.Button();
            this.buttSair = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdcurso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(103, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(551, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(4, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Disciplina :";
            // 
            // dg_dados
            // 
            this.dg_dados.AllowUserToAddRows = false;
            this.dg_dados.AllowUserToDeleteRows = false;
            this.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dados.Location = new System.Drawing.Point(8, 132);
            this.dg_dados.Name = "dg_dados";
            this.dg_dados.ReadOnly = true;
            this.dg_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_dados.Size = new System.Drawing.Size(634, 323);
            this.dg_dados.TabIndex = 3;
            this.dg_dados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dados_CellDoubleClick);
            // 
            // buttCancelar
            // 
            this.buttCancelar.BackgroundImage = global::CRUD_05.Properties.Resources.Excluir;
            this.buttCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttCancelar.Location = new System.Drawing.Point(648, 331);
            this.buttCancelar.Name = "buttCancelar";
            this.buttCancelar.Size = new System.Drawing.Size(140, 59);
            this.buttCancelar.TabIndex = 7;
            this.buttCancelar.UseVisualStyleBackColor = true;
            this.buttCancelar.Click += new System.EventHandler(this.buttCancelar_Click);
            // 
            // bttExcluir
            // 
            this.bttExcluir.BackgroundImage = global::CRUD_05.Properties.Resources.excluir_lix;
            this.bttExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttExcluir.Location = new System.Drawing.Point(648, 262);
            this.bttExcluir.Name = "bttExcluir";
            this.bttExcluir.Size = new System.Drawing.Size(140, 59);
            this.bttExcluir.TabIndex = 6;
            this.bttExcluir.UseVisualStyleBackColor = true;
            this.bttExcluir.Click += new System.EventHandler(this.bttExcluir_Click);
            // 
            // bttEditar
            // 
            this.bttEditar.BackgroundImage = global::CRUD_05.Properties.Resources.Editar2;
            this.bttEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttEditar.Location = new System.Drawing.Point(648, 198);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(140, 58);
            this.bttEditar.TabIndex = 5;
            this.bttEditar.UseVisualStyleBackColor = true;
            this.bttEditar.Click += new System.EventHandler(this.bttEditar_Click);
            // 
            // bttSalvar
            // 
            this.bttSalvar.BackgroundImage = global::CRUD_05.Properties.Resources.Salvar;
            this.bttSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttSalvar.Location = new System.Drawing.Point(648, 132);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(140, 60);
            this.bttSalvar.TabIndex = 4;
            this.bttSalvar.UseVisualStyleBackColor = true;
            this.bttSalvar.Click += new System.EventHandler(this.bttSalvar_Click);
            // 
            // buttSair
            // 
            this.buttSair.BackgroundImage = global::CRUD_05.Properties.Resources.sair;
            this.buttSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttSair.Location = new System.Drawing.Point(648, 396);
            this.buttSair.Name = "buttSair";
            this.buttSair.Size = new System.Drawing.Size(140, 59);
            this.buttSair.TabIndex = 8;
            this.buttSair.UseVisualStyleBackColor = true;
            this.buttSair.Click += new System.EventHandler(this.buttSair_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(4, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID Curso:";
            // 
            // txtIdcurso
            // 
            this.txtIdcurso.Location = new System.Drawing.Point(91, 18);
            this.txtIdcurso.Name = "txtIdcurso";
            this.txtIdcurso.ReadOnly = true;
            this.txtIdcurso.Size = new System.Drawing.Size(63, 20);
            this.txtIdcurso.TabIndex = 21;
            // 
            // CadastrarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 471);
            this.Controls.Add(this.txtIdcurso);
            this.Controls.Add(this.buttSair);
            this.Controls.Add(this.buttCancelar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttExcluir);
            this.Controls.Add(this.bttEditar);
            this.Controls.Add(this.bttSalvar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_dados);
            this.MaximizeBox = false;
            this.Name = "CadastrarCurso";
            this.Text = "Cadastrar Curso";
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttCancelar;
        private System.Windows.Forms.Button bttExcluir;
        private System.Windows.Forms.Button bttEditar;
        private System.Windows.Forms.Button bttSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_dados;
        private System.Windows.Forms.Button buttSair;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdcurso;
    }
}