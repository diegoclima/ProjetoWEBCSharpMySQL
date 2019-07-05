namespace CRUD_06 {
    partial class Validacao {
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
            this.label1 = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.buttSair = new System.Windows.Forms.Button();
            this.buttLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(2, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUÁRIO:";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(98, 38);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(167, 20);
            this.textUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(2, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "SENHA :";
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(98, 80);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(167, 20);
            this.textSenha.TabIndex = 3;
            // 
            // buttSair
            // 
            this.buttSair.Location = new System.Drawing.Point(98, 132);
            this.buttSair.Name = "buttSair";
            this.buttSair.Size = new System.Drawing.Size(75, 23);
            this.buttSair.TabIndex = 4;
            this.buttSair.Text = "SAIR";
            this.buttSair.UseVisualStyleBackColor = true;
            this.buttSair.Click += new System.EventHandler(this.buttSair_Click);
            // 
            // buttLogin
            // 
            this.buttLogin.Location = new System.Drawing.Point(190, 132);
            this.buttLogin.Name = "buttLogin";
            this.buttLogin.Size = new System.Drawing.Size(75, 23);
            this.buttLogin.TabIndex = 5;
            this.buttLogin.Text = "LOGIN";
            this.buttLogin.UseVisualStyleBackColor = true;
            this.buttLogin.Click += new System.EventHandler(this.buttLogin_Click);
            // 
            // Validacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 185);
            this.Controls.Add(this.buttLogin);
            this.Controls.Add(this.buttSair);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Validacao";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Button buttSair;
        private System.Windows.Forms.Button buttLogin;
    }
}

