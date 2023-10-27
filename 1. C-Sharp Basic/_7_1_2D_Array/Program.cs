using System;

namespace _7_1_2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //_______________________ Types of Array _____________________________
            //1. Single Dimantion array
            //2. 2d Aarray  =  (talbe wise array)


            //_________________________ 2d Arrya ____________________________
            #region 2d_Array
            //Syntax 
            /*
                datatype[row,colum]  = new int[rowLength , columnLength];
            */

            //____ Example #1 ______________
            int[,] myArray1 = new int[1, 2];  //1 row , 1 colum
            myArray1[0, 0] = 5;
            myArray1[0, 1] = 15;
            Console.WriteLine(myArray1[0, 0] + " " + myArray1[0, 1]);

            //____ Example #2 ______________
            int[,] myArray = new int[3, 2]
            {
                { 1, 2 },//1_Row , 2 Column
                { 3, 4 },//2_row , 2 Col 
                { 5, 6 } //3_row , 2 col
            };
            Console.WriteLine(myArray[0, 0] + " " + myArray[0, 1]);
            Console.WriteLine(myArray[1, 0] + " " + myArray[1, 1]);
            Console.WriteLine(myArray[2, 0] + " " + myArray[2, 1]);

            //____ Example #3 ______________
            //____ Example #2 ______________
            int[,] myArray2 = new int[3, 3]
            {
                { 1, 2 , 15},//1_Row , 2 Column
                { 3, 4 , 20},//2_row , 2 Col 
                { 5, 6 , 444} //3_row , 2 col
            };
            Console.WriteLine(myArray2[0, 0] + " " + myArray2[0, 1] + " " + myArray2[0, 2]);
            Console.WriteLine(myArray2[1, 0] + " " + myArray2[1, 1] + " " + myArray2[1, 2]);
            Console.WriteLine(myArray2[2, 0] + " " + myArray2[2, 1] + " " + myArray2[2, 2]);
            #endregion


            //_________________________ 2d Array + loop ____________________________
            #region 2d Array
            int[,] myArray3 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine(myArray3.GetLength(0));
            Console.WriteLine(myArray3.GetLength(1));

            for (int row = 0; row < myArray3.GetLength(0); row++) // 0 = row
            {
                for (int col = 0; col < myArray3.GetLength(1); col++) // 1 = col
                {
                    //Console.WriteLine(myArray3[row,col] + " => " + row + "," +col);
                    Console.Write(myArray3[row, col] + " ");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
