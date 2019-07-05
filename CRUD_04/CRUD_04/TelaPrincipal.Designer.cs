namespace CRUD_04 {
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
            this.buttIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttIniciar
            // 
            this.buttIniciar.Location = new System.Drawing.Point(159, 41);
            this.buttIniciar.Name = "buttIniciar";
            this.buttIniciar.Size = new System.Drawing.Size(141, 54);
            this.buttIniciar.TabIndex = 0;
            this.buttIniciar.Text = "Iniciar";
            this.buttIniciar.UseVisualStyleBackColor = true;
            this.buttIniciar.Click += new System.EventHandler(this.buttIniciar_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 151);
            this.Controls.Add(this.buttIniciar);
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.Text = "TelaInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttIniciar;
    }
}

