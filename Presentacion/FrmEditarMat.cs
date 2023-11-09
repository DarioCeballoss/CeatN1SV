using System;
using System.Data;
using System.Windows.Forms;
using Datos;


namespace Presentacion
{
    public partial class FrmEditarMat : Form
    {
        Conexion claseConexion = new Conexion();
        DataTable Tabla = new DataTable();
        string Query = @"
               SELECT
                    a.Id as Matricula,
                    Alumno_Nombres as Nombre,
                    Alumno_Apellidos as Apellido,
                    Alumno_Dni as DNI,
                    Alumno_Nacimiento as F_Nacimiento,
                    s.Sexo_Categoria as sexo,
                    n.Nacionalidad_Categoria as Nacionalidad,
                    Caracterizacion.Caracterizacion_Nombre as Caracterizacion,
                    Alumno_AñoAdmision as fechaDeIngreso,
                    Categoria.Categoria_Nombre as Grado
                   

                FROM (((((Alumno a
                INNER JOIN Sexo s ON a.Alumno_Sexo = s.Id)  
                INNER JOIN Caracterizacion ON a.Alumno_Caracterizacion = Caracterizacion.Id)
                INNER JOIN Nacionalidad n ON a.Alumno_Nacionalidad = n.Id)
                INNER JOIN Categoria ON a.Alumno_Categoria = Categoria.Id )
                LEFT JOIN Baja b ON a.Id = b.Baja_Alumno )
                ";

        string Query3 = @"
               SELECT
                    a.Id as Matricula,
                    Alumno_Nombres as Nombre,
                    Alumno_Apellidos as Apellido,
                    Alumno_Dni as DNI,
                    Alumno_Nacimiento as F_Nacimiento,
                    s.Sexo_Categoria as sexo,
                    n.Nacionalidad_Categoria as Nacionalidad,
                    Caracterizacion.Caracterizacion_Nombre as Caracterizacion,
                    Alumno_AñoAdmision as fechaDeIngreso,
                    Categoria.Categoria_Nombre as Grado,
                    b.Baja_Activa as Inactivo
                   

                FROM (((((Alumno a
                INNER JOIN Sexo s ON a.Alumno_Sexo = s.Id)  
                INNER JOIN Caracterizacion ON a.Alumno_Caracterizacion = Caracterizacion.Id)
                INNER JOIN Nacionalidad n ON a.Alumno_Nacionalidad = n.Id)
                INNER JOIN Categoria ON a.Alumno_Categoria = Categoria.Id )
                LEFT JOIN Baja b ON a.Id = b.Baja_Alumno )
                ";


        string where;
        string where2;

        private Form formActivo = null;
        private void FormHijo(Form formHijo)
        {
            if (formActivo != null) formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            //pnlContenedor.Controls.Add(formHijo);
            //pnlContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }


        public FrmEditarMat()
        {
            InitializeComponent();
           
        }
       
      
        private void dgvMatriculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dgvMatriculas.Rows[e.RowIndex].Cells[0];

                // Obtenemos el valor de la celda
                object cellValue = cell.Value;
                EditTutor EditarAlumno = new EditTutor(cellValue, this);
                EditarAlumno.Show();


            }
        }

        private void FrmEditarMat_Load(object sender, EventArgs e)
        {

            where = " WHERE (b.Baja_Alumno IS NULL OR b.Baja_Activa = FALSE) and (a.Id LIKE '%" + txtMatriculas.Text + "%' " +
                    "or a.Alumno_Nombres LIKE '%" + txtMatriculas.Text + "%' " +
                    "or a.Alumno_Apellidos LIKE '%" + txtMatriculas.Text + "%' " +
                    "or a.Alumno_Dni LIKE '%" + txtMatriculas.Text + "%')";
            where2 = " WHERE ( b.Baja_Activa = TRUE )and (a.Id LIKE '%" + txtMatriculas.Text + "%' " +
                    "or a.Alumno_Nombres LIKE '%" + txtMatriculas.Text + "%' " +
                    "or a.Alumno_Apellidos LIKE '%" + txtMatriculas.Text + "%' " +
                    "or a.Alumno_Dni LIKE '%" + txtMatriculas.Text + "%')";

            Tabla.Clear();
            Tabla.Load(claseConexion.Leer(Query + where));
            dgvMatriculas.DataSource = Tabla;
        }

        private void txtMatriculas_TextChanged(object sender, EventArgs e)
        {
          
            Tabla.Clear();
           

            Tabla.Load(claseConexion.Leer(Query3+ where));
            dgvMatriculas.DataSource = Tabla;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked==true)
            {
                Tabla.Load(claseConexion.Leer(Query + where));
                dgvMatriculas.DataSource = Tabla;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Tabla.Clear();
                Tabla.Load(claseConexion.Leer(Query3 + where2));
                dgvMatriculas.DataSource = Tabla;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
	            {
		            Tabla.Clear();
                    Tabla.Load(claseConexion.Leer(Query + where));
                    dgvMatriculas.DataSource = Tabla;
	            }
                        
        }

        }

        
        
    }





