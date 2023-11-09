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
    public partial class FrmUsuarioPerfil : Form
    {
        Conexion claseConexion = new Conexion();
        DataTable dsCombo = new DataTable();

        public FrmUsuarioPerfil()
        {
            InitializeComponent();
        }

        private void FrmUsuarioPerfil_Load(object sender, EventArgs e)
        {
            
            dsCombo.Load(claseConexion.Leer("SELECT * FROM Permisos")); 
            cmbPermisos.DataSource = dsCombo;
            cmbPermisos.DisplayMember = "Permiso_Categoria"; // Indico que campo de tabla se mostrará
            cmbPermisos.ValueMember = "Id";
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(Convert.ToString());

            if(btnAgregar.Text == "EDITAR"){
                EditarUsu();
            }else{
                GuardarUsu();
            }
            
            
            this.Close();
 
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                GuardarUsu();
            }
        }


        /*******************
         * METODOS 
         * ****************/

        private void GuardarUsu()
        {
            bool cone = claseConexion.ABM("INSERT INTO Usuario (Usuario_Nombre, Usuario_Apellido, Usuario_Mail, Usuario_Alias, Usuario_Permisos, Usuario_Password, Usuario_DNI) " +
                    "VALUES ('" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + txtMail.Text + "', '" + txtAlias.Text + "', " + cmbPermisos.SelectedValue + ", '" + txtContraseña.Text + "', " + Convert.ToInt32(txtDNI.Text) + ")");
            if (cone)
            {
                MessageBox.Show("sep");
            }
            else
            {
                MessageBox.Show("none");
            }
        }

        private void EditarUsu()
        {
            bool cone = claseConexion.ABM(@"UPDATE Usuario
                                            SET Usuario_Nombre = '" + txtNombre.Text + "' , Usuario_Apellido = '" + txtApellido.Text + "' , Usuario_Mail = '" + txtMail.Text + "' , Usuario_Alias = '" + txtAlias.Text + "', Usuario_Permisos = " + cmbPermisos.SelectedValue + ", Usuario_Password = '" + txtContraseña.Text + "', Usuario_DNI = " + Convert.ToInt32(txtDNI.Text) +
                                            " Where Usuario_DNI = " + Convert.ToInt32(txtDNI.Text) +
                                            "");
            if (cone)
            {
                MessageBox.Show("sep");
            }
            else
            {
                MessageBox.Show("none EDITAR");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Decea ancelar la carga ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }



    }
}
