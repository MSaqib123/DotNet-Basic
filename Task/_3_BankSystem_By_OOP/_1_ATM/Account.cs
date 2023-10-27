using System;
using System.Collections.Generic;
using System.Text;

namespace _3_BankSystem_By_OOP._1_ATM
{
    internal class Account
    {

        //__________ Incapsulation (UserName , Password) _____________

        private int accountNumber;
        public int _accountNumber
        {
            set
            {
                accountNumber = value;
            }
            get
            {
                return accountNumber;
            }
        }


        private string Name;
        public string _userName
        {
            set
            {
                Name = value;
            }
            get
            {
                return Name;
            }
        }


        private int Amount;
        public int _Amount
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalide Amount");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Amount = value;
            }
            get
            {
                return Amount;
            }
        }
        


        private int deposit;
        public int _deposit
        {
            set
            {
                deposit = value;
            }
            get
            {
                return deposit;
            }
        }


        private char type;
        public char _type
        {
            set
            {
                type = value;
            }
            get
            {
                return type;
            }
        }



    }
}
