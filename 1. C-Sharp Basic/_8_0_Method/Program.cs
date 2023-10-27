using System;

namespace _8_Method
{
    internal class Program
    {


        /*______________________2. Static Method______________________*/
        #region static_Method
        //__________ method __________
        //code of line jo baar bar execute
        //1. take nothing  return nonthing
        static public void calculate()  //retunr nothing
        {
            int c = (10 + 5);
            Console.WriteLine("Addintion of 2 Number : " + c);
        }

        //2. take somthing , return nothing
        static public void calculate1(int v1, int v2)  //retunr nothing
        {
            int c = (v1 + v2);
            Console.WriteLine("Addintion of 2 Number : " + c);
        }

        //3. take something , retung somthieng
        static public string calculate2(int v1, int v2)  //retunr string values
        {
            int c = (v1 + v2);
            return "Addition of 2 number : " + c;
        }

        //4. take nothing , return something
        static public string calculate3()  //retunr string values
        {
            int c = (500 + 500);
            return "Addition of 2 number : " + c;
        }
        #endregion

        /*______________________1. None Static Method______________________*/
        #region None_Static_Method / Instance Metod

        //_________________Simplet Method________________
        //void name()
        //{
        //    Console.WriteLine("My Name is Muhammad Saqib");
        //}

        //_________________Parameter Methods_____________________
        //void name(string name)
        //{
        //    Console.WriteLine("My Name is Muhammad " + name);
        //}

        //_________________state of Method____________________
        //---2) get something , return nothing---
        //void add(int a,int b)
        //{
        //    Console.WriteLine("Addition : " + a+b);
        //}

        //---3) get something , return nothing---
        //int sum()
        //{
        //    int a = 25;
        //    int b = 25;
        //    return a + b;
        //}

        //---4) get something , return something---
        //int mult(int a , int b)
        //{
        //    return a * b;
        //}

        //________________Percentage / Grad______________________
        //float percentage(int math, int English)
        //{
        //    float percentage = (math + English) * 100 / 200;
        //    return percentage;
        //}
        //string grade(float percentage)
        //{
        //    string grad="";
        //    if (percentage >= 90)
        //    {
        //        grad = "A+1";
        //    }
        //    else if (percentage >=80 && percentage <= 89)
        //    {
        //        grad = "A+";
        //    }
        //    else if (percentage >= 70 && percentage <= 79)
        //    {
        //        grad = "A";
        //    }
        //    else if (percentage >= 60 && percentage <= 69)
        //    {
        //        grad = "B";
        //    }
        //    else if(percentage >= 50 && percentage <= 59)
        //    {
        //        grad = "C";
        //    }
        //    else
        //    {
        //        grad = "fail";
        //    }
        //    return grad;
        //}

        //__________________Pass By Value______________________
        //public void num(int a)
        //{
        //    a = a + 10;
        //    Console.WriteLine("Method value : " + a);
        //}

        //__________________Pass By Reference______________________
        ////hum (ref) key lgata han
        //public void num(ref int a)
        //{
        //    a = a + 10;
        //    Console.WriteLine("Method value : " + a);
        //}

        #endregion


        static void Main(string[] args)
        {
            //Build in Methods--------> System Methods
            //_____________Defination___________
            //A method is a block of code /block statements
            //_____Why_____
            //to Reducing duplication of code
            //to Reuse of code
            //to Improving clarity of the code

            //__________________________________________Method / Behaviours (user_Define)________________________________________
            //We have  2 types of User_difine Methods
            //1. Static Method
            //2. Non Statice Methods 

            /*_______________________________1. Static Method_____________________________________*/
            //not used To Much
            //1. take nothing return nothing
            //2. take nothing return somthing
            //3. take something return nothing
            //4. take something return something

            #region static_Method
            calculate();  //give nothig 

            calculate1(2, 2555);  //give 2 values

            string stValue = calculate2(555, 2555);  //give 2 values
            Console.WriteLine(stValue);

            string stValue1 = calculate3();  //give 2 values
            Console.WriteLine(stValue1);

            #endregion


            /*_______________________________2. None Static Method_____________________________________*/
            #region None_Static_Method / Instance_of_Object Methods

            //Console.WriteLine("Your Name is Sajid Ali , My Name is Akram");
            //Console.WriteLine("Your Name is Sajid Ali , My Name is Akram");
            //Console.WriteLine("Your Name is Sajid Ali , My Name is Akram");
            //Console.WriteLine("Your Name is Sajid Ali , My Name is Akram");
            //Console.WriteLine("Your Name is Sajid Ali , My Name is Akram");

            //___Why not to Make FN___ Repetation of Cade
            //none Static methods  are called  by Object instance
            //__object__ 
            Program p = new Program();//constractor  //(new) Memory Alocator

            //_________________1. Simple Method____________
            //p.name();
            //p.name();
            //p.name();
            //p.name();
            

            //_________________2. Method With Parameter/Arguments__________
            //p.name("Saqib");
            //p.name("Sajaid");
            //p.name("Raja");


            //_________________3. (4) States of Method_________________
            //---1) get nothing , return nothing__
            //p.name();

            //---2) get something , return nothing,--
            //p.add(5,5);

            //---3) get nothing , return somthing,--
            //Console.WriteLine("Addition : " + p.sum());

            //---4) get something , return nothing--
            //int result = p.mult(25,5);
            //Console.WriteLine("Multiplication : " + result);

            //___________________4. Percentage / Grad______________________
            //Console.Write("Enter Math (Marks) : ");
            //int Math = int.Parse(Console.ReadLine());//71;
            //Console.Write("Enter English (Marks) : ");
            //int English = int.Parse(Console.ReadLine());//75;

            //float perc = p.percentage(Math, English);
            //string grad = p.grade(perc);
            //Console.WriteLine("Your Percentage : " + perc + "%");
            //Console.WriteLine("Your Grade : " + grad);

            //___________________5. Pass by Value______________________
            //int a = 10;
            //p.num(a);
            //Console.WriteLine("Simple Value : " + a + "\t giving Actual Value of a");

            //___________________5. Pass by Reference______________________
            ////(ref) is Address of variable  
            //int a = 10;
            //Console.WriteLine("Befor Reference : "+ a );

            //p.num(ref a); //is line par Code  phnchaa to  ---> Reference wala Variable ke Value  (uth kr Aa  gy)
            //Console.WriteLine("After Reference Value : " + a + "\t giving Value of (Method)");

            #endregion

            



        }
    }
}
