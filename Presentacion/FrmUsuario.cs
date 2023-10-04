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
    public partial class FrmUsuario : Form
    {
        Conexion claseConexion = new Conexion();
        DataTable Tabla = new DataTable();
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void dgvMatriculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Tabla.Clear();
            Tabla.Load(claseConexion.Leer("SELECT * FROM Alumno"));
            dgvMatriculas.DataSource = Tabla;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string busqueda = txtBuscar.Text;
            Tabla.Clear();
            Tabla.Load(claseConexion.Leer("SELECT * FROM Alumno WHERE Alumno_Nombres LIKE '%" + busqueda + "%' OR Alumno_Apellidos LIKE '%" + busqueda + "%' OR Alumno_Dni LIKE '%" + busqueda + "%' ORDER BY Alumno_Apellidos;"));
            dgvMatriculas.DataSource = Tabla;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmUsuarioPerfil perfil = new FrmUsuarioPerfil();
            perfil.Show();
        }
    }
}
