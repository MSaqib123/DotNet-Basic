using System;
using System.Collections.Generic;
using System.Text;

namespace _3_BankSystem_By_OOP._1_ATM
{
    internal class Employee : Account
    {
        public int type; //emloyee
        public int Sallery = 15000;  //have Sallery

        //____ Show At The End ______
        public void show()
        {
            Employee emp = new Employee();
            emp._Amount = 45000;
            start:
            Console.WriteLine("\n____ Welcome to Employee Account _____");

            Console.WriteLine("1) Check Sallery  \t 2) Check Amount\t 3) Deposit Amount  \t 4) WidthDrow Amount \t 5) LogOut \t 6) Exit\n");
            Console.Write("Enter Option : ");

            byte option = byte.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Your Emplyee Sallery  is : " + Sallery );
                Console.ReadLine();
                Console.Clear();
                goto start;
            }
            else if (option == 2)
            {
                Console.WriteLine("Your Bank Amount  is : " + emp._Amount);
                Console.ReadLine();
                Console.Clear();

                goto start;
            }
            else if (option == 3)
            {
                Console.Write("\nEnter (Limit to : 50000) : ");
                int amount1 = int.Parse(Console.ReadLine());
                if (amount1 < 0 || amount1 > 50000)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Amount");

                    Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();
                    goto start;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    emp._Amount = emp._Amount + amount1;
                    Console.WriteLine("After Adding _" + amount1 + " , Your Current Balance is  : " + emp._Amount);
                    Console.ReadLine();
                    Console.Clear();

                    goto start;
                }

            }
            else if (option == 4)
            {
                Console.Write("\nEnter Amount for WithDraw : ");
                int amount2 = int.Parse(Console.ReadLine());
                if (amount2 < 0 || amount2 > emp._Amount)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Amount");

                    Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();
                    goto start;
                }
                else
                {
                    emp._Amount = emp._Amount - amount2;
                    Console.WriteLine("After WithDrow _" + amount2 + " , Your Current Balance is  : " + emp._Amount);
                    Console.ReadLine();
                    Console.Clear();

                    goto start;
                }
            }
            else if (option == 5)
            {
                Console.Clear();
                ATM at = new ATM();
                at.Show();
            }
            else if (option == 6)
            {
                Environment.Exit(1);
            }
            
        }


    }
}
