using System;
using System.Data;
using System.Data.SqlClient;

namespace Mahrud_Bees
{
    public class DBAccess
    {
        private string connectionString = "Data Source=DESKTOP-OGOHV4F\\SQLEXPRESS01;Initial Catalog=Bees;Integrated Security=True";

        public int ExecuteScalar(SqlCommand command)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command.Connection = connection;
                object result = command.ExecuteScalar();
                return Convert.ToInt32(result); // Convert to int assuming scalar result is int
            }
        }

        public int ExecuteNonQuery(SqlCommand command)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command.Connection = connection;
                return command.ExecuteNonQuery();
            }
        }

        public DataTable ExecuteQuery(SqlCommand command)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command.Connection = connection;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public int InsertCustomer(string firstName, string lastName, string email, string phone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Customers (First_Name, Last_Name, Email, Phone)
                    VALUES (@FirstName, @LastName, @Email, @Phone)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Phone", phone);

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public int InsertOrder(int customerId, string item, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Orders (Customer_ID, Item, Quantity)
                    VALUES (@CustomerID, @Item, @Quantity)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.Parameters.AddWithValue("@Item", item);
                    command.Parameters.AddWithValue("@Quantity", quantity);

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public int InsertProduct(string name, decimal price, int supplierId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Products (Name, Price, Supplier_ID)
                    VALUES (@Name, @Price, @Supplier_ID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Supplier_ID", supplierId);

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public int DeleteSupplier(int supplierId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    DELETE FROM Suppliers
                    WHERE Supplier_ID = @SupplierID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SupplierID", supplierId);

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetCustomerData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Customers";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dtCustomers = new DataTable();
                    adapter.Fill(dtCustomers);
                    return dtCustomers;
                }
            }
        }

        public DataTable GetOrdersData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Orders";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dtOrders = new DataTable();
                    adapter.Fill(dtOrders);
                    return dtOrders;
                }
            }
        }

        public DataTable GetProductsData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Products";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dtProducts = new DataTable();
                    adapter.Fill(dtProducts);
                    return dtProducts;
                }
            }
        }

        public DataTable GetSuppliersData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Suppliers";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dtSuppliers = new DataTable();
                    adapter.Fill(dtSuppliers);
                    return dtSuppliers;
                }
            }
        }
    }
}
