using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._2_List
{
    internal class Program
    {
        //____________________________ 1. IList Method _____________________________
        #region Ilist Methods
        //___ Simple IList ____
        static void show1(IList<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine("\t" + item);
            }
            Console.WriteLine("\t__________");
        }

        //___ T IList ____   
        static void show2<T>(IList<T> list)
        {
            //foreach (T item in list)
            //{
            //    Console.WriteLine("\t" + item);
            //}
            //Console.WriteLine("\t__________");

            //_________ Condition on Type ____
            if (typeof(T) == typeof(int))
            {
                foreach (T item in list)
                {
                    Console.WriteLine("\t Integer: \t " + item);
                }
                Console.WriteLine("\t_________________");
            }
            if (typeof(T) == typeof(string))
            {
                foreach (T item in list)
                {
                    Console.WriteLine("\t string: \t " + item);
                }
                Console.WriteLine("\t_________________");
            }
            else if (typeof(T) == typeof(bool))
            {
                foreach (T item in list)
                {
                    if (item.Equals(true))
                    {
                        Console.WriteLine("\t" + "Yes");
                    }
                    else
                    {
                        Console.WriteLine("\t" + "No");
                    }
                }
                Console.WriteLine("\t__________");
            }
            else
            {
                foreach (T item in list)
                {
                    Console.WriteLine("\t" + item);
                }
                Console.WriteLine("\t__________");
            }
        }

        #endregion


        static void Main(string[] args)
        {
            //Array          (Defined Type) ---> Run Time par  ==> Datatype chanage nhin hoti

            /*________________________________________________ List ____________________________________________________*/
            //1. List<>                 Generic     C# me Sb saa zydaa istama hoti ha
            //2. IList                  interface List
            //4. ICollection List       interface list
            //3. IEnumerable List       interface List

            //______________________________ 1. List ___________________________________________
            #region List<>
            //add  system.Collection.Generic ==> NameSpace
            //______________________ 1 Basic List ______________________
            #region Basic List
            List<int> s = new List<int>()
            {
                1,2,3,4,5,6,7,8,9
            };
            for (int i = 0; i < s.Count; i++)
            {
                Console.WriteLine(s[i]);
            }
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            //ForEach loop  --> option in List
            s.ForEach(x => {
                Console.WriteLine(x);
            });

            //____2____
            List<string> l1 = new List<string>();
            l1.Add("Pakistan"); l1.Add("India");
            l1.Add("SriLanka"); l1.Add("England");

            l1.ForEach(x => { Console.WriteLine("Country : " + x); });

            #endregion


            //______________________ 2. Basic Methods ____________________
            #region Basic Methods
            //______ 1. Add _______
            List<int> n1 = new List<int>();
            n1.Add(55);

            //______ 2. AddRange  _______
            n1.AddRange(new int[] {45,55,5,5,5,5,5,5 });

            //______ 3. Remove (occurrence value) _______
            n1.Remove(55);  //

            //______ 4. RemoveAt (Posittion)_______
            n1.RemoveAt(2);

            //______ 5. RemoveRange _______
            n1.RemoveRange(0,3);  //remove   1,2,3,4   values 

            //______ 6. insert at spacific index_______
            n1.Insert(3,555); // index , value

            //______ 7. insertRange (MulipleValues) at  postion_______
            n1.InsertRange(3, new int[] {4,5,6}); 

            //______ 8. clear_______
            n1.Clear();

            //______ 9. contains_______
            List<int> number = new List<int>() { 1, 2, 3, 4 };
            bool containsTwo = number.Contains(2);

            //______ 10. LastIndexOf  (last index of similar values)_______
            List<int> number1 = new List<int> {1,2,2,55,55,0 };
            int index = number1.LastIndexOf(55);

            //______ 11. IndexOf (1st index of similar values)_______
            int firstIndex = number1.IndexOf(2);

            //______ 12. Sort  to sort vaues a->z _______
            number.Sort();

            //______ 13.  Revers _______
            number.Reverse();

            //______ 14.  find _______
            number.Find(x=>x > 2);  //wo value find kro  go  ---> 2 sa bari ha   List me

            //______ 15.  find all _______
            number.FindAll(x => x > 2);  //Sary values ---> 2 jo bari ha ---> a gin ge

            //______ 16. Count ______
            int[] lValue = new int[] { 44, 5, 5, 5, 6, 6, 8 };
            var totalLength = lValue.Count();
            Console.WriteLine("Total length of List " + totalLength);

            #endregion


            //______________________ 3. Convert String to List ____________________
            #region string to List
            string input = "2,3,4,5,5,7";
            //i want to get   4,7  values form this 
            //input.find();
            //___ convert to list ___
            List<int> listValue = input.Split(',').Select(int.Parse).ToList();
            listValue.ForEach(x => { Console.WriteLine(x); });

            #endregion

            #endregion

            //______________________________ 2. IList ___________________________________________
            #region IList<>
            //// I = Interface    ===> system.Collections
            ////1.  IList  ==> is Interfaces List 
            ////2.  its Work With ===> Objects            Program p = new Program() ===> Object
            ////3.  Ya Zydaa __ OOP __ me Use hoti ha

            ////_______ 1 _____
            //string[] students = { "Sahid", "Noman", "Billal", "Raja", "Ali Raza", "Oman", "Asif", "Akram", "Tahir" };
            //IList<string> Ilist = students;//Array | list 
            //foreach (var item in Ilist)
            //{
            //    Console.WriteLine("Students : " + item);
            //}

            ////_______ 2 _____
            ////List
            //List<string> months = new List<string> { "Jan", "Feb", "March", "Apr", "May", "Jun", "July", "August", "Sep", "Oct", "Nov", "Dec" };
            //foreach (var item in months)
            //{
            //    Console.WriteLine("Months : " + item);
            //}
            ////IList
            //IList<string> iMonth = months;
            //foreach (var item in iMonth)
            //{
            //    Console.WriteLine("Months : " + item);
            //}

            ////_______ 3 _____static Type
            //show1(students);
            //List<int> n = new List<int> { 111, 112, 122, 12 };
            ////--- error ---
            ////show1(n);


            ////_______ 4 _____Generic Type
            //show2<int>(n);
            //show2<string>(months);
            //List<bool> yesNo = new List<bool> { true, false, false, true, false };
            //show2<bool>(yesNo);
            #endregion

            //______________________________ 3. INumerable ___________________________________________
            #region IEnumerable
            //Console.Clear();

            //string[] name = { "Pksit", "India", "SriLanka" }; 

            //IEnumerable<string> IE = name;
            //foreach (var item in IE)
            //{
            //    Console.WriteLine("IEnumber : " + item);
            //}

            ////ager asa lambaa kam krnaa thaa to  Direct       ======>    Array  foreach  print kr latta
            //foreach (var item in name)
            //{
            //    Console.WriteLine("Simpel Array : " + item);
            //}
            #endregion

            //______________________________ 4. ICollection ___________________________________________
            #region ICollection
            //string[] teacher = {"Farhan","Sajad","Rehman","Billal","Husaan","Akram","Ahamd","RashidS","Oman","Akram","Ahasan"};
            //ICollection<string> Iteacher = teacher;
            //foreach (var item in Iteacher)
            //{
            //    Console.WriteLine("ICollection : " + item);
            //}

            #endregion


            //______ in Me Differece  ====. OOP me ==> op ko Samjh aygaa _________
            //array                  ===>  only used  systemData types
            //list,Ilist....         ===>  Object Can used as list



        }

    }
}
