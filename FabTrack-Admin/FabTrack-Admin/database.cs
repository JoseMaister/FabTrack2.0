using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace FabTrack_Admin
{
    public class database
    {


        public MySqlConnection connection;
        public string connectionString;

        // Constructor
        public database()
        {
            try
            {
                // Carpeta dentro del perfil del usuario
                string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FabTrack");
                string path = Path.Combine(folder, "config.json");

                // Crear la carpeta si no existe
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                // Crear archivo con valores por defecto si no existe
                if (!File.Exists(path))
                {
                    var defaultConfig = new ConfigRoot
                    {
                        Database = new DbConfig
                        {
                            Server = "localhost",
                            Database = "fabtrack",
                            User = "root",
                            Password = "",
                            SslMode = "none"
                        }
                    };

                    string defaultJson = JsonSerializer.Serialize(defaultConfig, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(path, defaultJson);
                }

                // Leer archivo JSON
                string json = File.ReadAllText(path);

                // Deserializar
                var root = JsonSerializer.Deserialize<ConfigRoot>(json);
                var db = root.Database;

                // Construir cadena de conexión
                connectionString = $"Server={db.Server};Database={db.Database};User ID={db.User};Password={db.Password};SslMode={db.SslMode};";

                // Inicializar conexión
                connection = new MySqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error cargando configuración: " + ex.Message);
            }
        }

        // Abrir conexión
        public bool OpenConnection()
        {
            try
            {
                // Código para abrir conexión
                // Por ejemplo:
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }


        // Cerrar conexión
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        // SELECT → retorna DataTable
        public DataTable ExecuteQuery(string query, Dictionary<string, object> parametros = null)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                if (parametros != null)
                {
                    foreach (var p in parametros)
                        cmd.Parameters.AddWithValue(p.Key, p.Value);
                }

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        /*    public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en consulta: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }*/

        // INSERT, UPDATE, DELETE → retorna filas afectadas
        public int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en NonQuery: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return rowsAffected;
        }

        // Para obtener un solo valor (ej. COUNT(*))
        public object ExecuteScalar(string query)
        {
            object result = null;
            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Scalar: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }
        public Dictionary<string, string> GetEmpleado(string empleadoID)
        {
            Dictionary<string, string> empleado = new Dictionary<string, string>();

            try
            {
                OpenConnection();
                string query = @"SELECT id, nombre, apellido_paterno, apellido_materno, 
                                numero_empleado, telefono, email, turno
                         FROM usuarios 
                         WHERE numero_empleado = @id";
               

                // Copiar automáticamente al portapapeles
               
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", empleadoID);
                
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    empleado["id"] = reader["id"].ToString();
                    empleado["nombre"] = reader["nombre"].ToString();
                    empleado["apellido_paterno"] = reader["apellido_paterno"].ToString();
                    empleado["apellido_materno"] = reader["apellido_materno"].ToString();
                    empleado["numero_empleado"] = reader["numero_empleado"].ToString();
                    empleado["telefono"] = reader["telefono"].ToString();
                    empleado["email"] = reader["email"].ToString();
                    empleado["turno"] = reader["turno"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener empleado: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return empleado;
        }

     

    }

    public class DbConfig
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string SslMode { get; set; }
    }
    public class ConfigRoot
    {
        public DbConfig Database { get; set; }
    }
}
