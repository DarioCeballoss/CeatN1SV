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

                FROM ((((Alumno a
                INNER JOIN Sexo s ON a.Alumno_Sexo = s.Id)  
                INNER JOIN Caracterizacion ON a.Alumno_Caracterizacion = Caracterizacion.Id)
                INNER JOIN Nacionalidad n ON a.Alumno_Nacionalidad = n.Id)
                INNER JOIN Categoria ON a.Alumno_Categoria = Categoria.Id )";

        public FrmEditarMat()
        {
            InitializeComponent();
        }

        private void dgvMatriculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmEditarMat_Load(object sender, EventArgs e)
        {
            

            Tabla.Clear();
            Tabla.Load(claseConexion.Leer(Query));
            dgvMatriculas.DataSource = Tabla;
        }

        private void txtMatriculas_TextChanged(object sender, EventArgs e)
        {
            string where = "WHERE a.Id LIKE '%" + txtMatriculas.Text + "%' " +
             "or a.Alumno_Nombres LIKE '%" + txtMatriculas.Text + "%' " +
             "or a.Alumno_Apellidos LIKE '%" + txtMatriculas.Text + "%' " +
             "or a.Alumno_Dni LIKE '%" + txtMatriculas.Text + "%'";

            Tabla.Clear();
           

            Tabla.Load(claseConexion.Leer(Query+ where));
            dgvMatriculas.DataSource = Tabla;
        }

        
    }




}
