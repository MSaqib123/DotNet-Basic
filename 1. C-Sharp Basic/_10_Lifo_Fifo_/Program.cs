using System;
using System.Collections.Generic;

namespace _10_Lifo_Fifo_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //____________________ Lifo ___________________________
            #region Lifo

            
            //"LIFO" stands for "Last In, First Out," and a stack is a data structure that follows this principle.The.NET framework provides a built -in implementation of a stack in the System.Collections.Generic namespace.
            // Create a new stack of integers
            Stack<int> stack = new Stack<int>();
           
            // Push some integers onto the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Pop items off the stack and print them
            Console.WriteLine(":::: Lifo");
            while (stack.Count > 0)
            {
                int item = stack.Pop();
                Console.WriteLine(item);
            }

            Stack<string> s = new Stack<string>();
            s.Push("Message 1");
            s.Push("Message 2");
            s.Push("Message 3");
            while (s.Count > 0)
            {
                string item = s.Pop();
                Console.WriteLine(item);
            }

            #endregion

            //____________________ Fifo ___________________________
            #region Fifo

            //"FIFO" stands for "First In, First Out," and a queue is a data structure that follows this principle. The .NET framework provides a built-in implementation of a queue in the System.Collections.Generic namespace.
            // Create a new queue of integers
            Queue<int> queue = new Queue<int>();

            // Enqueue some integers onto the queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Dequeue items from the queue and print them
            Console.WriteLine(":::: Fifo");
            while (queue.Count > 0)
            {
                int item = queue.Dequeue();
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}
