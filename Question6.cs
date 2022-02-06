using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter_16
{
    class Question6
    {
        public static void Answer()
        {
          //  int [] arr = {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2};
          int [] arr =  {1,2,2};
            List<int> Mylist1 = new List<int>();
            List<int> Mylist = new List<int>(arr);

            for (int i =2; i< Mylist.Count; i++)
            {
                if (i % 2 != 0)
                {
                    Mylist1.Add(Mylist[i]);
                }
            }

            foreach(var item in Mylist1)
            {
                Console.Write($"{item} ");
            }
        }
    }
}