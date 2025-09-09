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
using S7.Net;
using static Google.Protobuf.Reflection.FieldOptions.Types;

namespace FabTrack_Admin
{
    public class DbConfig
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string SslMode { get; set; }
    }
    public class PlcConfig
    {
        public string IpAddress { get; set; }
        public int Rack { get; set; }
        public int Slot { get; set; }
    }

    public class ConfigRoot
    {
        public DbConfig Database { get; set; }
        public PlcConfig PLC { get; set; }

    }
    public class database
    {


        public MySqlConnection connection;
        public string connectionString;
        // PLC properties
        public string PlcIp { get; set; }
        public short PlcRack { get; set; }
        public short PlcSlot { get; set; }

        public string PlcOutput { get; set; }

        // Constructor
        public database()
        {
            try
            {
                string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FabTrack");
                string path = Path.Combine(folder, "config.json");

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
                        },
                        PLC = new PlcConfig
                        {
                            IpAddress = "192.168.0.1",
                            Rack = 0,
                            Slot = 1
                        }
                    };

                    string defaultJson = JsonSerializer.Serialize(defaultConfig, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(path, defaultJson);
                }

                // Leer y deserializar
                string json = File.ReadAllText(path);
                var root = JsonSerializer.Deserialize<ConfigRoot>(json);

                // Config BD
                var db = root.Database;
                connectionString = $"Server={db.Server};Database={db.Database};User ID={db.User};Password={db.Password};SslMode={db.SslMode};";
                connection = new MySqlConnection(connectionString);

                // Config PLC
                var plc = root.PLC;
                PlcIp = plc.IpAddress;
                PlcRack = (short)plc.Rack;
                PlcSlot = (short)plc.Slot;
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
        public DataTable ExecuteQuery(string query, Dictionary<string, object> parametros)
        {
            DataTable dt = new DataTable();

            try
            {
                if (OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Solo agregamos parámetros si no es null
                        if (parametros != null)
                        {
                            foreach (var par in parametros)
                                cmd.Parameters.AddWithValue(par.Key, par.Value);
                        }

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }

                    CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en ExecuteQuery con parámetros: " + ex.Message);
            }

            return dt;
        }


        // INSERT, UPDATE, DELETE → retorna filas afectadas
        // INSERT, UPDATE, DELETE con parámetros
        public int ExecuteNonQuery(string query, Dictionary<string, object> parametros)
        {
            int rowsAffected = 0;
            try
            {
                if (OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        if (parametros != null)
                        {
                            foreach (var par in parametros)
                                cmd.Parameters.AddWithValue(par.Key, par.Value);
                        }

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    CloseConnection();
                }
            }
            catch (Exception ex)
            {
                Clipboard.SetText(ex.ToString());
                MessageBox.Show("Error en NonQuery con parámetros: " + ex.Message);

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
                                numero_empleado, telefono, email, turno, activo
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
                    empleado["activo"] = reader["activo"].ToString();
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
        public Dictionary<string, string> GetLectorPorNombre(string nombre)
        {
            Dictionary<string, string> lector = new Dictionary<string, string>();

            try
            {
                OpenConnection();
                string query = @"SELECT id, serie, nombre, ubicacion,direccion_plc, comentarios, activo
                         FROM lectores 
                         WHERE nombre LIKE @name LIMIT 1"; // Limit 1 si solo quieres el primero

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", $"%{nombre}%"); // % comodín para LIKE

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lector["id"] = reader["id"].ToString();
                    lector["serie"] = reader["serie"].ToString();
                    lector["nombre"] = reader["nombre"].ToString();
                    lector["ubicacion"] = reader["ubicacion"].ToString();
                    lector["direccion_plc"] = reader["direccion_plc"].ToString();
                    lector["comentarios"] = reader["comentarios"].ToString();
                    lector["activo"] = reader["activo"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener lector: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return lector;
        }

        public bool EscribirBoolPLC(string direccion, bool valor)
        {
            try
            {
                using (Plc plc = new Plc(CpuType.S71200, PlcIp, PlcRack, PlcSlot))
                {
                    plc.Open();

                    if (!plc.IsConnected)
                    {
                        MessageBox.Show("❌ No se pudo conectar al PLC.");
                        return false;
                    }

                    // Escribir el valor
                    plc.Write(direccion, valor);
                    // Console.WriteLine($"✅ Valor {valor} escrito en {direccion}.");

                    // Confirmar la escritura
                    bool confirmado = (bool)plc.Read(direccion);
                    // Console.WriteLine($"📖 Valor confirmado: {confirmado}");

                    plc.Close();
                    return confirmado == valor;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Error al escribir BOOL en el PLC: " + ex.Message);
                return false;
            }
        }


    }


}
