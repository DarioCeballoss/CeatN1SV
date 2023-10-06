using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using System.Data.OleDb;


namespace Presentacion
{
    public partial class FrmUsuario : Form
    {
        FrmUsuarioPerfil frmPerfil = new FrmUsuarioPerfil();

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
            Tabla.Load(claseConexion.Leer("SELECT Usuario.Id, Usuario.Usuario_Nombre, Usuario.Usuario_Apellido, Usuario.Usuario_DNI, Usuario.Usuario_Alias, Permisos.Permiso_Categoria " +
                "FROM Usuario INNER JOIN Permisos ON Usuario.Usuario_Permisos = Permisos.Id;"));
            dgvMatriculas.DataSource = Tabla;

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            frmPerfil.Show();
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            Tabla.Clear();
            Tabla.Load(claseConexion.Leer("SELECT Usuario.Id, Usuario.Usuario_Nombre, Usuario.Usuario_Apellido, Usuario.Usuario_DNI, Usuario.Usuario_Alias, Permisos.Permiso_Categoria " +
                "FROM Usuario INNER JOIN Permisos ON Usuario.Usuario_Permisos = Permisos.Id WHERE Usuario_Nombre LIKE '%" + busqueda + "%' OR Usuario_Apellido LIKE '%" + busqueda + "%' OR Usuario_DNI LIKE '%" + busqueda + "%' ORDER BY Usuario_Apellido;"));
            dgvMatriculas.DataSource = Tabla;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            OleDbDataReader reader = claseConexion.Leer("Select * from Usuario where Id = " + dgvMatriculas.CurrentRow.Cells["UsuId"].Value.ToString() + " ;");
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    
                    frmPerfil.txtNombre.Text = reader.GetString(1);
                    frmPerfil.txtApellido.Text = reader.GetString(2);
                    frmPerfil.txtMail.Text = reader.GetString(3);
                    frmPerfil.txtAlias.Text = reader.GetString(4);
                    frmPerfil.cmbPermisos.SelectedValue = 0;
                    frmPerfil.txtContraseña.Text = reader.GetString(6);
                    frmPerfil.txtDNI.Text = Convert.ToString(reader.GetInt32(7));
                    frmPerfil.Show();
                }
                

            }
            else { MessageBox.Show("NOP"); }

        }
    }
}
