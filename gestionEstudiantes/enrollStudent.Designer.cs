namespace gestionEstudiantes
{
    partial class enrollStudent
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
            this.txtDNIStudent = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDnistudent = new System.Windows.Forms.Label();
            this.btnValidateStudent = new System.Windows.Forms.Button();
            this.cmbCursosDisponibles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnrollstudent = new System.Windows.Forms.Button();
            this.txtDisplayDNI = new System.Windows.Forms.TextBox();
            this.txtDisplayNombre = new System.Windows.Forms.TextBox();
            this.dtgEstudiantesCourse = new System.Windows.Forms.DataGridView();
            this.btnListStudetsinCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiantesCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDNIStudent
            // 
            this.txtDNIStudent.Location = new System.Drawing.Point(12, 34);
            this.txtDNIStudent.Name = "txtDNIStudent";
            this.txtDNIStudent.Size = new System.Drawing.Size(100, 20);
            this.txtDNIStudent.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(29, 80);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(0, 13);
            this.lbNombre.TabIndex = 1;
            // 
            // lbDnistudent
            // 
            this.lbDnistudent.AutoSize = true;
            this.lbDnistudent.Location = new System.Drawing.Point(29, 121);
            this.lbDnistudent.Name = "lbDnistudent";
            this.lbDnistudent.Size = new System.Drawing.Size(0, 13);
            this.lbDnistudent.TabIndex = 2;
            // 
            // btnValidateStudent
            // 
            this.btnValidateStudent.Location = new System.Drawing.Point(118, 33);
            this.btnValidateStudent.Name = "btnValidateStudent";
            this.btnValidateStudent.Size = new System.Drawing.Size(21, 23);
            this.btnValidateStudent.TabIndex = 3;
            this.btnValidateStudent.Text = "V";
            this.btnValidateStudent.UseVisualStyleBackColor = true;
            this.btnValidateStudent.Click += new System.EventHandler(this.btnValidateStudent_Click);
            // 
            // cmbCursosDisponibles
            // 
            this.cmbCursosDisponibles.FormattingEnabled = true;
            this.cmbCursosDisponibles.Location = new System.Drawing.Point(154, 33);
            this.cmbCursosDisponibles.Name = "cmbCursosDisponibles";
            this.cmbCursosDisponibles.Size = new System.Drawing.Size(111, 21);
            this.cmbCursosDisponibles.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cursos";
            // 
            // btnEnrollstudent
            // 
            this.btnEnrollstudent.Location = new System.Drawing.Point(271, 31);
            this.btnEnrollstudent.Name = "btnEnrollstudent";
            this.btnEnrollstudent.Size = new System.Drawing.Size(49, 23);
            this.btnEnrollstudent.TabIndex = 6;
            this.btnEnrollstudent.Text = "incribir";
            this.btnEnrollstudent.UseVisualStyleBackColor = true;
            this.btnEnrollstudent.Click += new System.EventHandler(this.btnEnrollstudent_Click);
            // 
            // txtDisplayDNI
            // 
            this.txtDisplayDNI.Location = new System.Drawing.Point(13, 80);
            this.txtDisplayDNI.Name = "txtDisplayDNI";
            this.txtDisplayDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDisplayDNI.TabIndex = 7;
            // 
            // txtDisplayNombre
            // 
            this.txtDisplayNombre.Location = new System.Drawing.Point(12, 121);
            this.txtDisplayNombre.Name = "txtDisplayNombre";
            this.txtDisplayNombre.Size = new System.Drawing.Size(100, 20);
            this.txtDisplayNombre.TabIndex = 8;
            // 
            // dtgEstudiantesCourse
            // 
            this.dtgEstudiantesCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstudiantesCourse.Location = new System.Drawing.Point(150, 60);
            this.dtgEstudiantesCourse.Name = "dtgEstudiantesCourse";
            this.dtgEstudiantesCourse.Size = new System.Drawing.Size(170, 165);
            this.dtgEstudiantesCourse.TabIndex = 9;
            // 
            // btnListStudetsinCourse
            // 
            this.btnListStudetsinCourse.Location = new System.Drawing.Point(164, 231);
            this.btnListStudetsinCourse.Name = "btnListStudetsinCourse";
            this.btnListStudetsinCourse.Size = new System.Drawing.Size(156, 23);
            this.btnListStudetsinCourse.TabIndex = 10;
            this.btnListStudetsinCourse.Text = "Estudiantes x curso";
            this.btnListStudetsinCourse.UseVisualStyleBackColor = true;
            this.btnListStudetsinCourse.Click += new System.EventHandler(this.btnListStudetsinCourse_Click);
            // 
            // enrollStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 261);
            this.Controls.Add(this.btnListStudetsinCourse);
            this.Controls.Add(this.dtgEstudiantesCourse);
            this.Controls.Add(this.txtDisplayNombre);
            this.Controls.Add(this.txtDisplayDNI);
            this.Controls.Add(this.btnEnrollstudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCursosDisponibles);
            this.Controls.Add(this.btnValidateStudent);
            this.Controls.Add(this.lbDnistudent);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtDNIStudent);
            this.Name = "enrollStudent";
            this.Text = "enrollStudent";
            this.Load += new System.EventHandler(this.enrollStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstudiantesCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNIStudent;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDnistudent;
        private System.Windows.Forms.Button btnValidateStudent;
        private System.Windows.Forms.ComboBox cmbCursosDisponibles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnrollstudent;
        private System.Windows.Forms.TextBox txtDisplayDNI;
        private System.Windows.Forms.TextBox txtDisplayNombre;
        private System.Windows.Forms.DataGridView dtgEstudiantesCourse;
        private System.Windows.Forms.Button btnListStudetsinCourse;
    }
}