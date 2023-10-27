using System;

namespace _6_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //______________________________________Loops_____________________________________________________
            //1. To 10000s of Record on The Page / Console   we  Used ===> looop
            //2. its used in Application for Dynamice Recordsk
            //Exemple:    its used to Fetch_Record  from  Database   and managy 

            //--------- 1. For Loop --------------
            //--------- 2. While Loop --------------
            //--------- 3. Do While Loop --------------
            //--------- 4. foreach Loop --------------


            //______________________________________ 1. For Loop  + Patteren + logics _____________________________________________________
            #region For Loop

            //_____________1. Syntax____________________
            #region Sytanx , Index , printing_Loop_Number
            //__________1. Why?_____________
            //100 Name of Student to Print
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //Console.WriteLine("st_Saqib");
            //---I am not BewaaQoof  jo  Application ko  Itnaa Load don gaa 
            //---Jitni Zyadaa Lines hon ge utnaa zydaa load ho gaa

            //_________2. Syntax_________
            //for (/*initialize  starting Point */int i = 0; /*Lenth_of_Loop   ending */ i<10;  /*incrment*/ i++)
            //{
            //    Console.WriteLine("Pakistan");
            //}

            //_________3. Printing (Number + Name)_________
            ////1. i = Index (position)
            ////2. programing lanaguage me (position 0 saa start hoti ha)
            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine(i + ") Saqib");  //index 0 sa start ha ====> Paar length = 10 he haa
            //    Console.WriteLine(i+1 + ") Saqib");
            //}
            #endregion

            //_____________2.Table (from User)_________________
            #region Tables from User
            //Console.Write("Enter Table (2 to 20) : ");
            //int t = int.Parse(Console.ReadLine()); // 10; //2;

            //Console.Write("Enter Multiple (10 to 30) : ");
            //int m = int.Parse(Console.ReadLine()); // 10; //2;

            //if (t>=2 && t<=20)
            //{
            //    if (m >= 10 && m <= 30)
            //    {
            //        for (int i = 1; i <= m; i++) //11; i++) //0; i < 11; i++)
            //        {
            //            //composit string formate
            //            Console.WriteLine("--{0} * {1} = {2}--", t, i, t * i);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("\n--Invalida Multiple (10 to 30)--");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("\n--Invalid Table--");
            //}
            #endregion

            //_____________3.Infinite Loop_________________
            #region Infinite_Loop
            //for (; ; )
            //{
            //    Console.WriteLine("Infinite Loop");
            //}
            #endregion


            //_____________ 4. Even Odd Numer ________________▬◘
            #region Even & Odd
            //Console.WriteLine(" 1) Even \t 2) Odd");
            //Console.Write("Enter Option : ");
            //byte o = byte.Parse(Console.ReadLine());

            //even
            //if (o == 1)
            //{
            //    for (int i = 1; i < 20; i++)
            //    {

            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            //odd
            //if (o == 2)
            //{
            //    for (int i = 1; i < 20; i++)
            //    {
            //        if (i % 2 == 1)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            #endregion

            //__________________________________ 5. Patteren _____________________________▬◘
            //____________ 1. Row & Col _______________
            for (var row = 1; row <= 5  ; row++)
            {
                for (int col = 1 ; col <= 5; col++)
                {
                    Console.Write("col_"+col);
                }
                Console.WriteLine(" row"+row);
            }
                            
            //____________ 2 Stare _______________
            for (var row = 1; row <= 5  ; row++)
            {
                for (int col = 1 ; col <= 5; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            //____________ 3 Stare _______________
            for (var row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            //____________ 4 Stare _______________
            for (var row = 1; row <= 5; row++)
            {
                for (int col = row; col <= 5; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //____________ 5 Stare _______________
            for (var row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int row = 1; row < 5; row++)
            {
                for (int j = row; j <= 4; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine();

            //____________ 6 Stare _______________
            for (var row = 1; row <= 5; row++)
            {
                for (int col = 1;  col <= row; col++)
                {
                    //Console.Write("*");
                    Console.Write("_");
                }
                for (int j = row; j <= 5; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            Console.WriteLine("\n");

            //____________ 7 Stare _______________
            for (var row = 1; row <= 5; row++)
            {
                for (int col = row+1; col <= 5; col++)
                {
                    //Console.Write("_");
                    Console.Write(" ");
                }
                for (int j = 1; j <= row; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            //for (int row = 1; row < 5; row++)
            //{
            //    for (int j = row; j <= 4; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            #endregion

            //______________________________________ 2. While Loop_____________________________________________________
            #region While_Loop
            //1. same as   For Loop 
            //2. is me   (s.p  or  e.P or ++)   alag alag hotaa 
            //3. Working Same ha

            #region Syntax
            //________Syntax________
            //int i = 0;//s.p
            //while (i <= 10) //e.p
            //{
            //    i++; //increment false condition
            //}
            #endregion

            #region Program

            #endregion

            #endregion

            //______________________________________ 3. Do While Loop_____________________________________________________
            #region Do_While_Loop

            #region Syntax
            //1. do_While   Work With Condition
            //2. jab tak Condition true rhaa gee loop  =======>   Work kra ga
            //3. jab Conditon false hoi to  Loo =====> Work nhin kraa ga
            //var i = 1; //s.p
            //do
            //{
            //    Console.WriteLine(i + ") Working");
            //    i++; //condtion false kra ga
            //}
            //while (i <= 10);//e.p  //(true);
            #endregion

            #region Bank_ATM_Matchine
            string pin;
            do
            {
                Console.Write("Enter Pin : ");
                pin = Console.ReadLine();//"123"; //"23";
            } while (pin!="123");

            Console.Write("\n--Welcome on Our UBL Bank");
            #endregion

            #endregion


            //______________________________________ 4. Foreach_Loop _____________________________________________________
            //used in Array ==> after Array We will do this
        }
    }
}
