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
    public partial class AddStudentForm : Form
    {
        Form1 Principal;
        public AddStudentForm(Form1 principal)
        {
            Principal = principal;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgListStudent.DataSource = Principal.Estudiantes.Select(p => new {DNI = p.DNI, Nombre = p.name }).ToList();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Form1.Student AuxStudent = new Form1.Student();
            AuxStudent.DNI = txtDNIstudent.Text;
            AuxStudent.name = txtNameStudent.Text;
            Principal.Estudiantes.Add(AuxStudent);

        }
    }
}
