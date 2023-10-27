using System;

namespace _4_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //_______________dataTypes________________________
            //1. int,float,double,decimal,long....  datatype
            //2. string, char,        datatype
            //3. bool  (true,false)   datatype
            //4. Array                datatype
            //5. object  datatype     datatype    (build in)
            //6. class                datatype    (user_define)
            //7. Delegate             datatype
            //8. interface            datatype


            //__________Basice DataTypes_____________
            int integer = 25;
            float floating = 15.55f;
            double doubleing = 5235;
            decimal decimaling = 124;
            long longing = 234;
            string stringing = "abx";
            bool booling = false;


            //__________Escape Sequence__________________________
            /*
                \'    Single quote, need for character litters
                \"    Single quote, need for character litters
                \\    
                \0
                \a
                \b
                \f
                \n
                \r
                \t
                \v
                \?
                \ooo
                \xhh
                \uhhhh
            */

            Console.WriteLine("\'pakista' ");
            Console.WriteLine(" \"pakista\" ");
            Console.WriteLine(" \\  ");
            Console.WriteLine("\0 0");
            Console.WriteLine("\a a ");
            Console.WriteLine("\b b b \b \b \b");
            Console.WriteLine("\f f=break line \f\f\f\f");  //
            Console.WriteLine("\n\n sdf");
            Console.WriteLine("\r\r PPk");
            Console.WriteLine("\t\t\t   t=tab   ");
            Console.WriteLine("\v v= ");
        }
    }
}
