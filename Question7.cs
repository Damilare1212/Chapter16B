using System;
using System.Collections.Generic;
using System.Collections;

namespace  Chapter_16
{
    class Question7
    {
        public static void Answer()
        {
                int [] arr = {3, 4, 4, 2, 3, 3, 4, 3, 2};
                List<int> arrr = new List<int>();
               Hashtable  hash = new Hashtable ();
               foreach(var item in arr)
               {
                   if (hash.Contains(item))
                   {
                         hash[item] = (int )hash[item] + 1;
                   }
                   else
                   {
                      hash.Add(item,1);
                   }
                    
               }

             foreach (DictionaryEntry it in hash)
             {
                 Console.WriteLine($"{it.Key} apears {it.Value} times");
             }
            
              
        }
    }
}