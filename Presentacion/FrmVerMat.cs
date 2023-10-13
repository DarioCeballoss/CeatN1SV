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
    public partial class FrmVerMat : Form
    {
        Conexion claseConexion = new Conexion();
        DataTable Tabla = new DataTable();

        public FrmVerMat()
        {
            InitializeComponent();
        }
        string consulta;
        private void FrmVerMat_Load(object sender, EventArgs e)
        {
            string consultaSql = @"
                SELECT
                    Alumno_Nombres as nombre,
                    Alumno_Apellidos as Apellido,
                    Alumno_Dni as DNI,
                    Alumno_Nacimiento as F_Nacimiento,
                    s.Sexo_Categoria as sexo,
                    n.Nacionalidad_Categoria as Nacionalidad,
                    Caracterizacion.Categoria_Nombre as Caracterizacion,
                    Alumno_AñoAdmision as fechaDeIngreso,
                    Categoria.Categoria_Nombre as Categoria

                FROM ((((Alumno a
                INNER JOIN Sexo s ON a.Alumno_Sexo = s.Id)  
                INNER JOIN Caracterizacion ON a.Alumno_Caracterizacion = Caracterizacion.Id)
                INNER JOIN Nacionalidad n ON a.Alumno_Nacionalidad = n.Id)
                INNER JOIN Categoria ON a.Alumno_Categoria = Categoria.Id )  ";
            try
            {
                Tabla.Clear();
                Tabla.Load(claseConexion.Leer(consultaSql));

             
                dgvMatriculas.DataSource = Tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        int op = 1;
        
        string consultaB ;
        private void cmbSeccion_TextChanged(object sender, EventArgs e)
        {
            string busqueda = cmbSeccion.Text;
            
            //Tabla.Clear();
            //Tabla.Load(claseConexion.Leer("SELECT  Alumno.Alumno_Nombre, Usuario.Alumno_Apellido, Alumno.Alumno_Dni, Alumno.Alumno_Nacimiento, Sexo.Sexo_Categoria " +
            //    "Nacionalidad.Nacionalidad_Categoria,Caracterizacion.Caracterizacion_Nombre as Caracterizacion FROM Alumno INNER JOIN Sexo ON Alumno.Alumno_Sexo = Sexo.Id "+ 
            //"INNER JOIN Caracterizacion ON Alumno.Alumno_Caracterizacion = Caracterizacion.Id INNER JOIN Nacionalidad ON Alumno.Alumno_Nacionalidad = Nacionalidad.Id  WHERE Categoria.Categoria_Nombre LIKE '%" + 
            //busqueda + "%' OR Usuario_Apellido LIKE '%" + busqueda + "%' OR Usuario_DNI LIKE '%" + busqueda + "%' ORDER BY Usuario_Apellido;"));
            //dgvMatriculas.DataSource = Tabla;
        }

         

    }
}
