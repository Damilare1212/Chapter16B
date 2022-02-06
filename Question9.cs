using System;
using System.Collections;
using System.Collections.Generic;

namespace  Chapter_16
{
    class Question9
    {
        public static void Answer()
        {
           
            int count = 0;
            List<int> Mylist = new List<int>();
           Queue<int> Myqueue = new Queue<int>();
            int a = 2;
                Mylist.Add(a);
                Myqueue.Enqueue(a);
           for (int i = 1; i<17; i++)          
            {
             
                int  b = a + 1;
               int c = 2 * a +1;
               int d = a + 2;
               
               
                Myqueue.Enqueue(b);
                Myqueue.Enqueue(c); 
                Myqueue.Enqueue(d);

                 count++;
                 if (count == 16)
                 {
                    Myqueue.Enqueue(b);
                 }
                 Mylist.Add(b);
                 Mylist.Add(c);
                 Mylist.Add(d);
                 a = Mylist[i];
                
  
  
 

           } 

           foreach(var item in Myqueue)
           {
               Console.Write($"{item} ");
           }  
            Console.WriteLine();
            
        }
    }
}