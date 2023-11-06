using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;


namespace Data
{
    public class DCustomer
    {
        public static string connectionString = "Data Source=LAB1504-22\\SQLEXPRESS;Initial Catalog=master;Integrated Security=true";
        public static List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Consulta SQL para seleccionar datos
                string query = "select * from customers";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Verificar si hay filas   
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Leer los datos de cada fila

                                customers.Add(new Customer
                                {
                                    CustomerId = (int)reader["customer_id"],
                                    Name = reader["name"].ToString(),
                                    Address = reader["address"].ToString(),
                                    Phone = reader["phone"].ToString(),
                                    Active = (bool)reader["active"],

                                });

                            }
                        }
                    }
                }
                // Cerrar la conexión
                connection.Close();


            }

            return customers;
        }
    }
}
