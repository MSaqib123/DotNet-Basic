using System;

namespace _7_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*__________________________________ Array ____________________________________*/
            //To Store Mulitple Values in   ===> in Single Variables ====>  used Array Variables ====> its DataType
            //_______Many Ways to Make Array______
            //1. define length  |  fixed Legth
            //2. undefine length


            //_______________________ 1. Array Different Formate _________________________
            #region 1. Array Different Format to Create

            //_______________________ 1. Defined Length  |  Fixed Legth ___________________________
            int[] myArray = new int[3]; //declare
            myArray[0] = 11;  //initilize
            myArray[1] = 22;
            myArray[2] = 33;
            //myArray[3] = 55;   Error

            //Console.WriteLine(myArray[0]);
            //Console.WriteLine(myArray[1]);
            //Console.WriteLine(myArray[2]);
            //Error index
            //Console.WriteLine(myArray[5]);


            //declare & initilize  
            int[] array1 = new int[5] {4,45,5,52,65};
            Console.WriteLine(array1[4]);


            //_______________________ 2. Undefined length___________________________
            int[] mArray1 = { 5,55,555,5555,22,22};
            Console.WriteLine(mArray1[0]);
            Console.WriteLine("Length : " + mArray1.Length);

            int[] mArray2 = new int[] { 31,32,33,44,55};
            Console.WriteLine(mArray2[0]);
            Console.WriteLine("Length : "+ mArray2.Length);
            #endregion


            //_______________________ 2. Array + Loop _________________________
            #region Array+Loop
            //__________________ 1. For Loop ____________________
            string[] fruits = new string[5];
            fruits[0] = "Orange";
            fruits[1] = "WaterMelon";
            fruits[2] = "Stabery";
            fruits[3] = "gava";
            fruits[4] = "apple";

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine((i + 1) + " = " + fruits[i]);
            }

            //__________________ 2. Foreach Loop ____________________
            foreach (string item in fruits)
            {
                int index = Array.IndexOf(fruits, item);
                Console.WriteLine(++index +") "+ item);
            }

            #endregion


            //_______________________ 3. Array Methods _________________________
            #region Methods
            string[] employees = { "Ahamd", "Noor", "Gazi", "Shaazad", "Rehman", "Sarfarz","Arsalan"};

            //______________ 1. Array.IndexOf() ____________________
            Console.WriteLine(Array.IndexOf(employees,"Gazi"));  //give the Index of Array


            //______________ 2. Array.Sort() _______________
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("___ sorting ___");
            Array.Sort(employees);
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }

            //______________ 3. Reverse() _______________
            Array.Reverse(employees);
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }

            //______________ 4. Clear() _______________
            Array.Clear(employees,0,employees.Length);
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }

            //_____________ 5. Copy() _______________
            Console.WriteLine("\n");
            string[] employee1 = { "Ahamd", "Noor", "Gazi", "Shaazad", "Rehman", "Sarfarz", "Arsalan" };
            string[] arrayEmployee = new string[employee1.Length-1];

            Array.Copy(employee1, arrayEmployee, employee1.Length - 1);
            foreach (var item in arrayEmployee)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n");
            //______________ 6. Resize() _______________
            Array.Resize(ref arrayEmployee,5);
            foreach (var item in arrayEmployee)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");


            //______________ 7. IndexOf() _______________
            string[] country = { "Pakistan", "Inda", "SriLanka" };
            var exist = Array.Exists(country, x=>x.Equals("Pakistan"));
            if (exist)
            {
                Console.WriteLine("Pakistan Exist in Array");
            }


            //______________ 8. Find() _______________
            string found = Array.Find(country, x=>x == "Pakistan");
            Console.WriteLine(found);

            //______________ 8. ConvertAll() _______________
            string[] numberInString = { "1", "2", "3", "4" };

            int[] converttoNumber = Array.ConvertAll(numberInString, int.Parse);
            #endregion


            //_______________________ 4. Properties _________________________
            #region Properties
            int[] number = { 1, 2, 3, 4, 5 };

            //______ 1. lenght ______
            int length = number.Length;
            Console.WriteLine(length);

            //______ 2. Rank ______
            int rank = number.Rank;
            Console.WriteLine(rank);

            //______ 3. IsFixedSize ______
            bool isFixedSize = number.IsFixedSize;
            Console.WriteLine(isFixedSize);

            //______ 4. SyncRoot ______
            object root = number.SyncRoot;
            Console.WriteLine(root);

            #endregion

            //_______________________________ Programs  _________________________________

            //______________ 1. Adding Element at End of Array _______________
            int[] employeeSalary = { 40000, 15000, 13000 };

            //__ add 1 lenght __
            Array.Resize(ref employeeSalary , employeeSalary.Length+1);

            //__ assign value __
            employeeSalary[employeeSalary.Length - 1] = 4;
            foreach (var item in employeeSalary)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //______ adding more Element ____
            //__ add 1 lenght __
            Array.Resize(ref employeeSalary, employeeSalary.Length + 1);

            //__ assign value __
            employeeSalary[employeeSalary.Length - 1] = 4;
            foreach (var item in employeeSalary)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



            //______________ 2. Adding Element at start of Array _______________
            int[] numbers = { 1, 2, 3 };
            Array.Resize(ref numbers, numbers.Length + 1);
            for (int i = numbers.Length - 1;  i > 0; i--)   //--    becuase we  have to get  0 index value
            {
                //3 value ko   last me  Move krna ha ------- 0 par  randm value ay ge  ---> Then add customer value
                numbers[i] = numbers[i - 1]; // number[0,1,2,3] = number[0-1 , 1-1 , 2-1]
                Console.WriteLine(number[i]);
            }
            numbers[0] = 57777;

            Console.WriteLine(numbers[0]);
        }
    }
}

