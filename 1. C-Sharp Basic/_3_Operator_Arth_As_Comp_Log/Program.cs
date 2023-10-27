using System;

namespace _3_Operator_Arth_As_Comp_Log
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //_________1. Arthmatic_Operators_______________
            //+,-,/,*,%  are Arthmatic Operators
            #region Arthmatic_Operators(+,-,*,/,%)
            /*
            Console.WriteLine("_________1.Arthmatic_Operators_____________");

            int a = 25;
            int b = 4;

            //---1. Addition---
            int add = a + b;
            Console.WriteLine("Adition of 2 num = " + add);

            //---2. Substrction---
            int sub = a - b;
            Console.WriteLine("Substration = " + sub);

            //---3. Multiplication---
            int mult = a * b;
            Console.WriteLine("Multiplication = " + mult);

            //---4. Division---
            int div = a * b;
            Console.WriteLine("Division = " + div);

            //---4. Modulas--- Remender of Division
            int Mod = a % b;
            Console.WriteLine("Modulas = " + Mod);
            */
            #endregion

            //_________2. Assighnment Operators_______________
            #region Assighment_Operator(=,+=,-=,*=,/=) always Right to Left Assighment
            /*
            Console.WriteLine("_____________2. Assighment_Operator_________________");

            //___= assighment opertor___
            int v1 = 25;
            int v2 = 5;
            int ass = (v1 = v2);                        //v2 ke value  v2 ko Assign kr dee
            Console.WriteLine("Assighment V2 to V1 = " + v1);

            //___+= assighment+Addition opertor___
            int v3 = 25;
            int v4 = 5;
            int ass1 = (v4 += v3);                        
            Console.WriteLine("Add_Assig V4 to V3 = " + v4);

            //___-= assighment,- opertor___
            int v5 = 25;
            int v6 = 5;
            int ass2 = (v6 -= v5);                        
            Console.WriteLine("Subst_Assig V6 to V5 = " + v6);

            //___-= assighment,- opertor___
            float v7 = 25;
            float v8 = 5;
            float ass3 = (v8 /= v7);
            Console.WriteLine("div_Assig V7 to V8 = " + v8);

            */
            #endregion

            //_________3. Compairgine Operators  | Relational Operatos_______________
            #region Compairgine_Operators(==,!=,>,<,>=,<=)
            //==,!=,>,<,>=,<=  Give Values  in  (True,False)
            /*
            //---(==)---
            int v1 = 25;
            int v2 = 25;//26;
            Console.WriteLine("v1 "+v1+ " == v2 " + v2+ " = " + (v1==v2));

            //---(!=)---
            int v3 = 25;
            int v4 = 26;//25;
            bool result = (v3 != v4);
            Console.WriteLine("v3 " + v3 + " != v4 " + v4 + " = " + result);

            //---(>)--- 
            int v5 = 25;
            int v6 = 35;//15;
            bool result1 = (v5 > v6);        //jis tarf is  ke Nook ho ge  wo chotaa haaa
            Console.WriteLine("v5 " + v5 + " > v6 " + v6 + " = " + result1);

            //---(<)---
            int v7 = 25;
            int v8 = 20;//27;
            bool result2 = (v7 < v8);
            Console.WriteLine("v7 " + v7 + " < v6 " + v8 + " = " + result2);

            //---(>=)---
            int a = 25;
            int b = 30; //25;   //20;
            bool r1 = (a >= b);
            Console.WriteLine("a " + a + " >= b " + b + " = " + r1);

            //---(>=)---
            int c = 25;
            int d = 30; //25; //20; //30;
            bool r2 = (c<=d);
            Console.WriteLine("c " + c + " <= d " + d + " = " + r2);

            */
            #endregion

            //_________4. Logical Operators_______________
            #region Logical_Operator(&&,||)

            /*
            //_____&& (and) Operator______
            //2 values    should be True
            bool v1 = true;
            bool v2 = false;//true;
            bool res1 = (v1 && v2);  //true
            Console.WriteLine("&& Operator Required Both (True Values) = " + res1);

            //_____|| (or) Operator______
            //1 values    Should be True
            bool a = false;//true;
            bool b = false;//true;
            bool res2 = (v1 || v2);  //true
            Console.WriteLine("|| Operator Required 1 (True Value) = " + res2);
            */

            //__________&&,|| used make   Multiple Conditions________________aga parhaan gaa
            #endregion

            //_________5. ++(Increment), --(decrement)  _____________________
            #region ++,--
            //--- ++ ----
            Console.WriteLine("___________++____________");
            int a = 25;
            Console.WriteLine("No Increment = " + a);
            a++;
            Console.WriteLine("after Increment(--) = " + a + "\n");

            //____ -- ____
            Console.WriteLine("___________--____________");
            int b = 25;
            Console.WriteLine("No Decrement = " + b);
            b--;
            Console.WriteLine("after Decrement(--) = " + b);

            #endregion

        }
    }
}
