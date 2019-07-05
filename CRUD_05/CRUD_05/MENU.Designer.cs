namespace CRUD_05 {
    partial class MENU {
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
            this.buttAluno = new System.Windows.Forms.Button();
            this.buttCurso = new System.Windows.Forms.Button();
            this.buttProf = new System.Windows.Forms.Button();
            this.buttSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU: ";
            // 
            // buttAluno
            // 
            this.buttAluno.Location = new System.Drawing.Point(101, 67);
            this.buttAluno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttAluno.Name = "buttAluno";
            this.buttAluno.Size = new System.Drawing.Size(127, 35);
            this.buttAluno.TabIndex = 2;
            this.buttAluno.Text = "ALUNO";
            this.buttAluno.UseVisualStyleBackColor = true;
            this.buttAluno.Click += new System.EventHandler(this.buttAluno_Click);
            // 
            // buttCurso
            // 
            this.buttCurso.Location = new System.Drawing.Point(101, 14);
            this.buttCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttCurso.Name = "buttCurso";
            this.buttCurso.Size = new System.Drawing.Size(127, 35);
            this.buttCurso.TabIndex = 1;
            this.buttCurso.Text = "CURSO";
            this.buttCurso.UseVisualStyleBackColor = true;
            this.buttCurso.Click += new System.EventHandler(this.buttCurso_Click);
            // 
            // buttProf
            // 
            this.buttProf.Location = new System.Drawing.Point(101, 129);
            this.buttProf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttProf.Name = "buttProf";
            this.buttProf.Size = new System.Drawing.Size(127, 35);
            this.buttProf.TabIndex = 3;
            this.buttProf.Text = "PROFESSOR";
            this.buttProf.UseVisualStyleBackColor = true;
            this.buttProf.Click += new System.EventHandler(this.buttProf_Click);
            // 
            // buttSair
            // 
            this.buttSair.Location = new System.Drawing.Point(101, 192);
            this.buttSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttSair.Name = "buttSair";
            this.buttSair.Size = new System.Drawing.Size(127, 35);
            this.buttSair.TabIndex = 4;
            this.buttSair.Text = "SAIR";
            this.buttSair.UseVisualStyleBackColor = true;
            this.buttSair.Click += new System.EventHandler(this.buttSair_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 300);
            this.Controls.Add(this.buttSair);
            this.Controls.Add(this.buttCurso);
            this.Controls.Add(this.buttProf);
            this.Controls.Add(this.buttAluno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MENU";
            this.Text = "MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttAluno;
        private System.Windows.Forms.Button buttProf;
        private System.Windows.Forms.Button buttCurso;
        private System.Windows.Forms.Button buttSair;
    }
}