namespace Bd_Teste_01 {
    partial class Form1 {
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
            this.but_Salvar = new System.Windows.Forms.Button();
            this.but_abrir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Salvar
            // 
            this.but_Salvar.Location = new System.Drawing.Point(3, 219);
            this.but_Salvar.Name = "but_Salvar";
            this.but_Salvar.Size = new System.Drawing.Size(694, 23);
            this.but_Salvar.TabIndex = 0;
            this.but_Salvar.Text = "Salvar";
            this.but_Salvar.UseVisualStyleBackColor = true;
            // 
            // but_abrir
            // 
            this.but_abrir.Location = new System.Drawing.Point(3, 257);
            this.but_abrir.Name = "but_abrir";
            this.but_abrir.Size = new System.Drawing.Size(694, 23);
            this.but_abrir.TabIndex = 2;
            this.but_abrir.Text = "Abrir";
            this.but_abrir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(691, 212);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.but_abrir);
            this.Controls.Add(this.but_Salvar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_Salvar;
        private System.Windows.Forms.Button but_abrir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

