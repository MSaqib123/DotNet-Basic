using System;

namespace _5_Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //_________________________Condition_______________________
            //1. if, else
            //2. nested if,else if , else
            //3. if, else if , else
            //4. Inline Condition
            //5. switch Case condition , 
            //6. If vs Switch 

            //__________________________________________________________if , else (true,false)________________________________________________________
            #region If Conditions
            /*
            if (false)//(true)
            {
                Console.WriteLine("if Runing ,  Becouse --True Condition");
            }
            else
            {
                Console.WriteLine("else Runing ,  Becouse --false Condition");
            }
            */

            //____________________if , else_______________
            #region MyRegion
            //---by Variable---
            /*
            var a = 50;
            var b = 60; //30; true
            if (a > b)   //(40>40) false      //(40>30) true
            {
                Console.WriteLine(a + " baraa ha " + b + " == You are  Right");
            }  //jb khuch nhin hotaa  to   else
            else
            {
                Console.WriteLine("Answer = Wrong ");
            }
            */
            /*
            Console.Write("Enter UserName : ");
            string? userName = Console.ReadLine();
            Console.Write("Enter Password : ");
            string? password = Console.ReadLine();


            if (userName=="Saqib" && password=="12345")
            {
                Console.WriteLine("_____________________");
                Console.WriteLine("__Login_Successfuly__");
                Console.WriteLine("---------------------");
            }
            else
            {
                Console.WriteLine("_____________________");
                Console.WriteLine("__Oops.Invalid__");
                Console.WriteLine("_____________________");
            }
            */
            // its not Validate at   Empty_Value

            #endregion


            //____________________Nested If_______________
            //if ka under if
            //To validated Empty Values   &  other Condition we Used nested if

            //----Login---with_Empty---
            #region MyRegion
            /*
            Console.Write("Enter UserName : ");
            string? userName = Console.ReadLine();
            Console.Write("Enter Password : ");
            string? password = Console.ReadLine();

            if (userName=="" || password=="") //or ya
            {
                Console.WriteLine("__Enter_Username & Password__");
            }
            else
            {
                if (userName=="Saqib" && password=="12345")
                {
                    Console.WriteLine("\n\n--- Congturatilation, You are Winner ---\n");
                }
                else
                {
                    Console.WriteLine("\n\n--- BadLuck , You Loss ---\n");
                }
            }
            */
            #endregion


            //___________________if ElseIf , else_______________
            //for Multiple Conditions
            #region if , elseif , else
            //Console.Write("Enter 1st Number = ");
            //int v1 =int.Parse( Console.ReadLine() );
            //Console.Write("Enter 2nd Number = ");
            //int v2 = int.Parse( Console.ReadLine() );

            //Console.Write("Enter + - / *  : ");
            //string? op = Console.ReadLine();

            //if (op == "+") //1st Condition
            //{
            //    Console.WriteLine("---Addition---");
            //    int add = v1 + v2;
            //    Console.WriteLine("Add = " + add);
            //}
            //else if(op == "-")  //2nd conditio
            //{
            //    Console.WriteLine("---Substraction---");
            //    int sub = v1 - v2;
            //    Console.WriteLine("sub = " + sub);
            //}
            //else if (op == "*")
            //{
            //    Console.WriteLine("---Multiplication---");
            //    int mult = v1 * v2;
            //    Console.WriteLine("mult = " + mult);
            //}
            //else if (op == "/")
            //{
            //    Console.WriteLine("---Division---");
            //    //_________Type Cast (type ko bdlnaa)___________
            //    float div = (float)v1 / (float)v2;
            //    Console.WriteLine("Add = " + Math.Round( div , 2));
            //}
            //else //else 
            //{
            //    if (op == "")
            //    {
            //        Console.WriteLine("Please Give Operator (+,-...)");
            //    }
            //    else
            //    {
            //        Console.WriteLine("____You ar Fool____");
            //    }
            //}
            #endregion


            //___________________Task_______________
            //-System.FormatException  Validating
            //-TryParse()---
            #region TryParse()   Calculator
            /*
            Console.Write("Enter 1st Number = ");
            string s1 = Console.ReadLine();
            Console.Write("Enter 2nd Number = ");
            string s2 = Console.ReadLine();

            //Console.Write("Enter + - / *  : ");
            //string? op = Console.ReadLine();

            int v1, v2;

            //---TryParse---
            //give true false,
            Console.WriteLine(int.TryParse(s1,out v1));


            if (int.TryParse(s1, out v1) && int.TryParse(s2, out v2)) //int (v1,v2) convert nhin ho ge    ==> Ager  StringValue ha to  
            {
                //-----TryParse  Value  Tab Convert kraa ga  ager  value  (Integer) hovi to

                Console.Write("Enter + - / *  : ");
                string? op = Console.ReadLine();
                if (op == "+") //1st Condition
                {
                    Console.WriteLine("---Addition---");
                    int add = v1 + v2;
                    Console.WriteLine("Add = " + add);
                }
                else if (op == "-")  //2nd conditio
                {
                    Console.WriteLine("---Substraction---");
                    int sub = v1 - v2;
                    Console.WriteLine("sub = " + sub);
                }
                else if (op == "*")
                {
                    Console.WriteLine("---Multiplication---");
                    int mult = v1 * v2;
                    Console.WriteLine("mult = " + mult);
                }
                else if (op == "/")
                {
                    Console.WriteLine("---Division---");
                    //_________Type Cast (type ko bdlnaa)___________
                    float div = (float)v1 / (float)v2;
                    Console.WriteLine("Add = " + Math.Round(div, 2));
                }
                else //else 
                {
                    if (op == "")
                    {
                        Console.WriteLine("Please Give Operator (+,-...)");
                    }
                    else
                    {
                        Console.WriteLine("____You ar Fool____");
                    }
                }
            }
            else
            {
                if (s1 == "" || s2 == "")
                {
                    Console.WriteLine("------Empty (Integer Values Required)--------");
                }
                else
                {
                    Console.WriteLine("------Enter Numbers Not  String--------");
                }
            }
            */
            #endregion


            //__________________Inline If Condtion_______________
            #region inline If Conditions
            /*
            var s = "P";
            // (condition) ? if : else;
            var result = (s == "P") ? "Pakistan" : "India";
            Console.WriteLine("Result = " + result);
            */
            #endregion

            //__________________Inline If_Else Condtion_______________
            #region If_Else Inline_Condition
            /*
            Console.Write("\n\nEnter Your Marks : ");
            int? number =int.Parse( Console.ReadLine() );
            var r = (number <= 49 && number >= 39) ? "D Grad " : (number >= 49 && number <= 59) ? "C Grad" : (number >= 59 && number <= 69) ? "B Grad" : (number >= 69 && number <= 79) ? "A Grad" : (number >= 79 && number <= 89) ? "A++" : (number >= 89 && number <= 100)?"A+1":"Fail";

            Console.WriteLine("___Your Grad : " + r +"___");
            */
            #endregion

            #endregion

            //__________________________________________________________Switch Condition___________________________________________________
            #region Switch_Condition
            //_____________Switch______________
            /*
            Console.Write("Enter (1-10) any Number : ");
            int color = int.Parse(Console.ReadLine()); //1;
            var result = "";
            switch (color) //object  on  Which Experient will be perfomr
            {
                case 1:
                    result = "Black - Very Bad";
                    break;
                case 2:
                    result = "Green - Very LoveFull";
                    break;
                case 3:
                    result = "Yellow - very atractive";
                    break;
                case 4:
                    result = "Oringe - Very Good";
                    break;
                case 5:
                    result = "Pink - Girly Color";
                    break;
                case 6:
                    result = "Red - Very Danger";
                    break;
                case 7:
                    result = "HotBlack - Very Very Bad";
                    break;
                case 8:
                    result = "HotOringe - Very Very Good";
                    break;
                case 9:
                    result = "Magandaa_Color - Invincible Color";
                    break;
                case 10:
                    result = "San-sarif Color - Fonty Boy";
                    break;
                default:
                    result = "This is Not A Color , Please Enter Any Color";
                    break;
            }
            Console.WriteLine("Your Select : " + result);
            */

            //________Switch Program________
            /*
            Console.WriteLine("\n\nDate Object Today : " + DateTime.Today);
            Console.WriteLine("Date Curent_Time : " + DateTime.Now);
            Console.WriteLine("Day of Weak : " + DateTime.Now.DayOfWeek);

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    Console.WriteLine("Working Day  ....");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("last Day of Working  ....");
                    break;

                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Wohoooo Finlly Weekend  ....");
                    break;
                default:
                    Console.WriteLine("Noting Special");
                    break;
            }

            Console.WriteLine("\n\n");
            */

            //_____________Nested Switch___________
            //nested Switch is Apply On   2 Values
            /*
            var SortBy = "Category";  //which Column 
            var SortingOrder = "Desc";   //asc , desc

            switch (SortBy)
            {
                case "Name":
                    Console.WriteLine("You Select Name Column for Sorting");
                    //after Select Colum   ---> Sorting Will Be  Asc,Deasc
                    switch (SortingOrder)
                    {
                        case "Asc":
                            Console.WriteLine("Your Sorting Name Column Aasending");
                            break;
                        case "Desc":
                            Console.WriteLine("Your Sorting Name Column Descending");
                            break;
                        default:
                            Console.WriteLine("Name Colum Default Descending");
                            break;
                    }
                    break;

                case "Category":
                    Console.WriteLine("You Select Category Column for Sorting");
                    switch (SortingOrder)
                    {
                        case "Asc":
                            Console.WriteLine("Your Sorting Category Column Aasending");
                            break;
                        case "Desc":
                            Console.WriteLine("Your Sorting Category Column Descending");
                            break;
                        default:
                            Console.WriteLine("Category Colum Default Descending");
                            break;
                    }
                    break;

                case "Color":
                    switch (SortingOrder)
                    {
                        case "Asc":
                            Console.WriteLine("Your Sorting Color Column Aasending");
                            break;
                        case "Desc":
                            Console.WriteLine("Your Sorting Color Column Descending");
                            break;
                        default:
                            Console.WriteLine("Color Colum Default Descending");
                            break;
                    }
                    Console.WriteLine("You Select Color Column for Sorting");
                    break;

                default:
                    Console.WriteLine("Default Name Column Will Be Sort");
                    break;
            }
            */

            #endregion

            //__________________________________________________________If vs Switch___________________________________________________
            #region If_vs_Switch
            //_______Faster_____
            //IF is Faster    for  only   fue items     but
            //you have list  of items
            //if  last condition is True   ===> to if  ===> Saraa  if Block ko  check kraa gaa    ====> Very Slow if ===> Multiple Condtion are Executing

            //Switch is Faster the  If
            //if last (9) Condtion to meet True  ===> to Switch   Direct   last Condtion saa  Start kraa gaa ====>  Fast if  bunch of condtion are being executed


            //-----Practicaly------
            Console.Write("Enter 1 to 20 : ");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("if Book_1");
            }
            else if (a == 2)
            {
                Console.WriteLine("if Book_2");
            }
            else if (a == 3)
            {
                Console.WriteLine("if Book_3");
            }
            else if (a == 4)
            {
                Console.WriteLine("if Book_4");
            }
            else if (a == 5)
            {
                Console.WriteLine("if Book_5");
            }
            else if (a == 6)
            {
                Console.WriteLine("if Book_6");
            }
            else if (a == 7)
            {
                Console.WriteLine("if Book_7");
            }
            else if (a == 8)
            {
                Console.WriteLine("if Book_8");
            }
            else if (a == 9)
            {
                Console.WriteLine("if Book_9");
            }
            else if (a == 10)
            {
                Console.WriteLine("if Book_10");
            }
            else if (a == 11)
            {
                Console.WriteLine("if Book_10");
            }
            else if (a == 12)
            {
                Console.WriteLine("if Book_10");
            }
            else if (a == 13)
            {
                Console.WriteLine("if Book_10");
            }
            else if (a == 14)
            {
                Console.WriteLine("if Book_10");
            }
            else if (a == 15)
            {
                Console.WriteLine("if Book_10");
            }
            else if (a == 16)
            {
                Console.WriteLine("if Book_10");
            }
            else if (a == 17)
            {
                Console.WriteLine("if Book_10");
            }
            else if (a == 18)
            {
                Console.WriteLine("if Book_10");
            }
            else if (a == 19)
            {
                Console.WriteLine("if Book_10");
            }
            else if (a == 20)
            {
                Console.WriteLine("if Book_10");
            }
            else
            {
                Console.WriteLine("No Book");
            }


            switch (a)
            {
                case 1:
                    Console.WriteLine("Switch Book_1");
                    break;
                case 2:
                    Console.WriteLine("Switch Book_2");
                    break;
                case 3:
                    Console.WriteLine("Switch Book_3k");
                    break;
                case 4:
                    Console.WriteLine("Switch Book_4");
                    break;
                case 5:
                    Console.WriteLine("Switch Book_5");
                    break;
                case 6:
                    Console.WriteLine("Switch Book_6");
                    break;
                case 7:
                    Console.WriteLine("Switch Book_7");
                    break;
                case 8:
                    Console.WriteLine("Switch Book_8");
                    break;
                case 9:
                    Console.WriteLine("Switch Book_9");
                    break;
                case 10:
                    Console.WriteLine("Switch Book_10");
                    break;
                case 11:
                    Console.WriteLine("Switch Book_10");
                    break;
                case 12:
                    Console.WriteLine("Switch Book_10");
                    break;
                case 13:
                    Console.WriteLine("Switch Book_10");
                    break;
                case 14:
                    Console.WriteLine("Switch Book_10");
                    break;
                case 15:
                    Console.WriteLine("Switch Book_10");
                    break;
                case 16:
                    Console.WriteLine("Switch Book_10");
                    break;
                case 17:
                    Console.WriteLine("Switch Book_10");
                    break;
                case 18:
                    Console.WriteLine("Switch Book_10");
                    break;
                case 19:
                    Console.WriteLine("Switch Book_10");
                    break;
                case 20:
                    Console.WriteLine("Switch Book_10");
                    break;
                default:
                    Console.WriteLine("Notting");
                    break;
            }

            Console.Read();

            #endregion


            //__________________________________________________________Task___________________________________________________
            //1. Resturent Management

        }
    }
}
