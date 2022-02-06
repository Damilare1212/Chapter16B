using System;
using System.Collections.Generic;

namespace Chapter_16
{
    class Question
    {
        public static void Answer()
        {
            double sum = 0;
            double average = 0;
            List<int> Mylist = new List<int>();

              string c = " ";
               try
              {
                    while (true)
                    {
                        Console.WriteLine("ente your positive integers");
                            string xx = Console.ReadLine();
                            int y = int.Parse(xx);
                            Mylist.Add(y);

                            if (xx == c)
                            {
                                break;
                            }
                    }    

              }   
             
              catch (Exception ex)
              {
                    Console.WriteLine(ex.Message);
              }
              Console.WriteLine();
             


            for(int i = 0; i< Mylist.Count; i++)
            {
              
                sum += Mylist[i];
                average = sum / Mylist.Count;
              
            }
            Console.WriteLine($"the sum of the number is {sum}");
            Console.WriteLine($"the average of the number is {average}"); 
        }
    }
}