using GestionGastos.Config;
using GestionGastos.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionGastos.DAO
{
    public class GastoDAO
    {
        ConexionSqlite conexionDB = new ConexionSqlite();



        //eSTE CODIGO ES PARA CREAR LA  TABLA SQLITE
        public void CrearTabla()
        {
            using (var cn = conexionDB.ObtenerConexion())
            {

                cn.Open();

                string sql = @"CREATE TABLE IF NOT EXISTS gasto
            (
                IdGasto INTEGER PRIMARY KEY AUTOINCREMENT,
                Descripcion TEXT NOT NULL,
                Categoria TEXT NOT NULL,
                Monto REAL NOT NULL,
                Fecha TEXT NOT NULL,
                MetodoPago TEXT NOT NULL
            );";

                using (var cmd = new SqliteCommand(sql, cn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }


        //CODIGO PARA INSERTAR DATOS

        public void InsertarGasto(Gastos gasto)
        {
            using (var cn = conexionDB.ObtenerConexion())
            {
                cn.Open();

                string sql = @"INSERT INTO gasto
                  (
                   Descripcion,
                   Categoria,
                   Monto,
                   Fecha,
                   MetodoPago
                   ) VALUES
                  (
                  $descripcion,
                  $categoria,
                  $monto,
                  $fecha,
                  $metodoPago
                  );";

                using (var cmd = new SqliteCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("$descripcion", gasto.Descripcion);
                    cmd.Parameters.AddWithValue("$categoria", gasto.Categoria);
                    cmd.Parameters.AddWithValue("$monto", gasto.Monto);
                    cmd.Parameters.AddWithValue("$fecha", gasto.Fecha.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("$metodoPago", gasto.MetodoPago);

                    cmd.ExecuteNonQuery();

                }
            }

        }

        //Este codigo es para listar

        public List<Gastos> Lista()
        {
            var lista = new List<Gastos>();

            using (var cn = conexionDB.ObtenerConexion())
            {
                // para abrir conexion
                cn.Open();

                string sql = @"SELECT
                    IdGasto,
                    Descripcion,
                    Categoria,
                    Monto,
                    Fecha,
                    MetodoPago
                FROM gasto
                ORDER BY Fecha DESC;";

                using (var cmd = new SqliteCommand(sql, cn))
                {
                    using (var resultado = cmd.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            lista.Add(new Gastos
                            {
                                IdGasto = resultado.GetInt32(0),
                                Descripcion = resultado.GetString(1),
                                Categoria = resultado.GetString(2),
                                Monto = Convert.ToDecimal(resultado.GetValue(3)),
                                Fecha = DateTime.ParseExact(resultado.GetString(4), "yyyy-MM-dd", null),
                                MetodoPago = resultado.GetString(5)
                            });
                        }
                    }
                }
            }

            return lista;

        }


        //Este codigo es para actualizar

        public void Actualizar(Gastos gasto)
        {
            using (var cn = conexionDB.ObtenerConexion())
            {
                cn.Open();

                string sql = @"UPDATE gasto SET
                                 Descripcion = $descripcion,
                                 Categoria = $categoria,
                                 Monto = $monto,
                                 Fecha = $fecha,
                                 MetodoPago = $metodoPago
                             WHERE idGasto = $idgasto;";

                using (var cmd = new SqliteCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("$idgasto", gasto.IdGasto);
                    cmd.Parameters.AddWithValue("$descripcion", gasto.Descripcion);
                    cmd.Parameters.AddWithValue("$categoria", gasto.Categoria);
                    cmd.Parameters.AddWithValue("$monto", gasto.Monto);
                    cmd.Parameters.AddWithValue("$fecha", gasto.Fecha.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("$metodoPago", gasto.MetodoPago);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        //Este codigo es para eliminar

        public void Eliminar(int id)
        {
            using (var cn = conexionDB.ObtenerConexion())
            {
                cn.Open();

                string sql = @"DELETE FROM gasto WHERE IdGasto=$id";

                using (var cmd = new SqliteCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("$id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
