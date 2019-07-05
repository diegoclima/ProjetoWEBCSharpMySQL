namespace CRUD_04.View {
    partial class TelaCadastro {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.dg_dados = new System.Windows.Forms.DataGridView();
            this.buttCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmUf = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.buttSalvar = new System.Windows.Forms.Button();
            this.buttExcluir = new System.Windows.Forms.Button();
            this.buttAlterar = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(53, 6);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 0;
            // 
            // dg_dados
            // 
            this.dg_dados.AllowUserToAddRows = false;
            this.dg_dados.AllowUserToDeleteRows = false;
            this.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dados.Location = new System.Drawing.Point(7, 173);
            this.dg_dados.Name = "dg_dados";
            this.dg_dados.ReadOnly = true;
            this.dg_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_dados.Size = new System.Drawing.Size(736, 310);
            this.dg_dados.TabIndex = 9;
            this.dg_dados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dados_CellDoubleClick);
            // 
            // buttCancelar
            // 
            this.buttCancelar.BackgroundImage = global::CRUD_04.Properties.Resources.Excluir;
            this.buttCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttCancelar.Location = new System.Drawing.Point(749, 349);
            this.buttCancelar.Name = "buttCancelar";
            this.buttCancelar.Size = new System.Drawing.Size(75, 53);
            this.buttCancelar.TabIndex = 14;
            this.toolTip.SetToolTip(this.buttCancelar, "Cancelar");
            this.buttCancelar.UseVisualStyleBackColor = true;
            this.buttCancelar.Click += new System.EventHandler(this.buttCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(468, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sexo: ";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(599, 45);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(84, 21);
            this.cmbSexo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefone: ";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(64, 130);
            this.mskTelefone.Mask = "(00)0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(100, 20);
            this.mskTelefone.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Celular: ";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(64, 104);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(260, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(221, 134);
            this.mskCelular.Mask = "(00)00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(86, 20);
            this.mskCelular.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(379, 104);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(354, 20);
            this.txtCidade.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(739, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "UF";
            // 
            // cmUf
            // 
            this.cmUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmUf.FormattingEnabled = true;
            this.cmUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmUf.Location = new System.Drawing.Point(766, 103);
            this.cmUf.Name = "cmUf";
            this.cmUf.Size = new System.Drawing.Size(60, 21);
            this.cmUf.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(64, 69);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(468, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // buttSalvar
            // 
            this.buttSalvar.BackgroundImage = global::CRUD_04.Properties.Resources.Salvar;
            this.buttSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttSalvar.Location = new System.Drawing.Point(751, 173);
            this.buttSalvar.Name = "buttSalvar";
            this.buttSalvar.Size = new System.Drawing.Size(75, 43);
            this.buttSalvar.TabIndex = 13;
            this.toolTip.SetToolTip(this.buttSalvar, "Salvar");
            this.buttSalvar.UseVisualStyleBackColor = true;
            this.buttSalvar.Click += new System.EventHandler(this.buttSalvar_Click);
            // 
            // buttExcluir
            // 
            this.buttExcluir.BackgroundImage = global::CRUD_04.Properties.Resources.excluir_lix;
            this.buttExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttExcluir.Location = new System.Drawing.Point(749, 292);
            this.buttExcluir.Name = "buttExcluir";
            this.buttExcluir.Size = new System.Drawing.Size(75, 38);
            this.buttExcluir.TabIndex = 12;
            this.toolTip.SetToolTip(this.buttExcluir, "Excluir");
            this.buttExcluir.UseVisualStyleBackColor = true;
            this.buttExcluir.Click += new System.EventHandler(this.buttExcluir_Click);
            // 
            // buttAlterar
            // 
            this.buttAlterar.BackgroundImage = global::CRUD_04.Properties.Resources.Editar2;
            this.buttAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttAlterar.Location = new System.Drawing.Point(751, 238);
            this.buttAlterar.Name = "buttAlterar";
            this.buttAlterar.Size = new System.Drawing.Size(75, 34);
            this.buttAlterar.TabIndex = 11;
            this.toolTip.SetToolTip(this.buttAlterar, "Editar");
            this.buttAlterar.UseVisualStyleBackColor = true;
            this.buttAlterar.Click += new System.EventHandler(this.buttAlterar_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 495);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmUf);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mskCelular);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttCancelar);
            this.Controls.Add(this.buttSalvar);
            this.Controls.Add(this.buttExcluir);
            this.Controls.Add(this.dg_dados);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.buttAlterar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaCadastro";
            this.Text = "TelaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttAlterar;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.DataGridView dg_dados;
        private System.Windows.Forms.Button buttExcluir;
        private System.Windows.Forms.Button buttSalvar;
        private System.Windows.Forms.Button buttCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmUf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.ToolTip toolTip;
    }
}