using System;
using System.Collections.Generic;
using System.Text;

namespace _3_BankSystem_By_OOP._1_ATM
{
    internal class ATM
    {
        byte option;
        public void Show()
        {
            Console.WriteLine("_________ Welcome To Our Bank ________");
            Console.WriteLine("Select Account :  \t 1) Employee Account   \t 2) Customer Account");

            Console.Write("Option : ");
            option = byte.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.Clear();
                Employee emp = new Employee();
                emp.show();
            }
            else if (option == 2)
            {
                Console.Clear();
                Customer cust = new Customer();
                cust.show();
            }
            else
            {

            }
        }
    }
}
