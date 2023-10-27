using System;
using System.Collections.Generic;
using System.Text;

namespace _3_BankSystem_By_OOP.Domain.Entites
{
    public class UserAccount
    {
        public int Id { get; set; }
        public long CardNumber { get; set; }
        public int CarPin { get; set; }
        public long  AccountNumber { get; set; }
        public string FullName { get; set; }
        public decimal AccountBalance { get; set; }

        //__ at End __
        public int TotalLogin { get; set; }

        public bool IsLooked { get; set; }
    }
}
