using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data.OleDb;
using System.Data;

namespace Logica
{
    public class Usuario
    {
        Conexion conecta = new Conexion();
        public int IdUsuario;
        public string Nombre;
        public string Apellido;
        public string Permisos;

        public bool TraeDatos(string usu, string pass)
        {
            bool trae = false;
            OleDbDataReader reader = conecta.Leer("SELECT * FROM Usuario where Usuario_Alias = '" + usu + "' and Usuario_Password = '" + pass + "'");
            if (reader.HasRows)
            {
                if (reader.HasRows)
                {
                    //while (reader.Read())
                    //{
                    //    IdUsuario = reader.GetInt32(0);
                    //    Nombre = reader.GetString(1);
                    //    Apellido = reader.GetString(2);
                    //    Permisos = reader.GetString(3);

                    //}
                    trae = true;
                }
                else
                {
                    trae = false;
                }
            }
            //public bool funciona(){if (conecta.suma(2, 3) == 5){ return true; } else{return false;}}
            return trae;
        }


    }
}

