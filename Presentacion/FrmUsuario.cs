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
            Tabla.Load(claseConexion.Leer("SELECT * FROM Usuario"));
            dgvMatriculas.DataSource = Tabla;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmUsuarioPerfil perfil = new FrmUsuarioPerfil();
            perfil.Show();
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            Tabla.Clear();
            Tabla.Load(claseConexion.Leer("SELECT * FROM Usuario WHERE Usuario_Nombre LIKE '%" + busqueda + "%' OR Usuario_Apellido LIKE '%" + busqueda + "%' OR Usuario_DNI LIKE '%" + busqueda + "%' ORDER BY Usuario_Apellido;"));
            dgvMatriculas.DataSource = Tabla;
        }
    }
}
