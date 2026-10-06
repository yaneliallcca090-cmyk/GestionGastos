using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionGastos.Config
{
    public class ConexionSqlite
    {
        private const string CadenaConexion = "Data Source=gastos.db";

        public SqliteConnection ObtenerConexion()
        {
            return new SqliteConnection(CadenaConexion);
        }

        public bool ProbarConexion()
        {
            try
            {
                using (var conexion = ObtenerConexion())
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
    