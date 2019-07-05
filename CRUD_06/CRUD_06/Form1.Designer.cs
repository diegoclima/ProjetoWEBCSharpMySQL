namespace CRUD_06 {
    partial class Form1 {
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttEditar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDisc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_dados = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.buttSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "ID Pesquisa";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(507, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 20);
            this.textBox3.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 44);
            this.button2.TabIndex = 26;
            this.button2.Text = "PESQUISAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttEditar
            // 
            this.buttEditar.Location = new System.Drawing.Point(19, 38);
            this.buttEditar.Name = "buttEditar";
            this.buttEditar.Size = new System.Drawing.Size(101, 44);
            this.buttEditar.TabIndex = 24;
            this.buttEditar.Text = "EDITAR";
            this.buttEditar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-40, -67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(579, 20);
            this.textBox2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-101, -67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, -96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(579, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, -93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nome : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-101, -25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Disciplina :";
            // 
            // cmbDisc
            // 
            this.cmbDisc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisc.FormattingEnabled = true;
            this.cmbDisc.Items.AddRange(new object[] {
            "AED",
            "POO",
            "FUND. MATEMÁTICOS",
            "INT. À PESQUISA EM INFO",
            "LABORATORIO",
            "FILOSOFIA",
            "BANCO DE DADOS"});
            this.cmbDisc.Location = new System.Drawing.Point(-40, -25);
            this.cmbDisc.Name = "cmbDisc";
            this.cmbDisc.Size = new System.Drawing.Size(579, 21);
            this.cmbDisc.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-101, -96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID usuário";
            // 
            // dg_dados
            // 
            this.dg_dados.AllowUserToAddRows = false;
            this.dg_dados.AllowUserToDeleteRows = false;
            this.dg_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dados.Location = new System.Drawing.Point(-88, 88);
            this.dg_dados.Name = "dg_dados";
            this.dg_dados.ReadOnly = true;
            this.dg_dados.Size = new System.Drawing.Size(901, 290);
            this.dg_dados.TabIndex = 17;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(-40, -99);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(80, 20);
            this.txtID.TabIndex = 15;
            // 
            // buttSalvar
            // 
            this.buttSalvar.Location = new System.Drawing.Point(-88, 38);
            this.buttSalvar.Name = "buttSalvar";
            this.buttSalvar.Size = new System.Drawing.Size(101, 44);
            this.buttSalvar.TabIndex = 14;
            this.buttSalvar.Text = "SALVAR";
            this.buttSalvar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 279);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttEditar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDisc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_dados);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.buttSalvar);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.dg_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttEditar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDisc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_dados;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button buttSalvar;
    }
}