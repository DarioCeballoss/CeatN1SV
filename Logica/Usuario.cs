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
        

        public bool TraeDatos(string usu, string pass)
        {
            bool trae = false;
            OleDbDataReader reader = conecta.Leer("SELECT * FROM Usuario where Usuario_Alias = '" + usu + "' and Usuario_Password = '" + pass + "'");
            if (reader.HasRows)
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UsuarioCache.IdUsuario = reader.GetInt32(0);
                        UsuarioCache.Nombre = reader.GetString(1);
                        UsuarioCache.Apellido = reader.GetString(2);
                        UsuarioCache.Permisos = Convert.ToString(reader.GetInt32(5));
                        //

                    }
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

