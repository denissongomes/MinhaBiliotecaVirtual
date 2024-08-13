namespace MinhaBiliotecaVirtual
{
    partial class frmPrincipal
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
            this.dataGridViewLivros = new System.Windows.Forms.DataGridView();
            this.btnNovoForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLivros
            // 
            this.dataGridViewLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivros.Location = new System.Drawing.Point(8, 16);
            this.dataGridViewLivros.Name = "dataGridViewLivros";
            this.dataGridViewLivros.Size = new System.Drawing.Size(784, 360);
            this.dataGridViewLivros.TabIndex = 0;
            // 
            // btnNovoForm
            // 
            this.btnNovoForm.Location = new System.Drawing.Point(704, 400);
            this.btnNovoForm.Name = "btnNovoForm";
            this.btnNovoForm.Size = new System.Drawing.Size(75, 23);
            this.btnNovoForm.TabIndex = 1;
            this.btnNovoForm.Text = "Novo";
            this.btnNovoForm.UseVisualStyleBackColor = true;
            this.btnNovoForm.Click += new System.EventHandler(this.btnNovoForm_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovoForm);
            this.Controls.Add(this.dataGridViewLivros);
            this.Name = "frmPrincipal";
            this.Text = "Minha Bilioteca Virtual";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLivros;
        private System.Windows.Forms.Button btnNovoForm;
    }
}