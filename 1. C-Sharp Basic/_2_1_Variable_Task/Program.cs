using System;

namespace _2_1_Variable_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //_____ Interview Task ___
            #region InterveTask
            /*
                Write a program that calculates the area of a rectangle. The program should accept user input for the width and height of the rectangle and store them in variables. Then, it should calculate the area using the formula area = width * height and print out the result.
                Write a program that calculates the circumference and area of a circle. The program should accept user input for the radius of the circle and store it in a variable. Then, it should calculate the circumference using the formula circumference = 2 * pi * radius (where pi is a constant value of 3.14159) and the area using the formula area = pi * radius^2. Finally, it should print out the results.
                Write a program that determines if a number is even or odd. The program should accept user input for a number and store it in a variable. Then, it should use an if statement to check if the number is even (i.e. divisible by 2) or odd and print out the result.
                Write a program that determines if a number is positive, negative, or zero. The program should accept user input for a number and store it in a variable. Then, it should use an if statement to check if the number is positive, negative, or zero and print out the result.
                Write a program that determines if a year is a leap year. The program should accept user input for a year and store it in a variable. Then, it should use an if statement to check if the year is a leap year (i.e. divisible by 4 and not divisible by 100, unless it is also divisible by 400) and print out the result.
             */
            #endregion

            //______________________ 1. Swap Values Task _______________________
            #region Swap_Values
            //___ 1. Swap Values ___
            int a = 5;
            int b = 7;

            Console.WriteLine("Before Swap");
            Console.WriteLine("a = " + a + " , b = " + b + "\n");

            //__ add __
            a = a + b;
            Console.WriteLine("a : " + a);

            //_____ substract _____
            b = a - b;
            a = a - b;

            Console.WriteLine("\nafter Swap");
            Console.WriteLine("a = " + a + " , b = " + b);


            int x = 20;
            int y = 40;

            x = x + y; //60

            y = x - y; //60 - 40  = 20
            a = x - y; //60 - 20  = 40

            Console.WriteLine("\n\n Complex ----- X : " + x + " , Y = " + y);
            #endregion

            //______________________ 2. check Even Odd number ______________________
            #region Check Even Odd Values
            Console.WriteLine("\n\n\n");
            var v1 = 9;//10; //even , odd

            var v2 = ((v1 % 2) == 0);
            //Console.WriteLine(v2); //true 0 ,  false
            if (v2 == true)  //if condition hum agaa prhain  filhaal 
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            #endregion

        }
    }
}
