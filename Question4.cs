using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Chapter_16
{
    class Question4
    {
        public static void Answer()
        {
            int[] arr = {1, 2, 2, 3};
            List<int> MyList = new List<int>(arr); 
            List<int> Mlist2 = new List<int>();
            List<int> Mylist3 = new List<int>();
           // List<int> test = FindSubsequenceElement(MyList,Mlist2);

            foreach (var item in   FindSubsequenceElement(MyList, Mlist2))
            {
                //  Console.Write($"{item} ");
                
            }
            Console.WriteLine();

            for (int i = 0; i< Mylist3.Count; i++)
            {
                if ( Mlist2[i] == MyList[i])
                {
                        continue;
                }
                else
                {
                    Mylist3.Add(Mlist2[i]);
                }
            }

            foreach(var item in Mylist3)
            {
                Console.Write($"{item} ");
            }
            //   foreach (var item in Mlist2)
            //   {
            //       Console.Write($"{item} ");
            //   }

            //    foreach(var ele in Mlist2)
            //    {

            //    }
    

            // foreach (var io in MyList)
            // {
            //     Console.Write($"{io} ");
            // }
            
           // for (int i = 0; i<)
            
        }
        public static  List<int> FindSubsequenceElement(List<int> x, List<int> y)
        {
            
            
            for (int i = 0; i< x.Count; i++)
            {
                for (int j = 0; j < x.Count; j++)
                {
                    if (x[i] == x[j])
                    {
                        y.Add(x[i]);
                    }    
                  
                }
               
            }
              return y;
        }
    }
}