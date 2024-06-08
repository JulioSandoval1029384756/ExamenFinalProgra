using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Database
    {
        private SqlConnection connection;
        private string connectionString;

        public Database()
        {
            connectionString = @"Data Source=LAPTOP-P2NACEBG\SQLEXPRESS;Initial Catalog=Usuarios;User ID=sa;Password=sarce123;";
            connection = new SqlConnection(connectionString);
            CreateTables();
        }

        private void CreateTables()
        {
            OpenConnection();
            string createAlumnosTable = @"CREATE TABLE IF NOT EXISTS Alumnos (
                                        carnet NVARCHAR(50) PRIMARY KEY,
                                        nombre NVARCHAR(100),
                                        telefono NVARCHAR(20),
                                        grado NVARCHAR(50),
                                        usuario NVARCHAR(50))";
            string createUsuariosTable = @"CREATE TABLE IF NOT EXISTS Usuarios (
                                        usuario NVARCHAR(50) PRIMARY KEY,
                                        nombre NVARCHAR(100))";
            SqlCommand command = new SqlCommand(createAlumnosTable, connection);
            command.ExecuteNonQuery();
            command.CommandText = createUsuariosTable;
            command.ExecuteNonQuery();
            CloseConnection();
        }

        private void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
        }

        private void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }

        public void InsertAlumno(string carnet, string nombre, string telefono, string grado, string usuario)
        {
            OpenConnection();
            string query = "INSERT INTO Alumnos (carnet, nombre, telefono, grado, usuario) " +
                           "VALUES (@carnet, @nombre, @telefono, @grado, @usuario)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@carnet", carnet);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@telefono", telefono);
            command.Parameters.AddWithValue("@grado", grado);
            command.Parameters.AddWithValue("@usuario", usuario);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public void UpdateAlumno(string carnet, string nombre, string telefono, string grado, string usuario)
        {
            OpenConnection();
            string query = "UPDATE Alumnos SET nombre = @nombre, telefono = @telefono, grado = @grado, usuario = @usuario WHERE carnet = @carnet";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@carnet", carnet);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@telefono", telefono);
            command.Parameters.AddWithValue("@grado", grado);
            command.Parameters.AddWithValue("@usuario", usuario);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public void DeleteAlumno(string carnet)
        {
            OpenConnection();
            string query = "DELETE FROM Alumnos WHERE carnet = @carnet";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@carnet", carnet);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public List<string> GetAlumnos()
        {
            OpenConnection();
            string query = "SELECT carnet FROM Alumnos";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<string> alumnos = new List<string>();
            while (reader.Read())
            {
                alumnos.Add(reader["carnet"].ToString());
            }
            CloseConnection();
            return alumnos;
        }

        public Dictionary<string, string> GetUsuarios()
        {
            OpenConnection();
            string query = "SELECT usuario, nombre FROM Usuarios";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            Dictionary<string, string> usuarios = new Dictionary<string, string>();
            while (reader.Read())
            {
                usuarios.Add(reader["usuario"].ToString(), reader["nombre"].ToString());
            }
            CloseConnection();
            return usuarios;
        }

        public Dictionary<string, string> GetAlumno(string carnet)
        {
            OpenConnection();
            string query = "SELECT * FROM Alumnos WHERE carnet = @carnet";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@carnet", carnet);
            SqlDataReader reader = command.ExecuteReader();
            Dictionary<string, string> alumno = new Dictionary<string, string>();
            if (reader.Read())
            {
                alumno["carnet"] = reader["carnet"].ToString();
                alumno["nombre"] = reader["nombre"].ToString();
                alumno["telefono"] = reader["telefono"].ToString();
                alumno["grado"] = reader["grado"].ToString();
                alumno["usuario"] = reader["usuario"].ToString();
            }
            CloseConnection();
            return alumno;
        }
    }
}