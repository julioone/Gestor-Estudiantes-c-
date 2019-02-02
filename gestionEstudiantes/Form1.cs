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
    public partial class Form1 : Form
    {
        DataTable studentTable = new DataTable();
        
       
        public carrera root = new carrera("Ing sistemas");
        public List<Student> Estudiantes = new List<Student>();

        public class note
        {
            public double valor  { get; set; }
        }
        public class course
        {
            public course()
            {

                this.students = new List<Student>();
            }
            public string courseId { get; set; }
            public int creditos { get; set; }
            public List<Student> students { get; set; }
        }
        public class carrera
        {
            //constructor carrera
            public carrera(string name)
            {
                this.nombre = name;
                this.asignaturas = new List<course>();

            }

            public string nombre { get; set; }
            public List<course> asignaturas { get; set; }
        }
        public class Student
        {
            public Student()
            {

                this.ratings = new List<note>();
            }
            public string DNI { get; set; }
            public string name { get; set; }

            public List<note> ratings { get; set; }
            public double promedio { get { return (calprom(ratings)); } }


            private double calprom(List<note> ratings)
            {
                double promedio = 0.0;
                double cant = 0.0;
                foreach (note nota in ratings)
                {
                    promedio = +nota.valor;
                    cant++;
                }


                return (promedio / cant);

            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addstudent = new AddStudentForm(this);
            addstudent.Show();
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            AddCursoForm addcurso = new AddCursoForm(this);
            addcurso.Show();
            
            
            

        }

        private void btnIncriStudent_Click(object sender, EventArgs e)
        {
            enrollStudent incripcionEstudiante = new enrollStudent(this);
            incripcionEstudiante.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDigitNotes_Click(object sender, EventArgs e)
        {
            DigitarNotasForm digitarnota = new DigitarNotasForm(this);
            digitarnota.Show();

        }
    }
}
