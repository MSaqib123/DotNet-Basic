using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_2_Array_Tasks
{
    //___________ Task 14_____________
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    class LinkedList
    {
        public Node Head;

        public LinkedList()
        {
            Head = null;
        }

        public void Insert(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node currentNode = Head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }
        }

        public void PrintList()
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.Next;
            }
        }
    }


    internal class Program
    {
        //___________ Factorial and PRime Nubmer __________________
        #region Fact and PrimeNumber
        static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static int[] Factorize(int num)
        {
            int[] factors = new int[num / 2]; // The maximum number of factors won't exceed num/2

            int factorIndex = 0;

            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    factors[factorIndex++] = i;
                    num /= i;
                }
            }

            Array.Resize(ref factors, factorIndex); // Resize the array to fit the actual number of factors
            return factors;
        }
        #endregion
        //__________________________________________________

        //composit number function  --> task 9
        static bool IsComposite(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            else if (n == 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        static void Main(string[] args)
        {
            //___________________________ Interview Task ____________________________
            //_________________ 1. Task 1 ________________
            //Write a program.  if take 0 then print 1 ,  if tale 1 then print 0
            //with out if condition
            #region 0_1 value
            int aNumber = 0;          //0            // 1
            int result = 1- aNumber;   // 1-0 = 1     // 1-1 = 0 

            Console.WriteLine(result);
            #endregion


            //_________________ 1. Task 1 ________________
            //Write a program in C# to find the Similar Values in Array 
            #region similar_Values
            int[] Array1 = { 42, 42, 99, 42, 99, 99, 42, 41, 91 };
            List<int> similarValues = new List<int>();

            for (int i = 0; i < Array1.Length; i++)
            {
                for (int j = i + 1; j < Array1.Length; j++)
                {
                    if (Array1[i] == Array1[j])
                    {
                        similarValues.Add(Array1[i]);
                        break;
                    }
                }
            }

        
            // Print out the similar values
            foreach (int value in similarValues.Distinct())
            {
                Console.WriteLine(value);
            }

            var uniqueResult = similarValues.Distinct().ToList();
            uniqueResult.ForEach(x =>
            {
                Console.WriteLine(x);
            });


            //_____ using Linq ____

            int[] array = { 5, 8, 3, 1, 7, 9, 2, 5, 8 };

            var duplicateValues = array
                .GroupBy(x => x)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key)
                .ToArray();

            if (duplicateValues.Length > 0)
            {
                Console.WriteLine("Duplicate values in the array:");
                foreach (var value in duplicateValues)
                {
                    Console.WriteLine(value);
                }
            }
            else
            {
                Console.WriteLine("No duplicate values found in the array.");
            }
            #endregion


            //_________________ 2. Task 2 ________________
            //Write a program in C# to find the Minum , Maximum Values
            #region Max , Minimum
            int[] Array2 = { 5, 8, 3, 1, 7, 9, 2 };

            int min = Array2[0];
            int max = Array2[0];

            for (int i = 1; i < Array2.Length; i++)
            {
                if (Array2[i] < min)
                {
                    min = Array2[i];
                }
                if (Array2[i] > max)
                {
                    max = Array2[i];
                }
            }

            Console.WriteLine("Minimum value: " + min);
            Console.WriteLine("Maximum value: " + max);


            foreach (var item in Array2)
            {
                if (item < min)
                {
                    min = item;
                }
                if (item > max)
                {
                    max = item;
                }
            }

            Console.WriteLine(min);
            Console.WriteLine(max);
            #endregion

            //_________________ 3. Task 3 ________________
            //Find Even Odd Number from Array

            #region Even Odd number
            int[] number = { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int evenCount = 0;
            int oddCount = 0;

            // Count the number of even and odd numbers
            foreach (int number1 in number)
            {
                if (number1 % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            int[] evenNumbers = new int[evenCount];
            int[] oddNumbers = new int[oddCount];

            //Add the even and odd numbers to their respective arrays
            int evenIndex = 0;
            int oddIndex = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]%2 == 0)
                {
                    evenNumbers[evenIndex] = number[i];
                    evenIndex++;
                }
                if (number[i] % 2 == 1)
                {
                    oddNumbers[oddIndex] = number[i];
                    oddIndex++;
                }

            }

            // Print the even and odd numbers
            Console.WriteLine("Even numbers:");
            foreach (int number1 in evenNumbers)
            {
                Console.Write(number1 + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Odd numbers:");
            foreach (int number1 in oddNumbers)
            {
                Console.Write(number1 + " ");
            }


            //________________ shortest Way _____________
            Console.WriteLine("Even numbers:");
            Console.WriteLine(string.Join(", ", array.Where(item => item % 2 == 0)));

            Console.WriteLine("Odd numbers:");
            Console.WriteLine(string.Join(", ", array.Where(item => item % 2 == 1)));

            #endregion


            //_________________ 4. Task 4 ________________
            //Write a program in C# to find the sum of all even numbers in an array of integers.
            #region Sum of all Even Number , Odd number
            int[] array1 = { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    sum += array1[i];
                }
            }
            Console.WriteLine("sum of Even Number : "+ sum);

            //______________ smallest Code _________________
            var sumOfEven = string.Join(",", array.Where(item => item % 2 == 0).Sum());
            Console.WriteLine(sumOfEven);
            #endregion

            //_________________ 5. Task 5 ________________
            //Write a program To Revers a String
            #region Reverse_String
            string input = "Pakistan";//"Hello word";
            char[] charArray = input.ToCharArray();  //basic it will Divide into parts and Store Values in Array form
            Array.Reverse(charArray); //this Will Revers Above Divide array
            string reversed = new string(charArray);   //again convert  ReverseArray to string
            Console.WriteLine("The Reversed String is : " + reversed);
            #endregion  

            //_________________ 6. Task 6 ________________
            //Write a program in C# to check if a string is a palindrome.   
            //reverse krna par bhee same String === palindrome
            //Madam , PHP , Laval,racecar , minim ,   Noon , deep , wow, my gym , i did did i ,  never odd or even , borrow or rob
            #region Palindromes
            string input1 = "PHP";//"racecar";
            char[] charArray1 = input1.ToCharArray();
            Array.Reverse(charArray1);
            string reversed1 = new string(charArray1);
            if (input1 == reversed1)
            {
                Console.WriteLine("The String is a plaindrome");
            }
            else
            {
                Console.WriteLine("The String is not a plaindrome");
            }
            #endregion

            //_________________ 7. Task 7 ________________
            //Write a program  to  Find /check Prime Numbers ?
            //Prime Number :=  a number which can be divided by    1  and its own number ,  2,3,5,7,11,13,17,19 .....            
            #region Prime_Number
            //_______________________ Basic Program _______________
            #region Basic Program
            int num = 7;
            bool isPrime = true;
            //Console.WriteLine("SQure root of : " + num + " is " + Math.Sqrt(num) );
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
                //7 / 2 =  0 (Remender)    no  
                //7 / 3 =  0 (Remender)    no
                //7 / 4 =  0 (Remender)    no
                //7 / 5 =  0 (Remender)    no
                //7 / 6 =  0 (Remender)    no  ---- Prove  7 is prime number


                //6 / 2 = 0 (remender)    Yes     6 is Not prime number
            }
            if (isPrime)
            {
                Console.WriteLine("This is Prime number : " + num);
            }
            else
            {
                Console.WriteLine("This is Prime number : " + num);
            }
            #endregion

            //_______________________ Advance Program _______________
            #region AdvanceProgram
            Console.Write("Enter a positive integer: ");
            int numbersFac = int.Parse(Console.ReadLine());

            if (numbersFac <= 1)
            {
                Console.WriteLine("Please enter a positive integer greater than 1.");
            }
            else
            {
                Console.WriteLine($"Factors of {numbersFac}: {string.Join(", ", Factorize(numbersFac))}");

                if (IsPrime(numbersFac))
                {
                    Console.WriteLine($"{numbersFac} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{numbersFac} is not a prime number.");
                }
            }
            #endregion

            #endregion

            //_________________ 8. Task 8 ________________
            //Write a program in C# to find the factorial of a number.  
            //_ Factorial number    :=   5 * 4 * 3 * 2 * 1   = factorial of 5 =  120
            #region Factorial
            int num1 = 5;
            int factorial = 1;
            for (int i = 1; i <= num1; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("The Factorial of "+ num1 + " : " + factorial);
            #endregion


            //_________________ 9. Task 9 ________________
            //Write a program in C# to find the Composite number.  
            //_ Factorial number    :=   a number  can divide by its own self and as wel as by other number
            #region 
            int n = 15;
            if (IsComposite(n))
            {
                Console.WriteLine(n + " is a composite number");
            }
            else
            {
                Console.WriteLine(n + " is not a composite number");
            }
            #endregion

            
            //_________________ 10. Task 10 _______________________
            //Swap 2 values with out makieng  3rd Variable 
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


            //_________________ 10.1 Task 10.1 _______________________
            //Swap 2 values ___ of Array ______
            
            #region array_Swap

            #region 1st_Way by index
            int[] xxx = { 2, 9, 4, 5, 3, 6, 7 };

            // Find the indexes of the values to be swapped
            int in3 = Array.IndexOf(xxx, 3);
            int in6 = Array.IndexOf(xxx, 6);

            // Swap the values
            int temppp = xxx[in3];
            xxx[in3] = xxx[in6];
            xxx[in6] = temppp;

            // Print the array with swapped values
            Console.WriteLine(string.Join(", ", xxx));
            #endregion

            #region 2nd_Way by ForLoop
            int[] xx = {2,9,4,5,3,6,7};

            // Find the indexes of the values to be swapped
            int index3 = -1;
            int index6 = -1;

            for (int i = 0; i < xx.Length; i++)
            {
                if (xx[i] == 3)
                {
                    index3 = i;
                }
                else if (xx[i] == 6)
                {
                    index6 = i;
                }
    
                if (index3 != -1 && index6 != -1)
                {
                    break;
                }
            }

            // Swap the values
            int tt = xx[index3];
            xx[index3] = xx[index6];
            xx[index6] = tt;

            // Print the array with swapped values
            Console.WriteLine(string.Join(", ", x));
        #endregion

            #region 3rd_Dynamicaly
            int[] xxxx = {2,9,4,5,3,6,7};
            int val1 = 3;
            int val2 = 6;

            // Find the indexes of the values to be swapped
            int ind1 = -1;
            int ind2 = -1;

            for (int i = 0; i < xxxx.Length; i++)
            {
                if (xxxx[i] == val1)
                {
                    ind1 = i;
                }
                else if (xxxx[i] == val2)
                {
                    ind2 = i;
                }
    
                if (ind1 != -1 && ind2 != -1)
                {
                    break;
                }
            }

            // Swap the values
            if (ind1 != -1 && ind2 != -1)
            {
                int tempp = xxxx[ind1];
                xxxx[ind1] = xxxx[ind2];
                xxxx[ind2] = tempp;

                // Print the array with swapped values
                Console.WriteLine(string.Join(", ", x));
            }
            else
            {
                Console.WriteLine($"Values {val1} and {val2} not found in the array.");
            }

            #endregion

            #endregion

            //________________  11. Task 11 ______________________
            //check Even Odd number 
            
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


            //_________________ 12. Task 12 ________________
            //Write a program in C# to implement a binary search algorithm.  

            //This code is searching for a specific number in a list of numbers. To do this,
            //it uses a technique called "binary search," which is a way of finding the number
            //by dividing the list in half and checking whether the number is in the first or second half.

            //This code shows how to find a value in a sorted list of numbers quickly and efficiently using the binary search algorithm in C#.
            
            #region binary search algorithm
            int[] numbers = { 1, 2, 5, 8, 9 };
            int target = 5;
            int left = 0;
            int right = numbers.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (numbers[mid] == target)
                {
                    Console.WriteLine("The target is found at index " + mid);
                    break;
                }
                else if (numbers[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            #endregion
           


            //_________________ 13 Task 13 ________________
            //Write a program in C# to implement a bubble sort algorithm.
            
            #region bubble sort algorithm
            int[] numbers1 = { 5, 2, 8, 9, 1 };
            for (int i = 0; i < numbers1.Length - 1; i++)
            {
                for (int j = 0; j < numbers1.Length - i - 1; j++)
                {
                    if (numbers1[j] > numbers1[j + 1])
                    {
                        int temp = numbers1[j];
                        numbers1[j] = numbers1[j + 1];
                        numbers1[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("The sorted array is:");
            foreach (int nu in numbers1)
            {
                Console.Write(nu + " ");
            }
            #endregion

            //_________________ 14. Task 14 ________________
            //Write a program in C# to implement a linked list.
            
            #region linked list
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.PrintList();
            #endregion

            //_________________ 15. Task 16 ________________
            //Write a program in C# to find the second highest number in an array of integers.
            
            #region second highest number in an array of integers.
            int[] numbers2 = { 10, 20, 5, 15, 30 };
            int highest = int.MinValue;
            int secondHighest = int.MinValue;
            foreach (int num2 in numbers2)
            {
                if (num2 > highest)
                {
                    secondHighest = highest;
                    highest = num2;
                }
                else if (num2 > secondHighest && num2 != highest)
                {
                    secondHighest = num2;
                }
            }
            Console.WriteLine("The second highest number is " + secondHighest);
            #endregion


            //_________________ 16. Task 16 ________________
            //Write a program in C# to count the number of occurrences (similar) of a character in a string.
            
            #region count similar occurent
            string str = "Hello World";
            char target1 = 'l';
            int count = 0;
            foreach (char ch in str)
            {
                if (ch == target1)
                {
                    count++;
                }
            }
            Console.WriteLine("The character " + target1 + " occurs " + count + " times in the string.");
            #endregion

            //_________________ 17. Task 17 ________________
            //Write a program in C# to check if two strings are anagrams of each other.
            
            #region check if two strings are anagrams
            string str1 = "listen";
            string str2 = "silent";
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            bool isAnagram = true;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    isAnagram = false;
                    break;
                }
            }
            Console.WriteLine("The two strings are " + (isAnagram ? "" : "not ") + "anagrams of each other.");
            #endregion

            //_________________ 18. Task 18 ________________
            //Write a program in C# to find the intersection of two arrays.
            
            #region Intersection of 2 Array
            int[] array2 = { 1, 2, 3, 4 };
            int[] array3 = { 3, 4, 5, 6 };
            HashSet<int> set1 = new HashSet<int>(array2);
            HashSet<int> set2 = new HashSet<int>(array2);
            set1.IntersectWith(set2);
            int[] intersection = set1.ToArray();
            Console.WriteLine("The intersection of the two arrays is:");
            foreach (int num2 in intersection)
            {
                Console.Write(num2 + " ");
            }
            #endregion


            //_________________ 19. Task 19 ________________
            //Write a program in C# to find the maximum sum subarray in an array of integers.
            #region MyRegion
            int[] numbers3 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int maxSoFar = numbers3[0];
            int maxEndingHere = numbers3[0];
            int startIndex = 0;
            int endIndex = 0;
            for (int i = 1; i < numbers3.Length; i++)
            {
                if (maxEndingHere + numbers3[i] > numbers3[i])
                {
                    maxEndingHere += numbers3[i];
                }
                else
                {
                    maxEndingHere = numbers3[i];
                    startIndex = i;
                }
                if (maxEndingHere > maxSoFar)
                {
                    maxSoFar = maxEndingHere;
                    endIndex = i;
                }
            }
            Console.WriteLine("The maximum sum subarray is:");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(numbers3[i] + " ");
            }
            #endregion

            
            Console.WriteLine("end");

        }
    }
}
