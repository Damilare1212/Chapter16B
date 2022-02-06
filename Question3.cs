using System;
using System.Collections.Generic;

namespace Chapter_16
{
    class Question3
    {
        public static void Answer()
        {
           List<int> Mylist = new List<int>();
           string EmptyLine = " ";

            try
            {
               for(;;)
               {
                    Console.WriteLine("enter your sequence of numbers");
                    string num = Console.ReadLine();
                    int convert = int.Parse(num);

                    Mylist.Add(convert);

                    if (num == EmptyLine)
                    {
                        break;
                    }
                }
    
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
           
    
            for (int i = 0; i<Mylist.Count; i++)
            {
                for (int j = 0; j<Mylist.Count; j++)
                {
                    if (Mylist[i] < Mylist[j])
                    {
                        Mylist[i] = Mylist[i] + Mylist[j];
                        Mylist[j] = Mylist[i] - Mylist[j];
                        Mylist[i] = Mylist[i] - Mylist[j];

                    }
                }
            }
            foreach(var item in Mylist)
            {
                Console.Write($"{item} ");
            }
        }
    }
}