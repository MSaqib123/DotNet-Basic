using System;
using System.Collections.Generic;
using System.Text;

namespace _3_BankSystem_By_OOP._1_ATM
{
    internal class Customer : Account
    {
        public void show()
        {
            Customer cus = new Customer();
            cus._Amount = 15000;
            menu:
            Console.WriteLine("____ Welcome to Customer Account _____");
            Console.WriteLine("\n1) Check Amount\t 2) Deposit Amount  \t 3) WidthDrow Amount \t 4) LogOut \t 5) Exit\n");
            Console.Write("Enter Option : ");

            byte option = byte.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("\n Your Bank_Amount : " + cus._Amount);
                Console.ReadLine();

                Console.Clear();
                goto menu;
            }
            else if (option == 2)
            {
                Console.Write("\nDeposit Amount : ");
                int amount1 = int.Parse(Console.ReadLine());
                cus._Amount = cus._Amount + amount1;
                if (amount1 < 0 )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Amount");

                    Console.ReadLine();
                    Console.Clear();
                    Console.ResetColor();
                    goto menu;
                }
                else
                {
                    Console.WriteLine("After Adding _" + amount1 + " , Your Current Balance is  : " + cus._Amount);
                    Console.ReadLine();

                    Console.Clear();
                    goto menu;
                }
            }
            else if (option == 3)
            {
                Console.Write("\nWidthDrow Amount : ");
                int amount2 = int.Parse(Console.ReadLine());
                if (amount2 >= cus._Amount)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("insufficient balance");

                    Console.ReadLine();
                    Console.Clear();
                    Console.ResetColor();
                    goto menu;
                }
                else
                {

                }
                cus._Amount = cus._Amount - amount2;
                Console.WriteLine("After WithDrow _" + amount2 + " , Your Current Balance is  : " + cus._Amount);
                Console.ReadLine();

                Console.Clear();
                goto menu;
            }
            else if (option == 4)
            {
                Console.Write("Do you Want to Logout : ");
                Console.ReadLine();
                Console.Clear();
                ATM at = new ATM();
                at.Show();
                goto menu;
            }
            else if (option == 5)
            {
                Environment.Exit(1);
            }
        }
    }
}
