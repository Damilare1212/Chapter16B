using System;
using System.Collections;
using System.Collections.Generic;

namespace  Chapter_16
{
    class Question10
    {
        public static void Answer()
        {
           int n = 5;
           int m = 16;
           int p = 0;

            Queue<int> Myqueue = new Queue<int>();
            Myqueue.Enqueue(n);
           while( Myqueue.Count > 0)
           {
              p = Myqueue.Dequeue();

                  if (p *2 > m)
                  {
                      break;
                  }

             Myqueue.Enqueue(p * 2);
             Myqueue.Enqueue(p+2);
             Myqueue.Enqueue(p+1); 
             if (p * 2 > m)
             {
                 break;
             }
             foreach(var item in Myqueue)
             {
                 Console.Write($"{item} ");
             }

           }
            

        }
    }
}