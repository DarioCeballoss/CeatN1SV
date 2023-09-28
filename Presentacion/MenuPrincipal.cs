using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea Cerrar sesion ?","Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes){
                this.Close();
            }

        }

        private void btnNuevaMatricula_Click(object sender, EventArgs e)
        {
            ColorBtn();
            btnNuevaMatricula.BackColor = Color.FromArgb(123, 227, 227);
            btnNuevaMatricula.ForeColor = Color.FromArgb(254, 255, 255);
            FormHijo(new FrmNuevaMat());
        }

        private void btnVerMatriculas_Click(object sender, EventArgs e)
        {
            ColorBtn();
            btnVerMatriculas.BackColor = Color.FromArgb(123, 227, 227);
            btnVerMatriculas.ForeColor = Color.FromArgb(254, 255, 255);
            FormHijo(new FrmVerMat());
        }

        private void btnEdtiarMatriculas_Click(object sender, EventArgs e)
        {
            ColorBtn();
            btnEdtiarMatriculas.BackColor = Color.FromArgb(123, 227, 227);
            btnEdtiarMatriculas.ForeColor = Color.FromArgb(254, 255, 255);
            FormHijo(new FrmEditarMat());
            

        }

        private void btnBajaMatricula_Click(object sender, EventArgs e)
        {
            ColorBtn();
            btnBajaMatricula.BackColor = Color.FromArgb(123, 227, 227);
            btnBajaMatricula.ForeColor = Color.FromArgb(254, 255, 255);
            FormHijo(new FrmNuevaMat());
            //grupRetiro
            //FrmNuevaMat.grupRetiro.Enabled = true; 
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            ColorBtn();
            btnUsuario.BackColor = Color.FromArgb(123, 227, 227);
            btnUsuario.ForeColor = Color.FromArgb(254, 255, 255);
            FormHijo(new FrmUsuario());
        }






        /******************************
         * FUNCIONES diseño
         * ****************************/
        private void ColorBtn()
        {
            foreach (var btn in pnlMenu.Controls)
            {
                if (btn is Button)
                {
                    ((Button)btn).BackColor = Color.FromArgb(254, 255, 255);
                    ((Button)btn).ForeColor = Color.Black;
                }
            }
        }

        //cambiade form
        private Form formActivo = null;
        private void FormHijo(Form formHijo)
        {
            if (formActivo != null) formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formHijo);
            pnlContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        /************************
         *  FUNCIONES OBJETOS
         *  *******************/
        //UsuarioCache usu = new UsuarioCache();
        //private void UserData_Load()
        //{
            
        //    lblNombre.Text = usu.Nombre;
        //    lblApellido.Text = usu.Apellido;
        //    lblPermisos.Text = usu.Permisos;
            
        //}

    }
}
