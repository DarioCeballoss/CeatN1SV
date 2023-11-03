using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace Logica
{
    public class Estadistica
    {
        public DataTable AlumnosMatriculados()
        {   //
            DataTable tabla = new DataTable();
            Conexion conexion = new Conexion();
            tabla.Load(conexion.Leer(@"SELECT 
                                        Caracterizacion.Caracterizacion_Nombre as Discapacidad, 
                                        COUNT(IIf(Sexo.Sexo_Categoria='Femenino',1)) as Femenino,
                                        COUNT(IIf(Sexo.Sexo_Categoria='Masculino',1)) as Masculino,
                                        COUNT(Sexo.Sexo_Categoria) as Total
                                        FROM Sexo 
                                        INNER JOIN (Caracterizacion INNER JOIN Alumno ON Caracterizacion.[Id] = Alumno.[Alumno_Caracterizacion]) ON Sexo.[Id] = Alumno.[Alumno_Sexo]
                                        group by Caracterizacion.Caracterizacion_Nombre ;"));
            return tabla;
        }

        public DataTable AlumnosPorTurno()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            Conexion conexion = new Conexion();
            tabla.Load(conexion.Leer(@"SELECT Turno.Turno_Nombre as Turnos, COUNT(Alumno.Alumno_Nombres) as Alumnos
                                        FROM Turno 
                                        INNER JOIN Alumno ON Turno.[Id] = Alumno.[Alumno_turno] group by Turno.Turno_Nombre
                                        UNION
                                        (SELECT 'Total',COUNT(Alumno.Alumno_Nombres) FROM Turno 
                                        INNER JOIN Alumno ON Turno.[Id] = Alumno.[Alumno_turno])
                                        ;"));
            return tabla;
        }
    }
}
