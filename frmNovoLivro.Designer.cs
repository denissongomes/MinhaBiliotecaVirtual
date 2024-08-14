namespace MinhaBiliotecaVirtual
{
    partial class frmNovoLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditoraNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAutorNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCategoriaNome = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(24, 40);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(360, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Título:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISBN:";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(24, 88);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(360, 20);
            this.txtIsbn.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Editora";
            // 
            // txtEditoraNome
            // 
            this.txtEditoraNome.Location = new System.Drawing.Point(24, 136);
            this.txtEditoraNome.Name = "txtEditoraNome";
            this.txtEditoraNome.Size = new System.Drawing.Size(360, 20);
            this.txtEditoraNome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Autor:";
            // 
            // txtAutorNome
            // 
            this.txtAutorNome.Location = new System.Drawing.Point(24, 184);
            this.txtAutorNome.Name = "txtAutorNome";
            this.txtAutorNome.Size = new System.Drawing.Size(360, 20);
            this.txtAutorNome.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria:";
            // 
            // txtCategoriaNome
            // 
            this.txtCategoriaNome.Location = new System.Drawing.Point(24, 232);
            this.txtCategoriaNome.Name = "txtCategoriaNome";
            this.txtCategoriaNome.Size = new System.Drawing.Size(360, 20);
            this.txtCategoriaNome.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(312, 296);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(224, 296);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmNovoLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(406, 339);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCategoriaNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAutorNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEditoraNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNovoLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo Livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditoraNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAutorNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCategoriaNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
    }
}