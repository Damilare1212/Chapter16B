using System;
using System.Collections.Generic;
using System.Collections;

namespace  Chapter_16
{
    class Question8
    {
        public static void Answer()
        {
              List<int> Mylist = new List<int>() {2, 2, 3, 3, 2,};
           // List<int> Mylist = new List<int>() {2, 2, 3, 3, 2, 3, 4, 3, 3};
            Hashtable hash = new Hashtable();
            foreach (var element in Mylist)
            {
                if (hash.Contains(element))
                {
                    hash[element] = (int)hash[element] + 1;
                }
                else
                {
                    hash.Add(element,1);
                }
            }
            foreach(DictionaryEntry item in hash)
            {
               
                if ((int)Mylist.Count /2 + 1 == (int)item.Value)
                {
                    Console.WriteLine($"{item.Key} ");
                }
            }
        }
    }
}