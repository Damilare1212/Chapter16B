using System;
using System.Collections.Generic;
using System.Collections;

namespace Chapter_16
{
    class Question2
    {
        public static void Answer()
        {
            Console.WriteLine("enter your N : numbers");
            int num = int.Parse(Console.ReadLine());

           Stack<int> Mystack = new Stack<int>();

           for (int i = 1; i<=num; i++)
           {
               Mystack.Push(i);
              // Console.WriteLine(i);
            
           }

           foreach (var item in Mystack)
           {
               Console.Write($"{item} ");
             // Mystack.Pop();
           }



           // using queue
            //    Console.WriteLine("enter N numbers");
            //    int nums = int.Parse(Console.ReadLine());
            //    Queue<int> Myque = new Queue<int>();

            //    for (int i =nums ; i>=0; i--)
            //    {
            //        Myque.Enqueue(i);
                
            //    }

            //    foreach(var q in Myque)
            //    {
            //        Console.Write($"{q} ");

            //    } 



        }
    }
}