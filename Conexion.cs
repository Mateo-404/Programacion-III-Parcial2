using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PracticaForm
{
    public class Conexion
    {
        public DataTable GetData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM TableName";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.Fill(dataTable);
                }
                catch (SqlException ex)
                {
                    // Manejar excepción
                    Console.WriteLine("Error: " + ex.Message);
                }
                return dataTable;
            }
        }
    }
}
