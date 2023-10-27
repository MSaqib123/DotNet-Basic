using System;


//__________________________ 1. Example ____________________________
// Creating Delegate
public delegate int add(int x, int y);

//__________________________ 2. Example ____________________________
public delegate int Operation(int x, int y);

namespace _13_Delegates
{
    //________________________________ 2. Example (Calculator) _____________________________________
    class Calculator
    {
        public int PerformOperation(Operation op , int v1 , int v2)
        {
            int result = 0;

            result = op(v1,v2);

            return result;  //this can be  , * - / + ...
        }
    }




    internal class Program
    {
        //________________________________ 1. Example _____________________________________
        private static int sum(int a,int b)
        {
            return a + b;
        }



        static void Main(string[] args)
        {
            //________________________________ Delegates ____________________________________
            //delegate used in  Complex Program  where  10000s  of  Function and Methods are writen

            //1. Delegate is Used to  Hide  the Actual Method/function
            //2. Delegate Allow us to Pass Methods  As  Arguments(parameter)    (new level  now we can Pass Mathod as Parameter)  -- phlaa hum   int,string..  ko  parameter me pas krtaa thaa
            //3. Delegate is used to  encapsulate  the Method.

            //---> 1. Delegates are Created    >    OUT Side of  <     nameSpace hahahahaahahah
            //---> 2.  Jis DataType ka  Method ho ga  >  usi type ka  >>  Delegate bnaa gaa


            //__________________________ 1. Example ____________________________
            #region Example
            //1. Create function sum
            int s = sum(5,5);
            int s1 = sum(100, 5);  //if i want sum again ---> then we have to Call  sum function Again & Again   this Will couse memory issue

            //2. Create deletegte
            add delegate1 = new add(sum);  //asaa function pass kro  ---> jis me   int,int ka paramter hon
            int v1 = delegate1(10,5);  //app kho ga ya kyaa ya to hum ---> Simple function sa bhi kr sktaa thaa
            int v2 = delegate1(50000,55);
            int v3 = delegate1(50000,55);//kya main dubaraa SUM use kyaa   -- NO
            int v4 = delegate1(50000,55);//kya main dubaraa SUM use kyaa   -- NO
            int v5 = delegate1(50000,55);//kya main dubaraa SUM use kyaa   -- NO
            int v6 = delegate1(50000,55);//kya main dubaraa SUM use kyaa   -- NO
                                         //1. thats the banifet of  Delegate  
                                         //2. sum() is  encapsulized by  Degate
            #endregion


            //__________________________ 2. Example  (using Class)____________________________
            #region Calculator
            //abb dakhoo Main  Banifit of  Delegates

            // Create a new instance of the Calculator class
            Calculator calc = new Calculator();

            // Call the PerformOperation method with a delegate that adds two numbers
            int cal1 = calc.PerformOperation((a, b) => a + b, 2, 3);
            Console.WriteLine(cal1);

            //
            int cal2 = calc.PerformOperation((a, b) => a * b, 4, 5);
            Console.WriteLine(cal2);

            #endregion

        }
    }
}
