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

            OleDbDataReader reader = conecta.Leer(@"SELECT Usuario.Id, Usuario.Usuario_Nombre, Usuario.Usuario_Apellido, Usuario.Usuario_Alias, Usuario.Usuario_Password, Permisos.Permiso_Categoria
                                                    FROM Permisos 
                                                    INNER JOIN Usuario ON Permisos.[Id] = Usuario.[Usuario_Permisos] 
                                                    WHERE Usuario_Alias = '" + usu + "' and Usuario_Password = '" + pass + "' ;");
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    UsuarioCache.IdUsuario = reader.GetInt32(0);
                    UsuarioCache.Nombre = reader.GetString(1);
                    UsuarioCache.Apellido = reader.GetString(2);
                    UsuarioCache.Permisos = reader.GetString(5);

                }
                trae = true;
            }
            else
            {
                trae = false;
            }

            return trae;
        }


    }
}

