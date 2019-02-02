using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionEstudiantes
{
    public partial class enrollStudent : Form
    {
        Form1 Principal;
        Form1.Student EstudianteActual = new Form1.Student();
        public enrollStudent(Form1 principal)
        {
            Principal = principal;
            InitializeComponent();
        }

        private void enrollStudent_Load(object sender, EventArgs e)
        {
            cmbCursosDisponibles.DataSource = Principal.root.asignaturas.Select(p => p.courseId).ToList();





        }

        private void btnValidateStudent_Click(object sender, EventArgs e)
        {
            Form1.Student AuxStudent = new Form1.Student();
            AuxStudent = Principal.Estudiantes.Where(p => p.DNI == txtDNIStudent.Text).FirstOrDefault();
            if (AuxStudent != null)
            {
                txtDisplayDNI.Text = AuxStudent.DNI;
                txtDisplayNombre.Text = AuxStudent.name;
                EstudianteActual = AuxStudent;

            }
            else
            {
                MessageBox.Show("el estudiante no exite");
                txtDNIStudent.Focus();
            }


        }

        private void btnEnrollstudent_Click(object sender, EventArgs e)
        {
            Form1.course AuxCurse = new Form1.course();

            AuxCurse = Principal.root.asignaturas.Where(p => p.courseId == cmbCursosDisponibles.SelectedItem.ToString()).FirstOrDefault();

            foreach (Form1.course curse in Principal.root.asignaturas)
            {
                if (curse.courseId == cmbCursosDisponibles.SelectedItem.ToString())
                {
                    curse.students.Add(EstudianteActual);
                    return;
                }
            }

            MessageBox.Show("estudiante inscrito");





        }

        private void btnListStudetsinCourse_Click(object sender, EventArgs e)
        {
            List<Form1.Student> AuxListaStudent = new List<Form1.Student>();
            foreach (Form1.course curso in Principal.root.asignaturas)
            {
                if (curso.courseId == cmbCursosDisponibles.SelectedItem.ToString())
                {

                    AuxListaStudent = curso.students;

                }
                else
                {
                    continue;
                }

            }
            dtgEstudiantesCourse.DataSource = AuxListaStudent.Select(p => new { DNI = p.DNI, NOMBRE = p.name }).ToList();
        }
    }

}

        
  
