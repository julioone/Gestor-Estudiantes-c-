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
    
    public partial class DigitarNotasForm : Form
    {
        
        Form1 Principal;
        List<Form1.Student> AuxStudents;
        public DigitarNotasForm(Form1 principal)
        {
            Principal = principal;
            InitializeComponent();
        }

        private void dtgNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            dtgNotas.Rows.Clear();
            foreach (Form1.course curso in Principal.root.asignaturas)
            {
                if (curso.courseId == cmbCursos.SelectedItem.ToString())
                {
                    int indf = 0;
                    
                    foreach (Form1.Student student in curso.students)
                    {
                        List<Form1.note> Auxnotas = new List<Form1.note>(3);
                        if (student.ratings.Count == 0)
                        {
                            
                            foreach (Form1.note nota in student.ratings)
                            {



                            }
                        }
                        
                        dtgNotas.Rows.Insert(indf, student.DNI, student.name, Auxnotas[0].valor, Auxnotas[1].valor,Auxnotas[2].valor,Auxnotas[3].valor, student.promedio);
                        indf++;
                        
                        
                        

                    }

                }
                else
                    continue;
            }
        }

        private void cmbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DigitarNotasForm_Load(object sender, EventArgs e)
        {
            cmbCursos.DataSource = Principal.root.asignaturas.Select(p => p.courseId).ToList();
        }
    }
}
