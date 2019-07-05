namespace CRUD_03 {
    partial class TelaPrincipal {
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
            this.buttCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttCliente
            // 
            this.buttCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttCliente.Location = new System.Drawing.Point(196, 115);
            this.buttCliente.Name = "buttCliente";
            this.buttCliente.Size = new System.Drawing.Size(127, 36);
            this.buttCliente.TabIndex = 11;
            this.buttCliente.Text = "Cliente";
            this.buttCliente.UseVisualStyleBackColor = false;
            this.buttCliente.Click += new System.EventHandler(this.buttCliente_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 284);
            this.Controls.Add(this.buttCliente);
            this.MaximizeBox = false;
            this.Name = "FrmCliente";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttCliente;
    }
}

