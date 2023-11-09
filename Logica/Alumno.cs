using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
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

            tabla.Load(conexion.Leer("SELECT * FROM Categoria"));
            return tabla;
        }
        //alum turno
        public DataTable dtTurno()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();

            tabla.Load(conexion.Leer("SELECT * FROM Turno"));
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
        public DataTable dtLocalidades(int idProv)
        {
            DataTable tabla = new DataTable();
            tabla.Clear();

            tabla.Load(conexion.Leer("SELECT * FROM Localidades WHERE Provincia_ID = " + idProv + " ORDER BY Localidad_Nombre "));
            return tabla;
        }
        //trae el ultimo id de una tabla 
        public int ultimoId(string tabla)
        {
            int id = conexion.LeerUltimoId(tabla);
            return id;
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
                          int alumTurno,
                          int lenguaEx,
                          int contexEncierro,
                          int originario,
                          int benefSocial,
                          int cud,
                          int medicacion,
                          int vulneracion,
                          int parto,
                          string observa)
        {

            bool guardado = conexion.ABM(@"INSERT INTO Alumno (Alumno_Nombres, Alumno_Apellidos, Alumno_Dni, Alumno_Nacimiento, Alumno_Sexo, Alumno_Nacionalidad, Alumno_Caracterizacion, Alumno_Categoria, Alumno_turno, Alumno_tutores, Alumno_LenguaEx, Alumno_ContextoDeEncierro, Alumno_PueblosOrig, Alumno_PercibeBeneSoc, Alumno_CUD, Alumno_Medicacion, Alumno_Vulneracion, Alumno_ComplicacionesParto, Alumno_Observaciones  )" +
                                                   " VALUES ('" + alumNombre + "', '" + alumApellido + "', '" + alumDNI + "', '" + fechaNacim + "', '" + alumSexo + "', '" + alumNacionalidad + "', '" + alumCaracterizacion + "', '" + alumCategoria + "', '" + alumTurno + "' , " + ultimoId("Tutor") + ", " + lenguaEx + ", " + contexEncierro + ", " + originario + ", " + benefSocial + ", " + cud + ", " + medicacion + ", " + vulneracion + ", " + parto + ", '" + observa + "' ) ");
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
            bool guardado = conexion.ABM("INSERT INTO Tutor (Tutor_Nombres, Tutor_Apellidos, Tutor_Dni, Tutor_Nacionalidad, Tutor_Profesion, Tutor_Localidad, Tutor_Direccion,  Tutor_Telefono )" +
                                                   " VALUES ('" + tutorNombre + "', '" + tutorApellido + "', " + tutorDNI + ", " + tutorNacionalidad + ", " + tutorProfesion + ", " + tutorLocalidad + ", '" + tutorDireccion + "', " + tutorTelefono + ")");
            return guardado;
        }
        //Guarda Escuela de admision
        public bool guardaEscuela(
                          int escuelaDistrito,
                          int escuelaNumero,
                          int escuyelaNacion,
                          int escuelaProvincia,
                          int escuelaPrivada)
        {
            bool guardado = conexion.ABM("INSERT INTO Escuela (Escuela_Distrito, Escuela_Numero, Escuela_Nacion, Escuela_Provincia, Escuela_Privada)" +
                                                   " VALUES (" + escuelaDistrito + ", " + escuelaNumero + ", " + escuyelaNacion + ", " + escuelaProvincia + ", " + escuelaPrivada + ")");
            return guardado;
        }
        //Guarda Admision
        public bool guardaAdmision(
                  int admisionEscCat,
                  string admisionFecha,
                  bool admisionMismaEsc)
        {

            int admisionOtraEsc = admisionMismaEsc ? 0 : ultimoId("Escuela"); // ternario
            bool guardado = conexion.ABM("INSERT INTO Admision (Admision_Alumno, Escuela_Categoria, Admision_Fecha, MismaEscuela, OtraEscuela)" +
                                                   " VALUES (" + ultimoId("Alumno") + ", " + admisionEscCat + ", '" + admisionFecha + "', " + Convert.ToInt32(admisionMismaEsc) + ", " + admisionOtraEsc + ")");
            return guardado;
        }
    }
}



