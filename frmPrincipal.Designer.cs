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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.dataGridViewLivros = new System.Windows.Forms.DataGridView();
            this.btnAbrirFrmEditar = new System.Windows.Forms.Button();
            this.btnAbrirFrmNovo = new System.Windows.Forms.Button();
            this.btnDeletarLivro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLivros
            // 
            this.dataGridViewLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLivros.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLivros.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLivros.Name = "dataGridViewLivros";
            this.dataGridViewLivros.Size = new System.Drawing.Size(800, 464);
            this.dataGridViewLivros.TabIndex = 0;
            // 
            // btnAbrirFrmEditar
            // 
            this.btnAbrirFrmEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAbrirFrmEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFrmEditar.ForeColor = System.Drawing.Color.White;
            this.btnAbrirFrmEditar.Location = new System.Drawing.Point(632, 472);
            this.btnAbrirFrmEditar.Name = "btnAbrirFrmEditar";
            this.btnAbrirFrmEditar.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirFrmEditar.TabIndex = 1;
            this.btnAbrirFrmEditar.Text = "Editar";
            this.btnAbrirFrmEditar.UseVisualStyleBackColor = false;
            this.btnAbrirFrmEditar.Click += new System.EventHandler(this.btnAbrirFrmEditar_Click);
            // 
            // btnAbrirFrmNovo
            // 
            this.btnAbrirFrmNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAbrirFrmNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirFrmNovo.ForeColor = System.Drawing.Color.White;
            this.btnAbrirFrmNovo.Location = new System.Drawing.Point(544, 472);
            this.btnAbrirFrmNovo.Name = "btnAbrirFrmNovo";
            this.btnAbrirFrmNovo.Size = new System.Drawing.Size(75, 24);
            this.btnAbrirFrmNovo.TabIndex = 0;
            this.btnAbrirFrmNovo.Text = "Novo";
            this.btnAbrirFrmNovo.UseVisualStyleBackColor = false;
            this.btnAbrirFrmNovo.Click += new System.EventHandler(this.btnAbrirFrmNovo_Click);
            // 
            // btnDeletarLivro
            // 
            this.btnDeletarLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDeletarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarLivro.ForeColor = System.Drawing.Color.White;
            this.btnDeletarLivro.Location = new System.Drawing.Point(720, 472);
            this.btnDeletarLivro.Name = "btnDeletarLivro";
            this.btnDeletarLivro.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarLivro.TabIndex = 2;
            this.btnDeletarLivro.Text = "Deletar";
            this.btnDeletarLivro.UseVisualStyleBackColor = false;
            this.btnDeletarLivro.Click += new System.EventHandler(this.btnDeletarLivro_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.btnDeletarLivro);
            this.Controls.Add(this.btnAbrirFrmNovo);
            this.Controls.Add(this.btnAbrirFrmEditar);
            this.Controls.Add(this.dataGridViewLivros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minha Biblioteca Virtual";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLivros;
        private System.Windows.Forms.Button btnAbrirFrmEditar;
        private System.Windows.Forms.Button btnAbrirFrmNovo;
        private System.Windows.Forms.Button btnDeletarLivro;
    }
}