using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace Logica
{
    public class Alumno
    {
        Conexion conexion = new Conexion();

        public DataTable dtNacionalidades()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();

            tabla.Load(conexion.Leer("SELECT * FROM Nacionalidad order by Id"));
            return tabla;
        }

        public DataTable dtSexo()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();

            tabla.Load(conexion.Leer("SELECT * FROM Sexo order by Id"));
            return tabla;
        }

        public DataTable dtProfesion()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();

            tabla.Load(conexion.Leer("SELECT * FROM Profesion order by Profesion_Categoria"));
            return tabla;
        }


        //alum categoria
        public DataTable dtCategoria()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();

            tabla.Load(conexion.Leer("SELECT * FROM Categoria order by Categoria_Nombre"));
            return tabla;
        }
        //alum turno
        public DataTable dtTurno()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();

            tabla.Load(conexion.Leer("SELECT * FROM Turno order by Turno_Nombre"));
            return tabla;
        }
        //alum carcterizacion
        public DataTable dtCaracterizacion()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();

            tabla.Load(conexion.Leer("SELECT * FROM Caracterizacion order by Caracterizacion_Nombre"));
            return tabla;
        }

        //Provincia
        public DataTable dtProvincia()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();

            tabla.Load(conexion.Leer("SELECT Id, Prov_Nom FROM Provincias order by Prov_Nom"));
            return tabla;
        }
        //Partido
        public DataTable dtLocalidades(int provincia)
        {
            
            DataTable tabla = new DataTable();
            tabla.Clear();

            tabla.Load(conexion.Leer("SELECT * FROM Localidades WHERE Provincia_ID = " + provincia + " ORDER BY Localidad_Nombre"));
            return tabla;
        }

        //Guardar alumno
        public bool guardaAlumno(string alumNombre,
                          string alumApellido,
                          int alumDNI,
                          string fechaNacim,
                          int alumSexo,
                          int alumNacionalidad,
                          int alumCaracterizacion,
                          int alumCategoria,
                          int alumTurno)

        {
            bool guardado = conexion.ABM("INSERT INTO Alumno (Alumno_Nombres, Alumno_Apellidos, Alumno_Dni, Alumno_Nacimiento, Alumno_Sexo, Alumno_Nacionalidad, Alumno_Caracterizacion, Alumno_Categoria, Alumno_turno )" +
                                                   " VALUES ('" + alumNombre + "', '" + alumApellido + "', '" + alumDNI + "', '" + fechaNacim + "', '" + alumSexo + "', '" + alumNacionalidad + "', '" + alumCaracterizacion + "', '" + alumCategoria + "', '" + alumTurno+ "') ");
            return guardado;
        }
        //Guarda Tutor
        public bool guardaTutor(string tutorNombre,
                          string tutorApellido,
                          int tutorDNI,
                          int tutorNacionalidad,
                          int tutorProfesion,
                          int tutorLocalidad,
                          string tutorDireccion,
                          int tutorTelefono)
        {
            bool guardado = conexion.ABM("INSERT INTO Alumno (Tutor_Nombres, Tutor_Apellidos, Tutor_Dni, Tutor_Nacionalidad, Tutor_Profesion, Tutor_Localidad, Tutor_Direccion,  Tutor_Telefono )" +
                                                   " VALUES ('" + tutorNombre + "', '" + tutorApellido + "', " + tutorDNI + ", " + tutorNacionalidad + ", " + tutorProfesion + ", " + tutorLocalidad + ", " + tutorDireccion + ", " + tutorTelefono + ") ");
            return guardado;
        }


    }
}



