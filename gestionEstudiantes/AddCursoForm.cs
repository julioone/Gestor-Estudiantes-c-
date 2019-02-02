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
    public partial class AddCursoForm : Form
    {
        Form1 Principal;
        public AddCursoForm(Form1 principal)
        {
            Principal = principal;
            InitializeComponent();
        }
        

        private void btnSavecourse_Click(object sender, EventArgs e)
        {
            Form1.course Auxcurse = new Form1.course();
            Auxcurse.courseId = txtIDcourse.Text;
            Auxcurse.creditos = int.Parse(txtCreditos.Text);
            Principal.root.asignaturas.Add(Auxcurse);
            MessageBox.Show("Curso agregado");
            
            
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtgListacurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListcourse_Click(object sender, EventArgs e)
        {
            dtgListacurso.DataSource = Principal.root.asignaturas.Select(p=> new {Codigo = p.courseId,Creditos= p.creditos}).ToList();
        }

        private void btnExitAddCourseForm_Click(object sender, EventArgs e)
        {

            

        }
    }
}
