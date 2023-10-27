using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _3_BankSystem_By_OOP.UI
{
    public static class Utility
    {

        //_____________ 1. CardNumber _____________
        public static string GetSecretInput(string prompt)
        {
            bool isPrompt = true;
            string asterics = "";
            StringBuilder input = new StringBuilder();
            while (true)
            {
                if (isPrompt)
                    Console.WriteLine(prompt);
                isPrompt = false;
                //_____Password = ReadKey(true)_____
                ConsoleKeyInfo inputkey = Console.ReadKey(true);

                //check_Input
                if(inputkey.Key == ConsoleKey.Enter)
                {
                    //check_ 6 Digit
                    if (input.Length == 6)
                    {
                        break;
                    }
                    else
                    {
                        PrintMessage("\nPlease Enter 6  Digits.", false);
                        isPrompt = true;
                        input.Clear();
                        continue;
                    }
                }
                if (inputkey.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input.Remove(input.Length - 1, 1);
                }
                else if (inputkey.Key != ConsoleKey.Backspace)
                {
                    input.Append(inputkey.KeyChar);
                    //values in  **** formate
                    Console.Write(asterics + "*");
                }
            }
            return input.ToString();
        }

 

        //_____________ 2. GetAccouontNumber __________
        public static string GetUserInput(string prompt) //is ko bar bar cal kr lain ga
        {
            Console.WriteLine($"Enter {prompt} : ");
            return Console.ReadLine();
        }



        //___ Print Message ____
        public static void PrintMessage(string msg, bool success = true)
        {
            if (success)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
            PressEnterToContinue();
        }

        //--- Dot ... Print 
        public static void PrintDotAnimation()
        {
            int timer = 10;
            for (int i = 0; i < timer; i++)
            {
                Console.Write(".");
                //delay
                Thread.Sleep(200);
            }
            Console.Clear();
        }

        //__ to ReadLine __
        public static void PressEnterToContinue()
        
        {
            Console.WriteLine("\n\nPress Enter to Continue...\n");
            Console.ReadLine();
        }
    }
}
