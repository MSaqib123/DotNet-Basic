using System;

namespace _2_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //____________________Variables____________________________
            #region Variables
            /*
            //Varible ===> is Container   ==> to Store   Data 
            //Exp.    User (Name,phone,age,password)

            int phone = 0341298056;  //number == Integers hota han programing
            string name = "Saqib";  //charactor == String
            float age = 25;       //float  Big Data
            string password = "Rashid123";

            //Show Results to   USER
            Console.WriteLine("Name : " + name);
            Console.WriteLine("age : " + age);
            Console.WriteLine("phone : " + phone);
            Console.WriteLine("password : " + password);

            //Stop Screen  // take values from User
            Console.ReadLine();



            //_________________________ More Variables _____________________
            //__________ Integer Variables ___________
            int number = 1;
            Console.WriteLine(number);

            byte byteNumber =  52; // 0 between 255   values     -- 8 bit size
            Console.WriteLine(byteNumber);

            short shortNumber = 444; //   -- 16 bit  size
            Console.WriteLine(shortNumber);

            long longNumber = 2434234;  // 64 bit   size 
            Console.WriteLine(longNumber);

            float pointValue1 = 55.55f;  //f = prefex;
            Console.WriteLine(pointValue1);

            double pointValue2 = 5.55d;  //d = suffix;
            Console.WriteLine(pointValue2);

            decimal decimalNumber =  55.555M; //28 digit 
            Console.WriteLine(decimalNumber);


            //_________ string variables ____________
            string stri = "Pakistna";
            char charstring = 'p'; //single chractor


            //_________ dynamic variables ____________  
            //runtime par  Values  DataType  change kr sktaa han
            dynamic mydynamic = 10;
            Console.WriteLine(mydynamic);
            Console.WriteLine(mydynamic.GetType());


            mydynamic = "Pakistan zindaba";
            Console.WriteLine(mydynamic);
            Console.WriteLine(mydynamic.GetType());

            */
            #endregion

            //____________________Declaration & Initialization (Syntex)____________________________
            #region Initi / Declare

            ////______Together________
            //int age /*dec*/      = 25 /*Initit*/;

            ////______Seprate_______
            //string name; //declar
            //name = "Pakistan"; //init

            #endregion

            //____________________Implicit vs Explicit Variable____________________________
            #region Implicit vs Explicit
            /*
            //___________Implicit Variable___________
            //wo Variable ji me    (int,string,float,....) sub  a   gain   Implicit
            var empName = "Saqib"; //string
            var empID = 123; //int
            var empAge = 23; //string
            var empJob = "DataEntry";

            //___________Explicit Variable___________  Best Way To Make Variables
            //jasa  Data   Wassi  Value
            int userAge = 35;
            string userName = "m435775353@gmail.com";
            double password = 12345;
            */
            #endregion


            //____________________Implicit Explicit Convertion of Variable____________________________
            #region Implicit & Explicet  Convertion
            //________1. Implicit Convertion__________
            int iV = 25;
            float fV= iV; //

            int v1 = 45;
            int v2 = v1;

            //________1. Explicit Convertion__________
            //forcly Convert
            int iV2 = 25;
            string sV = Convert.ToString(iV2);
            

            string s = "Pakistan";
            int i = int.Parse(s);
            #endregion

            //____________________Compile Time  , Run Time____________________________
            #region Compile & Run
            //_______1 Compile_______
            //During Coding

            //_______2 Run Time_______
            //During Runing Program   (code ka phtnaa)
            #endregion

            //____________________Program_________________
            #region Program

            ////---top Par declare krtaa han---  Uper saa code Execute hotaa ha---
            //string uName,uPassword;
            //int uAge;


            //Console.Write("Enter YourName : ");
            ///*string*/ uName = Console.ReadLine(); //value store in   Variable

            //Console.Write("Enter YourAge : ");
            ///*int*/uAge = int.Parse(Console.ReadLine());  //store in Variable       (convert String to Int)

            //Console.Write("Enter urPassword : ");
            ///*string*/ uPassword = Console.ReadLine();


            //Console.WriteLine("\n_______User Values_________");
            //Console.WriteLine("Your Name = " + uName);
            //Console.WriteLine("Your Age = " + uAge);
            //Console.WriteLine("Your Password = " + uPassword);

            //Console.WriteLine("\n");

            #endregion

            //____________________Task   (Point , Math.Round())________________
            #region Task
            ////take 2 numbers from user   1 Operator  (+,-,*,/)
            ////Calculator
            //Console.WriteLine("\n\n");

            //int v1, v2;

            //Console.Write("Enter 1st Number : ");
            //v1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter 2nd Number : ");
            //v2 = int.Parse(Console.ReadLine());

            //int add = v1 + v2;
            //int sub = v1 - v2;
            //int mult = v1 * v2;
            //double div = (double)v1 / (double)v2;     //point Values    Float DataType
            //Console.WriteLine("Add \t= \t" + add);
            //Console.WriteLine("sub \t= \t" + sub);
            //Console.WriteLine("mult \t= \t" + mult);
            //Console.WriteLine("div \t= \t" + Math.Round(div, 4));
            #endregion

            //____________________String Concatination Formate________________
            #region String_Concatination_Formate
            string uName = "Muhammad Saqib";
            int Age = 45;

            //___(+) Concatination Formate______
            Console.WriteLine("\n____(+)_Concatination______\n UserName : " + uName + " , Age : " + Age);

            //___(Interpolation) Concatination Formate______
            Console.WriteLine("\n____Interpolation_Concatination_____\n");
            Console.WriteLine($"UserName : {uName} , Age : {Age}");

            //___(Composite) Concatination Formate______
            Console.WriteLine("\n____Composite_Concatination_____\n");
            Console.WriteLine("UserName : {0} , Age : {1}\n", uName, Age);
            #endregion


            //____________________Var , Dynamice  Variable________________
            #region var , dynamic
            //__________var_________
            //var (can have all datatype)
            var a = 25;
            var b = "Pakistan";
            var c = true;

            //__________dynamic_________
            dynamic x = 445;
            dynamic y = "India";
            dynamic z = true;


            //____________Var vs dynamic (difference)____________
            //___1. Var  variable  Can   Variy   with Same DataType ===> (DataType) change nhin hoti
            //___1. var Can not be used as Parameter of Method(fun)
            var num = 25;
            num = 45;
            //num = "string";    error

            //___2. daynamic  variable  Can   Variy   with All DataType ===> (DataType) change kr sktaa han
            //___2. daynamic Can be used as Parameter of Method(fun)
            dynamic n = 45234234;
            n = 0;
            n = 234234;
            n = "string";
            n = true;
            n = 7.25;


            #endregion
        }
    }
}
