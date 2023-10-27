using _3_BankSystem_By_OOP.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3_BankSystem_By_OOP
{
    internal class Entry
    {
		static void Main(string[] args)
		{
			AppScreen.Welcome();
			//___ 1st ___
			//string cardNumber = Utility.GetUserInput("your cardNumber ");
			//Console.WriteLine($"Your cardNumber is {cardNumber}");
			//___ 2nd ___
			//long cardNumber = validator.Convert<long>("Your card number");
			//Console.WriteLine($"Your cardNumber is {cardNumber}");

			//___ 3rd ___
			ATM atmApp = new ATM();
			atmApp.InitializeData(); //1st lazmi to Load Data for list
			atmApp.CheckUserCardNumAndPassword();
			atmApp.Welcome();

			Utility.PressEnterToContinue();
		}
	}
}
