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
            //admicion categoria
            cmbAdmiCategoria.DataSource = alumno.dtCategoria();
            cmbAdmiCategoria.DisplayMember = "Categoria_Nombre";
            cmbAdmiCategoria.ValueMember = "Id";
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
            //Localidad Escuela
            cmbDistritoEsc.DataSource = alumno.dtLocalidades(1);
            cmbDistritoEsc.DisplayMember = "Localidad_Nombre";
            cmbDistritoEsc.ValueMember = "Id";

        }




        private void chkProcedencia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProcedencia.Checked) { grupOtraEscuela.Enabled = false; }
            else
            {
                grupOtraEscuela.Enabled = true;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //*****ALUMNO******
            string alumNombre = txtAlumNombre.Text;
            string alumApellido = txtAlumApellido.Text;
            int alumDNI = Convert.ToInt32(txtAlumDNI.Text);
            string fechaNacim = Convert.ToString(dtTimeNacimiento.Value);
            int alumSexo = Convert.ToInt32(cmbAlumSexo.SelectedValue);
            int alumNacionalidad = Convert.ToInt32(cmbAlumNac.SelectedValue);
            int alumCaracterizacion = Convert.ToInt32(cmbAlumCaracteriz.SelectedValue);
            int alumCategoria = Convert.ToInt32(cmbAlumCategoria.SelectedValue);
            int alumTurno = Convert.ToInt32(cmbAlumTurno.SelectedValue);
            //******* OBSERVACIONES ********
            int lenguaEx = Convert.ToInt32(chkObsLengua.Checked);
            int contexEncierro = Convert.ToInt32(chkObsEncierro.Checked);
            int originario = Convert.ToInt32(chkObsOriginario.Checked);
            int benefSocial = Convert.ToInt32(chkObsBeneficio.Checked);
            int cud = Convert.ToInt32(chkObsCUD.Checked);
            int medicacion = Convert.ToInt32(chkObsMedicacion.Checked);
            int vulneracion = Convert.ToInt32(chkObsDerechos.Checked);
            int parto = Convert.ToInt32(chkObsParto.Checked);
            string observa = txtObservaciones.Text;

            //*****TUTOR******
            string tutorNombre = txtTutorNombre.Text;
            string tutorApellido = txtTutorApellido.Text;
            int tutorDNI = Convert.ToInt32(txtTutorDNI.Text);
            int tutorNacionalidad = Convert.ToInt32(cmbTutorNac.SelectedValue);
            int tutorProfesion = Convert.ToInt32(cmbTurorProfesion.SelectedValue);
            int tutorLocalidad = Convert.ToInt32(cmbPartido.SelectedValue);
            string tutorDireccion = txtTutorDomicilio.Text;
            int tutorTelefono = Convert.ToInt32(txtTutorTelefono.Text);
            //*********INGRESO*********
            int admisionEscCat = Convert.ToInt32(cmbAdmiCategoria.SelectedValue);
            string admisionFecha = Convert.ToString(dtTimeIngreso.Value);
            bool admisionMismaEsc = chkProcedencia.Checked;
            //************ESCUELA************
            int escuelaDistrito = Convert.ToInt32(cmbDistritoEsc.SelectedValue);
            int escuelaNumero = admisionMismaEsc ? 0 : Convert.ToInt32(txtEscNumero.Text);
            int escuyelaNacion = rbProvincia.Checked ? 1 : 0;
            int escuelaProvincia = rbProvincia.Checked ? 1 : 0;
            int escuelaPrivada = rbPrivada.Checked ? 1 : 0;


            //GUARDA TUTOR
            bool tutorGuardado = alumno.guardaTutor(tutorNombre, tutorApellido, tutorDNI, tutorNacionalidad, tutorProfesion, tutorLocalidad, tutorDireccion, tutorTelefono);
            //if (tutorGuardado) { MessageBox.Show("sep"); } else { MessageBox.Show("none"); }

            //GUARDA ALUMNO          
            bool alumnoGuardado = alumno.guardaAlumno(alumNombre, alumApellido, alumDNI, fechaNacim, alumSexo, alumNacionalidad, alumCaracterizacion, alumCategoria, alumTurno, lenguaEx, contexEncierro, originario, benefSocial, cud, medicacion, vulneracion, parto, observa);
            if (alumnoGuardado) { MessageBox.Show("sep"); } else { MessageBox.Show("none"); }

            //GUARDA ESCUELA
            if (!admisionMismaEsc)
            {


                bool escuelaGuardado = alumno.guardaEscuela(escuelaDistrito, escuelaNumero, escuyelaNacion, escuelaProvincia, escuelaPrivada);
                if (escuelaGuardado) { MessageBox.Show("sep"); } else { MessageBox.Show("none"); }
            }
            //GUARDA INGRESO
            bool admiGuardado = alumno.guardaAdmision(admisionEscCat, admisionFecha, admisionMismaEsc);
            if (admiGuardado) { MessageBox.Show("sep"); } else { MessageBox.Show("none"); }
        }



        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProvincia_SelectedValueChanged(object sender, EventArgs e)
        {

            string provincia = Convert.ToString(cmbProvincia.SelectedValue);
            try
            {
                int idProv = Convert.ToInt32(provincia);
                cmbPartido.DataSource = alumno.dtLocalidades(idProv);
                cmbPartido.DisplayMember = "Localidad_Nombre";
                cmbPartido.ValueMember = "Id";
                //MessageBox.Show(Convert.ToString(provincia) + " SEP ");
            }
            catch { }


        }












    }
}
