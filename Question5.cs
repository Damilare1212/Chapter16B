using System;
using System.Collections.Generic;
using System.Collections;

namespace Chapter_16
{
    class Question5
    {
        public static void Answer()
        {
            int [] arr =     {19, -10, 12, -6, -3, 34, -2, 5};
              List<int> MyList = new List<int>(arr); 
            Queue <int> Myqueu = new Queue<int>();
            
            for (int i =0; i< MyList.Count; i++)
            {
                if (MyList[i] > 0)
                {
                    Myqueu.Enqueue(MyList[i]);
                }
            }
            foreach(var item in Myqueu)
            {
                Console.Write($"{item} ");
            }
        }
    }

}