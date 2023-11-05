using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class FrmNuevaMat : Form
    {
        Alumno alumno = new Alumno();

        public FrmNuevaMat()
        {
            InitializeComponent();
        }

        private void FrmNuevaMat_Load(object sender, EventArgs e)
        {
            
            //nac alumno
            cmbAlumNac.DataSource = alumno.dtNacionalidades();
            cmbAlumNac.DisplayMember = "Nacionalidad_Categoria";
            cmbAlumNac.ValueMember = "Id";
            //nac tutor
            cmbTutorNac.DataSource = alumno.dtNacionalidades();
            cmbTutorNac.DisplayMember = "Nacionalidad_Categoria";
            cmbTutorNac.ValueMember = "Id";
            //sexo alum
            cmbAlumSexo.DataSource = alumno.dtSexo();
            cmbAlumSexo.DisplayMember = "Sexo_Categoria";
            cmbAlumSexo.ValueMember = "Id";
            //profesion tutor 
            cmbTurorProfesion.DataSource = alumno.dtProfesion();
            cmbTurorProfesion.DisplayMember = "Profesion_Categoria";
            cmbTurorProfesion.ValueMember = "Id";
            //alum categoria
            cmbAlumCategoria.DataSource = alumno.dtCategoria();
            cmbAlumCategoria.DisplayMember = "Categoria_Nombre";
            cmbAlumCategoria.ValueMember = "Id";
            //alum grado
            cmbAlumCaracteriz.DataSource = alumno.dtCaracterizacion();
            cmbAlumCaracteriz.DisplayMember = "Caracterizacion_Nombre";
            cmbAlumCaracteriz.ValueMember = "Id";
            //alum carcterizacion
            cmbAlumTurno.DataSource = alumno.dtTurno();
            cmbAlumTurno.DisplayMember = "Turno_Nombre";
            cmbAlumTurno.ValueMember = "Id";
            //Provincia
            cmbProvincia.DataSource = alumno.dtProvincia();
            cmbProvincia.DisplayMember = "Prov_Nom";
            cmbProvincia.ValueMember = "Id";
            

        }




        private void chkProcedencia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProcedencia.Checked){ grupOtraEscuela.Enabled = false; }
            else { grupOtraEscuela.Enabled = true;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                        //*****ALUMNO******
            string alumNombre = txtAlumNombre.Text;
            string alumApellido = txtAlumApellido.Text;
            int alumDNI = 33333333;
            string fechaNacim = Convert.ToString(dtTimeNacimiento.Value);
            int alumSexo = Convert.ToInt32(cmbAlumSexo.SelectedValue);
            int alumNacionalidad = Convert.ToInt32(cmbAlumNac.SelectedValue);
            int alumCaracterizacion = Convert.ToInt32(cmbAlumCaracteriz.SelectedValue);
            int alumCategoria = Convert.ToInt32(cmbAlumCategoria.SelectedValue);
            int alumTurno = Convert.ToInt32(cmbAlumTurno.SelectedValue);
            
            //*****TUTOR******
            string tutorNombre=txtTutorNombre.Text;
            string tutorApellido=txtAlumApellido.Text;
            int tutorDNI = Convert.ToInt32(txtTutorDNI.Text);
            int tutorNacionalidad = Convert.ToInt32(cmbTutorNac.SelectedValue);
            int tutorProfesion = Convert.ToInt32(cmbTurorProfesion.SelectedValue);
            int tutorLocalidad = Convert.ToInt32(cmbPartido.SelectedValue);
            string tutorDireccion= txtTutorDomicilio.Text;
            int tutorTelefono = Convert.ToInt32(txtTutorTelefono.Text);
                          


            //GUARDA ALUMNO          
            bool alumnoGuardado = alumno.guardaAlumno(alumNombre, alumApellido, alumDNI, fechaNacim, alumSexo, alumNacionalidad, alumCaracterizacion, alumCategoria, alumTurno);
            if (alumnoGuardado) { MessageBox.Show("sep"); } else { MessageBox.Show("none"); }
            //GUARDATUTOR
            bool tutorGuardado = alumno.guardaTutor(tutorNombre, tutorApellido, tutorDNI, tutorNacionalidad, tutorProfesion, tutorLocalidad, tutorDireccion, tutorTelefono);
            if (tutorGuardado) { MessageBox.Show("sep"); } else { MessageBox.Show("none"); }


        }

        

        private void cmbProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(cmbProvincia.SelectedValue));

            string provincia = Convert.ToString(cmbProvincia.SelectedValue);
            cmbPartido.DataSource = alumno.dtLocalidades(1);
            cmbPartido.DisplayMember = "Localidad_Nombre";
            cmbPartido.ValueMember = "Id";
        }












    }
}
