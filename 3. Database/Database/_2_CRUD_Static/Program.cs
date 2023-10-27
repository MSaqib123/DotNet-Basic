using System;
using System.Data.SqlClient;

namespace _2_CRUD_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string connectionString = "Data Source = SAQIB\\SAQIB;Initial Catalog=xyz; Integrated Security=true";
            //SqlConnection con = new SqlConnection(connectionString);

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

            //try
            //{
            //    //con.Close();
            //    //con.Open();
            //    ////________________ 1. Create / Insert ____________________
            //    ////command sirf
            //    ////SqlCommand insertCommand = new SqlCommand("insert into customer values ('saqib',1)", con);
            //    ////execute comand
            //    ////insertCommand.ExecuteNonQuery();  //executeNonQuery  ????    agaa parhain gaa
            //    //Console.WriteLine("rows inserted");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex);
            //}


        }
    }
}
