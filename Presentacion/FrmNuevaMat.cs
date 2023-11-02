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
            string alumNombre = txtAlumNombre.Text;
            string alumApellido = txtAlumApellido.Text;
            int alumDNI = 33333333;
            string fechaNacim = Convert.ToString(dtTimeNacimiento.Value);
            int alumSexo = Convert.ToInt32(cmbAlumSexo.SelectedValue);
            int alumNacionalidad = Convert.ToInt32(cmbAlumNac.SelectedValue);
            int alumCaracterizacion = Convert.ToInt32(cmbAlumCaracteriz.SelectedValue);
            int alumCategoria = Convert.ToInt32(cmbAlumCategoria.SelectedValue);
            int alumTurno = Convert.ToInt32(cmbAlumTurno.SelectedValue);

            //MessageBox.Show("INSERT INTO Alumno (Alumno_Nombres, Alumno_Apellidos, Alumno_Dni, Alumno_Nacimiento, Alumno_Sexo, Alumno_Nacionalidad, Alumno_Caracterizacion, Alumno_Categoria, Alumno_turno )" +
             //                                      " VALUES ('" + alumNombre + "', '" + alumApellido + "', '" + alumDNI + "', '" + fechaNacim + "', '" + alumSexo + "', '" + alumNacionalidad + "', '" + alumCaracterizacion + "', '" + alumCategoria + "', '" + alumTurno + "') ");                 
            bool alumnoGuardado = alumno.guarda(alumNombre, alumApellido, alumDNI, fechaNacim, alumSexo, alumNacionalidad, alumCaracterizacion, alumCategoria, alumTurno);
            if (alumnoGuardado)
            {
                MessageBox.Show("sep");
            }
            else
            {
                MessageBox.Show("none");
            }

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
