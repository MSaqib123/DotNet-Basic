using System;
using System.Collections.Generic;

namespace _8_1_List___Class
{
    /*_______________________ 1. Class + Array List _______________________*/
    class ArrayClass
    {
        //properties
        public string Name { get; set; }
        public int Age { get; set; }
    }
    


    /*_______________________ 2. Class + List _______________________*/
    public class people
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string country { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //2 types of List 


            //____________________________________ 1. Array List ________________________
            //________ 1. Basic Array _____
            #region Bassic_Array
            int[] basicArray = new int[6] { 53, 35, 35, 35, 35, 35 };
            foreach (var item in basicArray)
            {
                Console.WriteLine(item);
            }
            #endregion

            //________ 2. Classs + Array 1D _____  
            //array pr  ---> Length
            #region Class+Array
            ArrayClass[] array1 = new ArrayClass[5];
            array1[0] = new ArrayClass { Name = "Pakistan", Age = 20 };
            array1[1] = new ArrayClass { Name = "India", Age = 10 };
            array1[2] = new ArrayClass { Name = "Srilanka", Age = 12 };
            array1[3] = new ArrayClass { Name = "Amarica", Age = 30 };
            array1[4] = new ArrayClass { Name = "SouthAfrica", Age = 33 };
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("arry1D =>  Name : " + array1[i].Name + " , Age : " + array1[i].Age);
            }

            //________ 3. Classs + Array 2D/3D _____  
            ArrayClass[,] array2 = new ArrayClass[2,2];
            array2[0,0] = new ArrayClass { Name = "Pakistan", Age = 20 };
            array2[0,1] = new ArrayClass { Name = "India", Age = 10 };
            array2[1,0] = new ArrayClass { Name = "Srilanka", Age = 12 };
            array2[1,1] = new ArrayClass { Name = "Amarica", Age = 30 };
            for (int row = 0; row < array2.GetLength(0); row++)
            {
                for (int col = 0; col < array2.GetLength(1); col++)
                {
                    Console.WriteLine("Array2D =>  Name : " + array2[row,col].Name + " , Age : " + array2[row,col].Age );
                }
            }
            #endregion




            //____________________________________ 2. List _______________________*/
            //banifit ya    Runtime me  is more Element add kr sktaa han jb kaa   Array me asaa posible nhin
            //________ 1. Basic ________
            #region Basic List
            //in basic List  , you pass   int,string,bool.... datatype
            //__________ 1. __________
            List<int> intList = new List<int>();
            intList.Add(111);
            intList.Add(122);
            intList.Add(133);
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }


            List<string> stringList = new List<string>()
            {
                "Asif",
                "Ahamd",
                "Noman",
            };

            for (int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine(stringList[i]);
            }
            #endregion

            //________ 2. Class + List ________
            #region Class+List
            //is me hum   <class>  as  datatype  set krtaa han
            //List pr  ---> Count
            List<people> persone = new List<people>();
            List<people> per = new List<people>
            {
                new people { Id =1 , Name = "Akram",  Age=75,country = "Pakistan"},
                new people { Id =2 , Name = "Raja Sain",  Age=25,country = "India"},
                new people { Id =3 , Name = "Asif",  Age=35,country = "SiriLanka"},
                new people { Id =4 , Name = "Murtaza",  Age=15,country = "Sudia Arbia"},
                new people { Id =5 , Name = "Gulaam mustfaa",  Age=25,country = "SouthAfrica"},
                new people { Id =5 , Name = "Ali Raza",  Age=5,country = "Sodaan"},
            };
            foreach (var item in per)
            {
                Console.WriteLine("Id : " + item.Id + " , Name : " + item.Name + " , Age : " + item.Age + " , Country : " + item.country);
            }
            #endregion

        }
    }
}
