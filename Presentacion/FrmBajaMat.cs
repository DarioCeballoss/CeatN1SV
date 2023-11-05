using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;

namespace Presentacion
{
    public partial class FrmBajaMat : Form
    {
        Conexion claseConexion = new Conexion();
        DataTable Tabla = new DataTable();

        public FrmBajaMat()
        {
            InitializeComponent();
        }

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

                FROM ((((Alumno a
                INNER JOIN Sexo s ON a.Alumno_Sexo = s.Id)  
                INNER JOIN Caracterizacion ON a.Alumno_Caracterizacion = Caracterizacion.Id)
                INNER JOIN Nacionalidad n ON a.Alumno_Nacionalidad = n.Id)
                INNER JOIN Categoria ON a.Alumno_Categoria = Categoria.Id )";

        private void FrmBajaMat_Load(object sender, EventArgs e)
        {
            Tabla.Clear();
            Tabla.Load(claseConexion.Leer(Query));
            dgvMatriculas.DataSource = Tabla;
        }

        

        private void dgvMatriculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dgvMatriculas.Rows[e.RowIndex].Cells[0];

                // Obtenemos el valor de la celda
                object cellValue = cell.Value;
                FrmAlumnoBorrar EliminarAlumno = new FrmAlumnoBorrar(cellValue);
                EliminarAlumno.Show();

               
            }
          
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string where = "WHERE a.Id LIKE '%" + txtBajaMatricula.Text + "%' " +
             "or a.Alumno_Nombres LIKE '%" + txtBajaMatricula.Text + "%' " +
             "or a.Alumno_Apellidos LIKE '%" + txtBajaMatricula.Text + "%' " +
             "or a.Alumno_Dni LIKE '%" + txtBajaMatricula.Text + "%'";

            Tabla.Clear();


            Tabla.Load(claseConexion.Leer(Query + where));
            dgvMatriculas.DataSource = Tabla;
        }


        

    }
}
