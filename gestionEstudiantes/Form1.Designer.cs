namespace gestionEstudiantes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearStudent = new System.Windows.Forms.Button();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.btnIncriStudent = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDigitNotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearStudent
            // 
            this.btnCrearStudent.Location = new System.Drawing.Point(60, 33);
            this.btnCrearStudent.Name = "btnCrearStudent";
            this.btnCrearStudent.Size = new System.Drawing.Size(75, 36);
            this.btnCrearStudent.TabIndex = 0;
            this.btnCrearStudent.Text = "Crear estudiante";
            this.btnCrearStudent.UseVisualStyleBackColor = true;
            this.btnCrearStudent.Click += new System.EventHandler(this.btnCrearStudent_Click);
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.Location = new System.Drawing.Point(60, 75);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(75, 23);
            this.btnCrearCurso.TabIndex = 1;
            this.btnCrearCurso.Text = "Crear curso";
            this.btnCrearCurso.UseVisualStyleBackColor = true;
            this.btnCrearCurso.Click += new System.EventHandler(this.btnCrearCurso_Click);
            // 
            // btnIncriStudent
            // 
            this.btnIncriStudent.Location = new System.Drawing.Point(60, 117);
            this.btnIncriStudent.Name = "btnIncriStudent";
            this.btnIncriStudent.Size = new System.Drawing.Size(75, 35);
            this.btnIncriStudent.TabIndex = 2;
            this.btnIncriStudent.Text = "Incribir estudiante";
            this.btnIncriStudent.UseVisualStyleBackColor = true;
            this.btnIncriStudent.Click += new System.EventHandler(this.btnIncriStudent_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(60, 215);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDigitNotes
            // 
            this.btnDigitNotes.Location = new System.Drawing.Point(60, 172);
            this.btnDigitNotes.Name = "btnDigitNotes";
            this.btnDigitNotes.Size = new System.Drawing.Size(75, 23);
            this.btnDigitNotes.TabIndex = 4;
            this.btnDigitNotes.Text = "DigitarNotas";
            this.btnDigitNotes.UseVisualStyleBackColor = true;
            this.btnDigitNotes.Click += new System.EventHandler(this.btnDigitNotes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 261);
            this.Controls.Add(this.btnDigitNotes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIncriStudent);
            this.Controls.Add(this.btnCrearCurso);
            this.Controls.Add(this.btnCrearStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearStudent;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.Button btnIncriStudent;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDigitNotes;
    }
}

