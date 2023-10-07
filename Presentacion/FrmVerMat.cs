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

        private void FrmVerMat_Load(object sender, EventArgs e)
        {
            Tabla.Clear();
            Tabla.Load(claseConexion.Leer("SELECT Alumno.Alumno_Nombres, Alumno.Alumno_Apellidos, Alumno.Alumno_Nacimiento, Alumno.Alumno_Dni, Tutor.Tutor_Nombres, Tutor.Tutor_Apellidos, Tutor.Tutor_Nacionalidad, Caracterizacion.Caracterizacion_Nombre FROM Tutor INNER JOIN (Caracterizacion INNER JOIN Alumno ON Caracterizacion.[Id] = Alumno.[Alumno_Caracterizacion]) ON Tutor.[Id] = Alumno.[Alumno_Tutor];"));
            dgvMatriculas.DataSource = Tabla;
        }




    }
}
