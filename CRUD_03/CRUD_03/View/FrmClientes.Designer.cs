namespace CRUD_03.View {
    partial class FrmClientes {
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
            this.label1 = new System.Windows.Forms.Label();
            this.textCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.buttNovo = new System.Windows.Forms.Button();
            this.buttEditar = new System.Windows.Forms.Button();
            this.buttSalvar = new System.Windows.Forms.Button();
            this.buttExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código: ";
            // 
            // textCod
            // 
            this.textCod.Location = new System.Drawing.Point(55, 34);
            this.textCod.Name = "textCod";
            this.textCod.ReadOnly = true;
            this.textCod.Size = new System.Drawing.Size(76, 20);
            this.textCod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Cliente:";
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(260, 30);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(434, 20);
            this.textCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nascimento: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(55, 81);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 7;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(1, 108);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(708, 290);
            this.Grid.TabIndex = 8;
            // 
            // buttNovo
            // 
            this.buttNovo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttNovo.Location = new System.Drawing.Point(150, 404);
            this.buttNovo.Name = "buttNovo";
            this.buttNovo.Size = new System.Drawing.Size(75, 34);
            this.buttNovo.TabIndex = 9;
            this.buttNovo.Text = "Novo";
            this.buttNovo.UseVisualStyleBackColor = false;
            // 
            // buttEditar
            // 
            this.buttEditar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttEditar.Location = new System.Drawing.Point(348, 404);
            this.buttEditar.Name = "buttEditar";
            this.buttEditar.Size = new System.Drawing.Size(75, 34);
            this.buttEditar.TabIndex = 10;
            this.buttEditar.Text = "Editar";
            this.buttEditar.UseVisualStyleBackColor = false;
            // 
            // buttSalvar
            // 
            this.buttSalvar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttSalvar.Location = new System.Drawing.Point(246, 404);
            this.buttSalvar.Name = "buttSalvar";
            this.buttSalvar.Size = new System.Drawing.Size(75, 34);
            this.buttSalvar.TabIndex = 11;
            this.buttSalvar.Text = "Salvar";
            this.buttSalvar.UseVisualStyleBackColor = false;
            // 
            // buttExcluir
            // 
            this.buttExcluir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttExcluir.Location = new System.Drawing.Point(454, 404);
            this.buttExcluir.Name = "buttExcluir";
            this.buttExcluir.Size = new System.Drawing.Size(75, 34);
            this.buttExcluir.TabIndex = 12;
            this.buttExcluir.Text = "Excluir";
            this.buttExcluir.UseVisualStyleBackColor = false;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.buttExcluir);
            this.Controls.Add(this.buttSalvar);
            this.Controls.Add(this.buttEditar);
            this.Controls.Add(this.buttNovo);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCod);
            this.Controls.Add(this.label1);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button buttNovo;
        private System.Windows.Forms.Button buttEditar;
        private System.Windows.Forms.Button buttSalvar;
        private System.Windows.Forms.Button buttExcluir;
    }
}