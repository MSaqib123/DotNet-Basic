using System;

namespace _7_1_Class_Metod_Seald
{
    /*_______________ 1 Method Sealed__________________*/
    #region Sealed Method
    class parent
    {
        public virtual void ImportentInformation()
        {
            Console.WriteLine("2,00,000 Rs"); //Bank Balance of Parent
        }
    }
    class sealMethod : parent
    { 
        sealed public override void ImportentInformation()
        {
            Console.WriteLine("its my Parent Bank Balance : 2,00,000 Rs"); //Child ka ===> ho gay ===>  Bank Balance
        }
    }
    class childSeal : sealMethod
    {
        //public override void ImportentInformation()
        //{
        //    Console.WriteLine("0 Rs");// "2,00,000 Rs"); //Grand Child  ==>  ko   ==> Restrick kr dya  ===> BankBalnce use na kraa
        //}
    }

    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            /*_______________________________________ Seald Method  / Class_______________________________________*/
            //1. its Used to ==>   Stop  ====> Inharite Class , Method
            //2. spacific/Importent   Information ko    Seald krna ka lyaa

            /*_______________1 Method Sealed__________________*/
            childSeal ch1 = new childSeal();
            ch1.ImportentInformation(); //grandChild => can View The  Method ===> But  ===> Can not Used This Method

            /*_______________2 class Sealed__________________*/
            //class Sealed    ==> no Inharitance will work =====>  simple
            // kisi Class ko ===> Inharite honaa Roknaaa
        }

    }
}
