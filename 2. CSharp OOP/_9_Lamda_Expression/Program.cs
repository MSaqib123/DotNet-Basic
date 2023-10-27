using System;
using System.Collections.Generic;
using System.Linq;

namespace _9_Lamda_Expression
{


    //_________________________ 2. With Class Examples ______________________________
    #region Example_with_Class
    class Person
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            //_______________________________________ Note __________________________________________
            //========== Lamda Expression +  Linque =========================


            //______________________________________ 1. Lamdaa Expression __________________________________________
            /*
                 Lambda expressions are commonly used in C# to work with 
                 1, collections of data, (Array, List , objects)
                
                 //-------------------->>>>>>> Agaa parhain ga <<<<<<<<-----------
                 2, as part of LINQ queries   (need to add linque NameSpace)
                 3, as arguments to higher-order functions like Where, Select, Aggregate, and OrderBy
                 4, Lambda expressions can also be used to define event handlers or callback functions in asynchronous programming
            */
            //____ Syntax ____
            //1. (parameters store All values inside => expression or statement block)


            //_________________________ 1. Lamdaa Simple Examples ______________________________
            #region Basic Example

            //__________ List ________
            #region 1. With List 
            //__________ 1. _________
            List<int> number = new List<int> { 1, 2, 3, 4, 5 };
            //mujha wo Values Required ha jo  3 sa > then hon
            var variable = number.Where(b => b > 3);  //4, 5   --> List
            for (int i = 0; i < variable.Count(); i++)
            {
                //_____ error   IEnumerable  can not be converted to List<> _________
                //Console.WriteLine(variable[i]);

                //_____ ToList() _________
                Console.WriteLine("For Loop : " + variable.ToList()[i]);
            }

            foreach (var item in variable)
            {
                Console.WriteLine("Foreach Loop : " + item);
            }

            //__________ 2. _________
            List<string> words = new List<string> { "apple", "Banana", "country", "date", "flg", "Be" };
            var sorteWords = words.OrderBy(w => w.Length);
            foreach (var item in sorteWords)
            {
                Console.WriteLine(item);
            }
            List<string> words1 = new List<string> { "apple", "Banana", "country", "date", "flg", "Be" };
            var sorteWords1 = words1.OrderByDescending(w => w.Length);
            foreach (var item in sorteWords1)
            {
                Console.WriteLine(item);
            }
            #endregion

            //__________ Array ________
            #region 2. With Array
            int[] values = { 55, 155, 10, 40, 250, 300 };
            int sum = values.Where(x => x > 99).Sum();
            Console.WriteLine("Sum of All Values : " + sum);
            #endregion

            #endregion


            //_________________________ 2. Lamdaa Express With Class Examples ______________________________
            #region Example with Class
            //_______________ 1. _____________________
            List<Person> people = new List<Person>
            {
                new Person{id=1 , Name="Saqib",Age = 15},
                new Person{id=2 , Name="Akram",Age = 25},
                new Person{id=3 , Name="Bilal",Age = 17},
                new Person{id=4 , Name="Ahamad",Age = 55},
            };
            //get those people whose are adult
            var adult = people.Where(x => x.Age >= 18);
            List<Person> adultList = adult.ToList();
            for (int i = 0; i < adultList.Count(); i++)
            {
                Console.WriteLine("Name : " + adultList[i].Name + " , Age : " + adultList[i].Age);
            }


            //_______________ 2. _____________________
            List<Person> people1 = new List<Person>();
            people1.Add(new Person{id=1 , Name="Saqib",Age = 15});
            people1.Add(new Person{id=2 , Name="Akram",Age = 25});
            people1.Add(new Person{id=3 , Name="Bilal",Age = 17});
            people1.Add(new Person { id = 4, Name = "Ahamad", Age = 55 });
            people1.Add(new Person { id = 5, Name = "Noman", Age = 12 });
            //lamda expression foreachloop
            people1.ForEach(x =>
            {
                Console.WriteLine("Id : " + x.id + ", Name : " + x.Name + ", Age : " + x.Age);
            });


            ////_______________ 3. _____________________
            //var selectSingleColumn = people.Where(n => n.Age > 15).Select(x=>x.Name);
            //foreach (var item in selectSingleColumn)
            //{

            //}
            #endregion




        }
    }
}
