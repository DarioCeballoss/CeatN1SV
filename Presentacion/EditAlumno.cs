using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using Logica;
using System.Data.OleDb;

namespace Presentacion
{
    public partial class EditTutor : Form
    {
        private FrmEditarMat formularioPadre;
        int matr;
        Conexion conecta = new Conexion();
        Alumno alumno = new Alumno();
        
        string Query = @"
                SELECT
                    a.Id,
                    Alumno_Apellidos as Apellido,
                    Alumno_Nombres as Nombre,
                    Alumno_Dni as DNI,
                    Alumno_Nacimiento as F_Nacimiento,
                    n.Nacionalidad_Categoria as Nacionalidad,
                    s.Sexo_Categoria as sexo,
                    Caracterizacion.Caracterizacion_Nombre as Caracterizacion,
                    t.Turno_Nombre,
                    Categoria.Categoria_Nombre as Grado,
                    Tutor.Tutor_Apellidos,
                    Tutor.Tutor_Nombres,
                    Tutor.Tutor_Dni,
                    Profesion_Categoria,
                    Tutor.Tutor_Telefono,
                    n2.Nacionalidad_Categoria as Nacionalidad2,
                    l.Localidad_Nombre,
                    Tutor.Tutor_Direccion,
                    Alumno_LenguaEx,
                    Alumno_ContextoDeEncierro,
                    Alumno_PueblosOrig,
                    Alumno_PercibeBeneSoc,
                    Alumno_CUD,
                    Alumno_Medicacion,
                    Alumno_Vulneracion,
                    Alumno_ComplicacionesParto,
                    Alumno_Observaciones,
                    Admision.Admision_fecha,
                    c2.Categoria_Nombre  as cat,
                    Escuela_Numero,
                    l2.Localidad_Nombre,
                    c3.Categoria_Nombre as cat2,
                    Escuela_Provincia,
                    Escuela_Nacion,
                    Escuela_Privada
                   
                  
                 
                    
                    
                    

                FROM ((((((((((((((Alumno a
                INNER JOIN Admision on a.Id = Admision.Admision_Alumno)
                INNER JOIN Categoria c3 ON  Admision.Escuela_Categoria = c3.Id)
                INNER JOIN Escuela on Admision.OtraEscuela= Escuela.Id)
                INNER JOIN Localidades l2 ON Escuela.Escuela_Distrito = l2.Id)
                
                INNER JOIN Tutor on a.Alumno_Tutores = Tutor.Id )
                INNER JOIN Localidades l on Tutor.Tutor_Localidad = l.Id)
                INNER JOIN Turno t ON a.Alumno_turno = t.Id)
                INNER JOIN Categoria ON a.Alumno_Categoria = Categoria.Id )
                INNER JOIN Sexo s ON a.Alumno_Sexo = s.Id)  
                INNER JOIN Caracterizacion ON a.Alumno_Caracterizacion = Caracterizacion.Id)
                INNER JOIN Nacionalidad n ON a.Alumno_Nacionalidad = n.Id)
                INNER JOIN Categoria c2 ON Admision.Escuela_Categoria = c2.Id )
                INNER JOIN Nacionalidad n2 ON Tutor.Tutor_Nacionalidad = n2.Id)
                INNER JOIN Profesion ON Tutor.Tutor_Profesion = Profesion.Id)";
           

        public EditTutor( object matricula , FrmEditarMat editarmat)
        {
            InitializeComponent();
            matr = Convert.ToInt32(matricula);
            formularioPadre = editarmat;
        }

        private void EditAlumno_Load(object sender, EventArgs e)
        {
            gbAlumno.Show();
            gbTutores.Hide();
            gbAdmision.Hide();
            gbObservacion.Hide();
            dgvBajas.Hide();
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


            bool trae = false;
            OleDbDataReader reader = conecta.Leer(Query + " WHERE a.Id =" + matr);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtAlumApellido.Text = reader.GetString(1);
                    lblApellido.Text = reader.GetString(1);
                    txtAlumNombre.Text =  reader.GetString(2);
                    lblNombre.Text = reader.GetString(2);
                    txtAlumDNI.Text = reader.GetInt32(3).ToString();
                    dtTimeNacimiento.Value = reader.GetDateTime(4);
                    cmbAlumNac.Text = reader.GetString(5);
                    cmbAlumSexo.Text = reader.GetString(6);
                    cmbAlumCaracteriz.Text = reader.GetString(7);
                    cmbAlumTurno.Text = reader.GetString(8);
                    cmbAlumCategoria.Text = reader.GetString(9);
                    txtTutorApellido.Text = reader.GetString(10);
                    txtTutorNombre.Text = reader.GetString(11);
                    txtTutorDNI.Text = Convert.ToString(reader.GetInt32(12));
                    cmbTurorProfesion.Text = reader.GetString(13);
                    if (!reader.IsDBNull(14))
                    {
                        txtTutorTelefono.Text =Convert.ToString( reader.GetDouble(14));
                    }
               
                    cmbTutorNac.Text = reader.GetString(15);
                    cmbPartido.Text = reader.GetString(16);
                    txtTutorDomicilio.Text = reader.GetString(17);
                    chkObsLengua.Checked = reader.GetBoolean(18);
                    chkObsEncierro.Checked = reader.GetBoolean(19);
                    chkObsOriginario.Checked = reader.GetBoolean(20);
                    chkObsBeneficio.Checked = reader.GetBoolean(21);
                    chkObsCUD.Checked = reader.GetBoolean(22);
                    chkObsMedicacion.Checked = reader.GetBoolean(23);
                    chkObsDerechos.Checked = reader.GetBoolean(24);
                    chkObsParto.Checked = reader.GetBoolean(25);
                    if (!reader.IsDBNull(26))
                    {
                        txtObservaciones.Text = reader.GetString(26);
                    }

                    dateTimePicker1.Value = reader.GetDateTime(27);
                    if (!reader.IsDBNull(28))
                    {
                        cmbAdmiCategoria.Text = reader.GetString(28);
                    }

                    txtEscuelanum.Text = Convert.ToString(reader.GetInt32(29));

                    cmbDistrito.Text = reader.GetString(30);
                    txtGrado2.Text = reader.GetString(31);
                    rbProvincia.Checked = reader.GetBoolean(32);
                    rbNacion.Checked = reader.GetBoolean(33);
                    //rbPrivada.Checked = reader.GetBoolean(34);
                    
                    
                 
                   
                }
                trae = true;
            }
            else
            {
                trae = false;
            }



            DataTable TablaBjas = new DataTable();

        string QueryBajas = @" SELECT 
                       Baja_Fecha as Fecha, 
                       Baja_Causa as Motivo,
                       Baja_Activa as Estado
                       
                       From Baja
                       WHERE Baja_Alumno = ";
  
         TablaBjas.Clear();
            TablaBjas.Load(conecta.Leer(QueryBajas + matr));
           
            
            if (TablaBjas.Rows.Count > 0)
            {
                dgvBajas.Show();
                dgvBajas.DataSource = TablaBjas;
            }
            else
            {
                // No se recuperaron datos, puedes mostrar un mensaje o realizar otra acción apropiada aquí.
                dgvBajas.Hide();
                btnEditarBajas.Hide();
            }
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public static void cargarbajas(object matr)  
        { 

        
        }

        private void gbAlumno_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarAlumno_Click(object sender, EventArgs e)
        {
            gbAlumno.Show();
            gbTutores.Hide();
            gbAdmision.Hide();
            gbObservacion.Hide();
            dgvBajas.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbAlumno.Hide();
            gbTutores.Show();
            gbAdmision.Hide();
            gbObservacion.Hide();
            dgvBajas.Hide();
        }

        private void btnEditarObs_Click(object sender, EventArgs e)
        {
            gbAlumno.Hide();
            gbTutores.Hide();
            gbAdmision.Hide();
            gbObservacion.Show();
            dgvBajas.Hide();
        }

        private void btnEditarAdmi_Click(object sender, EventArgs e)
        {
            gbAlumno.Hide();
            gbTutores.Hide();
            gbAdmision.Show();
            gbObservacion.Hide();
            dgvBajas.Hide();
        }

        private void btnEditarBajas_Click(object sender, EventArgs e)
        {
            gbAlumno.Hide();
            gbTutores.Hide();
            gbAdmision.Hide();
            gbObservacion.Hide();
            dgvBajas.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
//            string Query = @"
//                             UPDATE Alumno
//                             SET
//                             Alumno_Apellidos = " + txtAlumApellido.Text + ", Alumno_Nombres = "+  txtAlumNombre.Text +
//                               ", Alumno_Dni= "  txtAlumDNI.Text + ",  Alumno_Nacimiento= "+dtTimeNacimiento.Value+ 
//                                   ", Alumno_Nacimiento ="+
    
//                                " FROM Alumno a INNER JOIN Admision ON a.Id = Admision.Admision_Alumno "+
//                                "INNER JOIN Categoria c3 ON Admision.Escuela_Categoria = c3.Id" +
//                               " INNER JOIN Escuela ON Admision.OtraEscuela = Escuela.Id " +
//                                "INNER JOIN Localidades l2 ON Escuela.Escuela_Distrito = l2.Id" +
//                               " INNER JOIN Tutor ON a.Alumno_Tutores = Tutor.Id"
//                               " INNER JOIN Localidades l ON Tutor.Tutor_Localidad = l.Id"+
//                               " INNER JOIN Turno t ON a.Alumno_turno = t.Id" +
//                              "  INNER JOIN Categoria ON a.Alumno_Categoria = Categoria.Id" +
//                               " INNER JOIN Sexo s ON a.Alumno_Sexo = s.Id" +
//                               " INNER JOIN Caracterizacion ON a.Alumno_Caracterizacion = Caracterizacion.Id"+
//                              "  INNER JOIN Nacionalidad n ON a.Alumno_Nacionalidad = n.Id"+
//                               " INNER JOIN Categoria c2 ON Admision.Escuela_Categoria = c2.Id"+
//                               " INNER JOIN Nacionalidad n2 ON Tutor.Tutor_Nacionalidad = n2.Id"+
//                               " INNER JOIN Profesion ON Tutor.Tutor_Profesion = Profesion.Id"+
//                                WHERE
//                                    -- Condición para identificar los registros a actualizar (por ejemplo, por el Id)
//                                    a.Id = 1;

        }
    }
}