using System;
using System.Data;
using System.Data.SqlClient;

namespace _4_E_Commers_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the connection string
            string connectionString = "Data Source=SAQIB\\SAQIB;Initial Catalog=consoleEcommers;Integrated Security=true;";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Get the product data
                SqlDataAdapter productAdapter = new SqlDataAdapter("SELECT * FROM Products", connection);
                DataTable productTable = new DataTable();
                productAdapter.Fill(productTable);

                // Get the customer data
                SqlDataAdapter customerAdapter = new SqlDataAdapter("SELECT * FROM Customers", connection);
                DataTable customerTable = new DataTable();
                customerAdapter.Fill(customerTable);

                // Get the order data
                SqlDataAdapter orderAdapter = new SqlDataAdapter("SELECT * FROM Orders", connection);
                DataTable orderTable = new DataTable();
                orderAdapter.Fill(orderTable);

                // Print the product data
                Console.WriteLine("Products:");
                foreach (DataRow row in productTable.Rows)
                {
                    Console.WriteLine("{0}\t{1}\t{2:c}", row["ProductId"], row["ProductName"], row["Price"]);
                }

                // Print the customer data
                Console.WriteLine("Customers:");
                foreach (DataRow row in customerTable.Rows)
                {
                    Console.WriteLine("{0}\t{1} {2}\t{3}", row["CustomerId"], row["FirstName"], row["LastName"], row["Email"]);
                }

                // Print the order data
                Console.WriteLine("Orders:");
                foreach (DataRow row in orderTable.Rows)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3:c}", row["OrderId"], row["CustomerId"], row["OrderDate"], row["TotalAmount"]);
                }

                // Prompt the user to create an order
                Console.WriteLine("Enter a customer ID to create an order:");
                int customerId = Convert.ToInt32(Console.ReadLine());

                // Start a transaction
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Insert the order into the database
                    SqlCommand command = new SqlCommand("INSERT INTO Orders (CustomerId, OrderDate, TotalAmount) VALUES (@CustomerId, @OrderDate, @TotalAmount); SELECT SCOPE_IDENTITY();", connection, transaction);
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    command.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    command.Parameters.AddWithValue("@TotalAmount", 0);
                    int orderId = Convert.ToInt32(command.ExecuteScalar());

                    // Add items to the order
                    while (true)
                    {
                        Console.WriteLine("Enter a product ID to add to the order (or 'done' to finish):");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "done")
                        {
                            break;
                        }
                        int productId = Convert.ToInt32(input);

                        Console.WriteLine("Enter the quantity:");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        // Update the product table
                        DataRow[] productRows = productTable.Select("ProductId = " + productId);
                        DataRow productRow = productRows[0];
                        productRow["UnitsInStock"] = Convert.ToInt32(productRow["UnitsInStock"]) - quantity;

                        // Update the order table
                        DataRow orderRow = orderTable.NewRow();
                        orderRow["OrderId"] = orderId;
                        orderRow["ProductId"] = productId;
                        orderRow["CustomerId"] = productId;
                        orderRow["Quantity"] = quantity;
                        orderTable.Rows.Add(orderRow);

                        // Calculate the total amount of the order
                        decimal totalAmount = 0;
                        foreach (DataRow orderItem in orderTable.Rows)
                        {
                            DataRow[] productRows2 = productTable.Select("ProductId = " + orderItem["ProductId"]);
                            DataRow productRow2 = productRows2[0];
                            totalAmount += Convert.ToDecimal(productRow2["Price"]) * Convert.ToInt32(orderItem["Quantity"]);
                        }
                        // Update the order table with the total amount
                        DataRow[] orderRows = orderTable.Select("OrderId = " + orderId);
                        DataRow orderRow2 = orderRows[0];
                        orderRow2["TotalAmount"] = totalAmount;

                        // Update the database
                        SqlDataAdapter orderAdapter2 = new SqlDataAdapter("SELECT * FROM Orders", connection);
                        SqlCommandBuilder builder = new SqlCommandBuilder(orderAdapter2);
                        orderAdapter2.Update(orderTable);

                        // Commit the transaction
                        transaction.Commit();

                        Console.WriteLine("Order created successfully!");
                    }
                }
                catch (Exception ex)
                {
                    // Roll back the transaction
                    transaction.Rollback();

                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}