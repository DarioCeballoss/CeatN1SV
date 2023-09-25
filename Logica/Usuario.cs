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
        //DataTable Tabla = new DataTable();

        public bool funciona()
        {
            if (conecta.suma(2, 3) == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool TraeDatos(string usu,string pass)
        {
            OleDbDataReader reader = conecta.Leer("SELECT * FROM Usuario where Usuario_Alias = '" + usu + "' and Usuario_Password = '" + pass + "'");
            if (reader.HasRows) { return true; } else { return false; }
        }

        


    }
}
