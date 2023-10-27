using System;
using System.Collections.Generic;

namespace _8._1_Generic_Methods
{
    
    internal class Program
    {
        //_______________________ 1. Simple Method ______________________________
        static void simpleMehod(int age , string Name)
        {
            Console.WriteLine("Your age : " + age);
            Console.WriteLine("Your Name : " + Name);
        }

        //_______________________ 2. Single DataType Generic Method ___________________________________
        static void genericMethod<T>(ref T a ) //t type  jo Run Time par Change ho ge
        {
            //T temp; //any type
            //temp = a;
            Console.WriteLine("Value : " + a);
            Console.WriteLine("DataType : " + a.GetType());
        }

        //_______________________ 3. Multiple DataType Generic Method ___________________________________
        static void changeByName<T,E>(T value1 , E value2 , string message1, string message2 )
        {
            Console.WriteLine("\n" + message1 + " : " + value1);
            Console.WriteLine(message2 + " : " + value2 +"\n");
        }

        //_______________________ 4. Addition of 2 Generic Values ___________________________________
        static public void addGenericValues<A, B>(A i1, B i2)
        {
            dynamic v1 = i1;
            dynamic v2 = i2;

            var c = (v1 + v2);
            Console.WriteLine("Addition of 2 Value : " + c);
        }

        //_______________________ 5. checking Types of Generic and Making Values ___________________________________
        static public void conditionBaseValues<A, B>(A i1, B i2)
        {
            Type tA = typeof(A);
            Type tB = typeof(B);

            if((tA == typeof(string) && tB == typeof(string)) || (tA == typeof(int) && tB == typeof(string)) || (tA == typeof(string) && tB == typeof(int)))
            {
                dynamic v1 = i1;
                dynamic v2 = i2;

                var c = (v1 + v2);
                Console.WriteLine("1st = {0} , last={1} " , v1 , v2);
            }
            else
            {
                dynamic v1 = i1;
                dynamic v2 = i2;

                var c = (v1 + v2);
                Console.WriteLine(" Additon of 2 Values : " + c);
            }
        }




        static void Main(string[] args)
        {
            /*________________________________________________ Generic Methods ______________________________________*/
            //Wo Method gen ke  ====> Run time Par  ====>  DataType Change ho  ===>   (usaa Generic Methods)

            //_________________________ 1. Simple Method ________________________________
            simpleMehod(25,"Muhammad Saqib");
            //simpleMehod("Saqib ", 25);    not possible   ==== but By Generic its posible

            //_________________________ 2. Generic Method  Single Data Type __________________________________
            int value = 25;
            genericMethod<int>(ref value);

            string Name = "Saqib";
            genericMethod<string>(ref Name);

            //_________________________ 3. Multile DataType Generic Method __________________________________
            //______ Persone by  Same GenericMethod 
            changeByName<string, int>("Name", 25, "Name", "Age");

            //______ Employee by  Same GenericMethod _________
            changeByName<int, string>(1, "Rashid", "Id", "Name");

            //______ Employee by  Same GenericMethod _________
            changeByName<bool, int>(true, 2500 , "GrossSalery Status", "GrossSallery Value");


            //________________________ 4. Addition of Generic Values ______________________
            addGenericValues("Saqib","Boota");
            addGenericValues(55, 55);

            //________________________ 5. checking Types of Generic and Making Values ___________________________________
            conditionBaseValues("P","Ind");
            conditionBaseValues("P",234);
            conditionBaseValues(434,"Ind");
            conditionBaseValues(5,5);


            //________________________ 7. Build In Generic Method __________________________________
            List<int> iList = new List<int>();
            List<string> sList = new List<string>();
            List<bool> bList = new List<bool>();
        }

    }
}
