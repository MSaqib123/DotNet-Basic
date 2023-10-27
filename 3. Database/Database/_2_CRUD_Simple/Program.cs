using System;
using System.Data;
using System.Data.SqlClient;

namespace _2_CRUD_Simple
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string connectionString = "Data Source = SAQIB\\SAQIB;Initial Catalog=xyz; Integrated Security=true";
            SqlConnection con = new SqlConnection(connectionString);

            #region SQL_Work
            /*
             create table customer(
	            id int primary key identity,
	            name varchar(25),
	            gender bit
            )

            --- Select ---
            select * from customer

            --- insert ---  0 female  , 1 male
            insert into customer values ('saqib',1);

            --- update ----
            update customer 
            set name = '' , gender = 2
            where id = 1;

            --- delete ----
            delete customer 
            where id = 1;
             */
            #endregion

            try
            {
                con.Open();

                //________________ 1. Create / Insert ____________________
                Console.WriteLine("=========== Insert ==============");
                //command sirf
                SqlCommand insertCommand = new SqlCommand("insert into customer values ('bilal Ali',1)", con);
                //execute comand
                int rowAffected = insertCommand.ExecuteNonQuery();  //ExecuteNonQuery   ---> Insert,Update,Delete
                Console.WriteLine("{0} rows inserted" , rowAffected);


                //________________ 3. Update ____________________
                Console.WriteLine("=========== Update ==============");
                SqlCommand updateCommand = new SqlCommand("UPDATE Customer SET name = 'Akram' , gender='1' WHERE id=2", con);
                rowAffected = updateCommand.ExecuteNonQuery();  //Insert,Update,deltet
                Console.WriteLine("{0} rows updated", rowAffected);


                //________________ 4. Delete ____________________
                Console.WriteLine("=========== Delete ==============");
                SqlCommand deleteCommand = new SqlCommand("DELETE FROM Customer WHERE id=2", con); //1
                rowAffected = deleteCommand.ExecuteNonQuery();  //Insert,Update,deltet
                Console.WriteLine("{0} rows deleted", rowAffected);




                //________________ 2. Read / Select ____________________
                Console.WriteLine("=========== Select ==============");
                SqlCommand selectCommand = new SqlCommand("SELECT * FROM Customer", con);
                var reader = selectCommand.ExecuteReader();  //select  DQL (data Query language)
                while (reader.Read())
                {
                    string gender;
                    if (reader.GetBoolean(reader.GetOrdinal("gender")) == true)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    Console.WriteLine("\t{0} \t{1} \t{2}", reader["id"], reader["name"], gender);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            finally
            {
                // Close the connection
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
