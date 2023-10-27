using System;
using System.Linq;

namespace _9_1_Enum
{

    enum Months { Jan,Fab,March,Apr,May,Jun,Jul};
    enum Colors {red,green,blue,black,yellow,pink,orange};
    internal class Program
    {


        enum Days {Sun , Mon , Tue , Wed, Thu, Fri, Set }

        static void Main(string[] args)
        {
            //--___________________________________________________ Enum  (enumeration / counting )_____________________________________________________
            //1. Enumeration  ==>  user-defined value type
            //2. Enum ===> Constent Values    =======>   Used where The Values will Not Be Changed  
            //3. used to represent a list ===> of  constants Values  (month)(days)(...)
            //4. Syntax  ===> created using the enum keyword
            //---> its Created ====> (Inside Class) + (OutSide Class)


            //______________________________ 1. Inside Class ________________________________
            #region Enum _Inside_Class

            //_____ Enum Values _______
            Console.WriteLine("enum : " + Days.Sun);
            Console.WriteLine("enum : " + Days.Mon);
            Console.WriteLine("enum : " + Days.Tue);
            Console.WriteLine("enum : " + Days.Wed);
            Console.WriteLine("enum : " + Days.Thu);
            Console.WriteLine("enum : " + Days.Fri);
            Console.WriteLine("enum : " + Days.Set);

            //_____ Enum Positon (from 0) _______
            Console.WriteLine("enum position : " + (int)Days.Sun);
            Console.WriteLine("enum position : " + (int)Days.Mon);
            Console.WriteLine("enum position : " + (int)Days.Tue);
            Console.WriteLine("enum position : " + (int)Days.Wed);
            Console.WriteLine("enum position : " + (int)Days.Thu);
            Console.WriteLine("enum position : " + (int)Days.Fri);
            Console.WriteLine("enum position : " + (int)Days.Set);
            #endregion


            //______________________________ 2. OutSide Class Class ________________________________
            #region Enum _OutSide_Class
            //_____ Enum Values _______
            Console.WriteLine("enum : " + Colors.black);
            Console.WriteLine("enum : " + Colors.red);
            Console.WriteLine("enum : " + Colors.blue);
            Console.WriteLine("enum : " + Colors.pink);
            Console.WriteLine("enum : " + Colors.orange);
            Console.WriteLine("enum : " + Colors.yellow);
            Console.WriteLine("enum : " + Colors.red);


            //_____ Enum Positon (from 0) _______
            Console.WriteLine("enum position : " + (int)Colors.black);
            Console.WriteLine("enum position : " + (int)Colors.red);
            Console.WriteLine("enum position : " + (int)Colors.blue);
            Console.WriteLine("enum position : " + (int)Colors.pink);
            Console.WriteLine("enum position : " + (int)Colors.orange);
            Console.WriteLine("enum position : " + (int)Colors.yellow);
            Console.WriteLine("enum position : " + (int)Colors.red);
            #endregion

        }
    }
}
