using System;
using System.Data;
using System.Data.SqlClient;

namespace _3_Importent_Classes_Method_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source = SAQIB\\SAQIB;Initial Catalog=xyz; Integrated Security=true";

            //goto start;

            //___________________________ DataBase Class ________________________
            #region Database Classes
            //____ 1. SqlConnection ______
            //stables connection b/w C# and Sql

            //____ 2. SqlCommand ______
            //to procceedd Querry  before Executing...    execute hona sa phlaa go Query lkhin ga is me

            //____ 3. SqlDataReader _______
            //to Read  Multiples record from SQL

            //____ 4. SqlDataAdapter _______
            //set of  Data Commands   ...

            //____ 5. SqlTransaction ____
            //treansaction to perform at  SQL server DAtabase

            //____ 6. SqlCommandBuilder
            //Automatically generates single-table commands that are used to reconcile changes made to a DataSet

            //____ 7. DataSet ___
            //Represents an in-memory cache of data that can be queried, updated, and manipulated as a disconnected object.
            #endregion


            //___________ 2. SQL_Command _________________
            #region SqlCommand class


            //_____________ 1. Methods __________
            #region Methods
            //1. ExecuteNonQuery() 
            using (SqlConnection connection = new SqlConnection("address"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Customers (CustomerName, ContactName, City) VALUES ('John Smith', 'John Doe', 'Seattle')", connection);
                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine("Rows affected: " + rowsAffected);
            }


            //2. ExecuteScalar()   give single value result
            using (SqlConnection connection = new SqlConnection("address"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Customers", connection);
                int count = (int)command.ExecuteScalar();

                Console.WriteLine("Number of customers: " + count);
            }


            //3. ExecuteReader()   for multipler Recors
            using (SqlConnection connection = new SqlConnection("address"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Customers", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["CustomerName"] + " - " + reader["City"]);
                }

                reader.Close();
            }



            //4. AddWithValue()      -->  used when to pass Values With Parameters
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Customer VALUES (@FirsName, @LastName, @Email ,@TotalOrder,@TotalOrderAmount)", connection);
                command.Parameters.AddWithValue("@FirsName", "Jane Doe");
                command.Parameters.AddWithValue("@LastName", "Jane Smith");
                command.Parameters.AddWithValue("@Email", "NewYork");
                command.Parameters.AddWithValue("@TotalOrder", 5);
                command.Parameters.AddWithValue("@TotalOrderAmount", 400);

                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine("Rows affected: " + rowsAffected);
            }
            
            //___ fatching single Row
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE FirstName = @fName", connection);
                command.Parameters.AddWithValue("@fName", "Jane");

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["FirstName"] + " - " + reader["LastName"] + " - " + reader["Email"]);
                }

                reader.Close();
            }
            #endregion


            //_____________ 2. Properties _____________
            #region Properties

            //___CommandText:____
            //Gets or sets the SQL statement or stored procedure to execute.
            //SqlCommand command = new SqlCommand();
            //command.CommandText = "SELECT * FROM Customers";


            //____CommandTimeout:____
            //Gets or sets the number of seconds to wait before terminating the attempt to execute a command and generating an error.
            //SqlCommand command = new SqlCommand();
            //command.CommandText = "SELECT * FROM Customers";
            //command.CommandTimeout = 30; // wait for 30 seconds before timing out

            //_____CommandType:
            //Gets or sets a value indicating whether the CommandText property represents a SQL statement or a stored procedure.
            //SqlCommand command = new SqlCommand();
            //command.CommandText = "GetCustomerDetails";
            //command.CommandType = CommandType.StoredProcedure; // command is a stored procedure



            //_____ Connection: _______
            //Gets or sets the SqlConnection object used by the SqlCommand object to execute the command.

            //SqlCommand command = new SqlCommand();
            //command.CommandText = "SELECT * FROM Customers WHERE Country = @Country";
            //SqlParameter param = new SqlParameter("@Country", "USA");
            //command.Parameters.Add(param);


            //____ Parameters: ______
            //Gets the collection of parameters used by the command.
            //SqlConnection connection = new SqlConnection(connectionString);
            //SqlCommand command = new SqlCommand();
            //command.Connection = connection;

            //____Transaction: 
            //Gets or sets the transaction within which the SqlCommand object executes.
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();
            //SqlTransaction transaction = connection.BeginTransaction();
            //SqlCommand command = new SqlCommand();
            //command.Connection = connection;
            //command.Transaction = transaction;
            #endregion

            #endregion


            //__________ 3. SqlDataAdapter____________
            #region MyRegion
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Customers", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable customersTable = new DataTable();
                adapter.Fill(customersTable);

                // Use the customersTable DataTable
            }
            #endregion



            //__________ 4. SqlDataReader ____________
            #region MyRegion
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Customers", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["CustomerName"]);
                }

                reader.Close();
            }
            #endregion


            //__________ 5. SqlTransaction ____________
            #region MyRegion
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Execute some SQL commands here

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Transaction rolled back: " + ex.Message);
                }
            }
            #endregion


            //__________ 6. DataSet ____________
            #region MyRegion
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Customers", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Customers");

                // Use the dataSet DataSet
            }
            #endregion



            //__________ 7. SqlCommandBuilder __________
            #region MyRegion
            string selectCommand = "SELECT * FROM Customers";
            // Create a new DataSet and fill it with data from the database
            DataSet dataSet1 = new DataSet();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommand, connection);
                adapter.Fill(dataSet1, "Customers");
            }
            // Modify the data in the DataSet here

            //after 2 minuts  new Recrod are  insert  then we have to update  dataset
            // Update the database with the changes made to the DataSet
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customers", connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                // Modify the DataSet here
                adapter.Update(dataSet1, "Customers");
            }
            #endregion



        }
    }
}
