using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Datos;

namespace Presentacion
{
    public partial class FrmAlumnoBorrar : Form
    {
        private FrmBajaMat formularioPadre;
        int matr;
        Conexion conecta = new Conexion();
        string Query = @"
                SELECT
                    a.Id as Matricula,
                    Alumno_Nombres as Nombre,
                    Alumno_Apellidos as Apellido,
                    Alumno_Dni as DNI,
                    Categoria.Categoria_Nombre as Grado

                FROM Alumno a
                INNER JOIN Categoria ON a.Alumno_Categoria = Categoria.Id ";


        public FrmAlumnoBorrar(object matricula ,FrmBajaMat padre)
        {
            InitializeComponent();
            matr = Convert.ToInt32(matricula);
            formularioPadre = padre;
           
        }

        private void FrmAlumnoBorrar_Load(object sender, EventArgs e)
        {
           
            bool trae = false;
            OleDbDataReader reader = conecta.Leer(Query + "WHERE a.Id =" + matr);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lblNombre.Text = "Nombre: " + reader.GetString(1);
                    lblApellido.Text = "Apellido: " + reader.GetString(2);
                    lblDNI.Text = "DNI: " + reader.GetInt32(3).ToString();
                    lblGrado.Text = "Grado: " + reader.GetString(4);
                }
                trae = true;
            }
            else
            {
                trae = false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarBaja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SE DEJARA INACTIVO  AL ALUMNO : \n " +
                              lblNombre.Text + " " +
                              lblApellido.Text +

                               " \n\n Desea Continuar ? \n ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                string QUERY2 = "INSERT INTO Baja (Baja_Fecha, Baja_Causa, Baja_Activa,Baja_Alumno) VALUES ('" + FBAJA.Value.ToString("yyyy-MM-dd") + "', '" + txtBajaCausa.Text + "', 1, '"+ matr+ "');";




                bool ELIMINADO = conecta.ABM(QUERY2);

                if (ELIMINADO == true)
                {

                    DialogResult result = MessageBox.Show("Alumno inactivo", "Confirmar", MessageBoxButtons.OK);

                    // Si el botón "OK" se presiona, cierra el formulario actual
                    if (result == DialogResult.OK)
                    {
                        formularioPadre.actualizarTabla();   
                        this.Close();
                        
                    }
                }
             

                
            }


            }
    }
}

