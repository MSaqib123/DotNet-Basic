using System;
using System.Data;
using System.Data.SqlClient;

namespace _1_Database_connection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //__________________________ DataBase + Server Side + Database__________________________
            #region importent
            //1. View  simple  View hotaaa ha
            //2. Server Side  (c# language)    
            //3. Database  (SQL)
            #endregion


            //____________________________ Flow _____________________________
            #region Flow
            //1st  User Ataa haa    View ko   Use  krtaa hova   ---> Request  krtaa han   (see the list of Employee)
            //2nd  Request  Goest                               ---> Server Side Language 
            //3rd  Server Takes Request  Give ther Result  to   --->  User      (her is list of Employee)

            //Means    Server Side  is   -===== Bridge =====-   b/w   View and Database

            #endregion


            //___________________________________ Connect ServerSide C# --> To Database  _______________________________
            //1. go to NuGet manager  --->  Install  --->  System.Data.SqlClient    --> library       (its proved connection stirng and other packages to connect with MSSQL)
            //2. Define  Connection String of your Database   --->   (database khan para hova ha)
            //   string con = "Data Source=serverName; Initial Catalog=databaseName; User Id = userName; Password=yourpasword"
            //  if no password , id  ====> pass   integrated Security= true


            //_____________________ 1. Defined Connection String (Address) _________________
            string connectionString = "Data Source = SAQIB\\SAQIB;Initial Catalog=xyz; Integrated Security=true";
            //_____________________ 2. Install  syste.data.sqlClient ____________
            //_____________________ 3. SqlConnection Class use  ____________ is class me bhot sara buildIn method, properties hon ga  (same as OOP)
            SqlConnection con = new SqlConnection(connectionString);



            //___________________ (Must) Open and Closing connection ____________________
            //con.Open();

            ////_____________________ 4. check Connection  ____________
            //if(con.State == ConnectionState.Open)
            //{
            //    Console.WriteLine("Connection Successfuly Open");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Conection Address");
            //}

            //con.Close();


            //______________________________ Try Catch _______________________________
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connection Successfuly Open");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                //throw;
                Console.WriteLine("Failed to open connection: " + ex.Message);
            }



            //______________________________ Using Block _______________________________
            //________ banifit _____
            //you just need to  Open   Connection
            //by  Using Block ---> Connection Automaticly  Close  after   using block Completed
            using (SqlConnection c = new SqlConnection(connectionString))
            {
                c.Open();
                if (c.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connection Successfuly Open");
                }

                //--- when Compile   go out using block   --->  c.Close  Automaticlay
            }

                
            
        }
    }
}
