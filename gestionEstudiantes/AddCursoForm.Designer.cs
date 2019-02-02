namespace gestionEstudiantes
{
    partial class AddCursoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.txtIDcourse = new System.Windows.Forms.TextBox();
            this.btnSavecourse = new System.Windows.Forms.Button();
            this.btnListcourse = new System.Windows.Forms.Button();
            this.dtgListacurso = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListacurso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREAR CURSO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Creditos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo curso";
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(118, 67);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(100, 20);
            this.txtCreditos.TabIndex = 3;
            // 
            // txtIDcourse
            // 
            this.txtIDcourse.Location = new System.Drawing.Point(118, 41);
            this.txtIDcourse.Name = "txtIDcourse";
            this.txtIDcourse.Size = new System.Drawing.Size(100, 20);
            this.txtIDcourse.TabIndex = 4;
            // 
            // btnSavecourse
            // 
            this.btnSavecourse.Location = new System.Drawing.Point(39, 103);
            this.btnSavecourse.Name = "btnSavecourse";
            this.btnSavecourse.Size = new System.Drawing.Size(75, 23);
            this.btnSavecourse.TabIndex = 5;
            this.btnSavecourse.Text = "Guardar";
            this.btnSavecourse.UseVisualStyleBackColor = true;
            this.btnSavecourse.Click += new System.EventHandler(this.btnSavecourse_Click);
            // 
            // btnListcourse
            // 
            this.btnListcourse.Location = new System.Drawing.Point(143, 103);
            this.btnListcourse.Name = "btnListcourse";
            this.btnListcourse.Size = new System.Drawing.Size(75, 23);
            this.btnListcourse.TabIndex = 7;
            this.btnListcourse.Text = "Listar";
            this.btnListcourse.UseVisualStyleBackColor = true;
            this.btnListcourse.Click += new System.EventHandler(this.btnListcourse_Click);
            // 
            // dtgListacurso
            // 
            this.dtgListacurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListacurso.Location = new System.Drawing.Point(1, 145);
            this.dtgListacurso.Name = "dtgListacurso";
            this.dtgListacurso.Size = new System.Drawing.Size(271, 104);
            this.dtgListacurso.TabIndex = 8;
            this.dtgListacurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListacurso_CellContentClick);
            // 
            // AddCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dtgListacurso);
            this.Controls.Add(this.btnListcourse);
            this.Controls.Add(this.btnSavecourse);
            this.Controls.Add(this.txtIDcourse);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCursoForm";
            this.Text = "AddCursoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgListacurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.TextBox txtIDcourse;
        private System.Windows.Forms.Button btnSavecourse;
        private System.Windows.Forms.Button btnListcourse;
        private System.Windows.Forms.DataGridView dtgListacurso;
    }
}