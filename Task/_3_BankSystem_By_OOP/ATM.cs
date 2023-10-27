using _3_BankSystem_By_OOP._1_ATM;
using _3_BankSystem_By_OOP.Domain.Entites;
using _3_BankSystem_By_OOP.Domain.Interfaces;
using _3_BankSystem_By_OOP.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace _3_BankSystem_By_OOP
{

    /*
		====================
		Bank Management System
		====================
			::Main Menu::

		1. New Account
		2. Deposit Amount  (add krnaa )
		3. WithDraw Amount	(nikalna)
		4. Balance EnQuery
		5. All Account Holder List
		6. Close An Account
		7. Modify an Account
		8. Exit

		select Your Option (1-8)

		==== _1_
		Enter Account No. : _
		Enter Name of Account Holder : _
		Enter type of  Account (C/S) : _
		Enter Initial Amount : _

		Account Created..  (Enter)
		====

		==== _2_
		Account No. : (12345)
		Name Account Holder : (Saqib)
		Type of  Account (C/S) : (C)
		Balance Amount : (100)

		TO DEPOSITE AMOUNT

		Enter Amount to be Deposited : ____

		Record Updated
		====


		==== _3_
		Account No. : (12345)
		Name Account Holder : (Saqib)
		Type of  Account (C/S) : (C)
		Balance Amount : (100)

		TO WITHDRAW AMOUNT

		Enter Amount to be withdraw : ____

		Record Updated
		====

		==== _4_
		Account No. : (12345)

		BALANCE DETAILS

		Account No. 12345
		Name Account Holder : (Saqib)
		Type of  Account (C/S) : (C)
		Balance Amount : (200)
		====
		*/


    internal class ATM: IUserLogin
	{
		//_____________ ATM_1 ______________________
		//static void Main(string[] args)
		//      {
		//	ATM at = new ATM();
		//	at.Show();
		//}

		//_____________ ATM_2 ______________________


		private List<UserAccount> userAccountList;
		private UserAccount selectedAccount;

        public void InitializeData()
        {
			userAccountList = new List<UserAccount>
			{
				new UserAccount{Id=1,FullName="M Saqib", AccountNumber=112233, CardNumber= 43577535, CarPin=123455, AccountBalance=50000.00m,IsLooked=false},
				new UserAccount{Id=2,FullName="Asif Ali", AccountNumber=332211, CardNumber= 1034702, CarPin=123456, AccountBalance=70000.00m,IsLooked=false},
				new UserAccount{Id=3,FullName="Akram Ali", AccountNumber=445566, CardNumber= 112233, CarPin=123454, AccountBalance=50000.00m,IsLooked=true}
			};
        }


		public void CheckUserCardNumAndPassword()
        {
            bool isCorrectLogin = false;
			int invalid = 0;
            //UserAccount tempUserAccount = new UserAccount();
            //tempUserAccount.CardNumber = validator.Convert<long>("your card number");
            //tempUserAccount.CarPin = Convert.ToInt32(Utility.GetSecretInput("Enter Your Card Pin"));//?;

			while (isCorrectLogin == false)
			{
				UserAccount inputAccount = AppScreen.UserLoginForm();
				AppScreen.LoginProgress();
                foreach (UserAccount account in userAccountList)
                {
					selectedAccount = account;
                    if (inputAccount.CardNumber.Equals(selectedAccount.CardNumber))
                    {
						
                        if (inputAccount.CarPin.Equals(selectedAccount.CarPin))
                        {
							selectedAccount = account;
                            if (selectedAccount.TotalLogin > 3)
                            {
								//--Print a lock message--    in App Screen
								AppScreen.PrintLockScreen();
							}
                            else
                            {
								//--Print successfuly message--    in App Screen
								selectedAccount.TotalLogin = 0;
								isCorrectLogin = true;
								invalid = 0;
								break;
							}
						}
                        
                    }
					else
					{
						selectedAccount.TotalLogin++;
					}
					if (isCorrectLogin == false)
					{
						invalid = 1;	
					}
				}
                if (invalid == 1)
                {
					Utility.PrintMessage("\nInvalid Card number or PIN", false);
					selectedAccount.IsLooked = selectedAccount.TotalLogin == 3;
					if (selectedAccount.IsLooked)
					{
						AppScreen.PrintLockScreen();
					}
					Console.Clear();
				}
				
			}
			//Console.Write("\nChecking Card number and PIN...");
			//int timer = 10;
			//for (int i = 0; i < timer; i++)
			//{
			//    Console.Write(".");
			//    //delay
			//    Thread.Sleep(200);
			//}
			//Console.Clear();
		}

		public void Welcome()
        {
			Console.WriteLine($"Welcome Back, {selectedAccount.FullName}");
        }


    }
}