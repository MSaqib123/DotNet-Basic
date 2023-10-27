using _3_BankSystem_By_OOP.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _3_BankSystem_By_OOP.UI
{
    internal class AppScreen
    {
        internal static void Welcome()
        {
            Console.Clear();
            Console.Title = "My ATM App";
            Console.ForegroundColor = ConsoleColor.White;

            //set the Welcome Screen 
            Console.WriteLine("\n\n------------- Welcome to My ATM APP ------------- ");

            Console.WriteLine("Please insert your ATM card");
            Console.WriteLine("Note: Actual ATM Matchine will accept and validated a Physical ATM Card, Read Card Number and Validate it");

            //___ Ctrl+R, then Ctrl+M  Extract a method refactoring ____
            //PressEnterToContinue();
            Utility.PressEnterToContinue();
        }

        //private static void PressEnterToContinue()
        //{
        //    Console.WriteLine("\n\nPress Enter to Continue...\n");
        //    Console.ReadLine();
        //}

        internal static UserAccount UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();
            tempUserAccount.CardNumber = validator.Convert<long>("your card number");
            tempUserAccount.CarPin = Convert.ToInt32(Utility.GetSecretInput("Enter Your Card Pin"));//?;

            return tempUserAccount;
        }

        internal static void LoginProgress()
        {
            Console.Write("\nChecking Card number and PIN...");
            //int timer = 10;
            //for (int i = 0; i < timer; i++)
            //{
            //    Console.Write(".");
            //    //delay
            //    Thread.Sleep(200);
            //}
            //Console.Clear();
            Utility.PrintDotAnimation();
        }       
        
        internal static void PrintLockScreen()
        {
            Console.Clear();
            Utility.PrintMessage("Your account is Locked. Please go to The nearest branch to unlock your account. Thanks",true);
            Utility.PressEnterToContinue();
            Environment.Exit(1);
        }
    }
}
