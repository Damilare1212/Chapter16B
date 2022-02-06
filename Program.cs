using System;

namespace Chapter_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine("Enter 1 for question 1\nEnter 2 for question 2\nEnter 3 for question 3\nEnter 4 for question 4\nEnter 5 for question 5\nEnter 6 for question 6\nEnter 7 for question7\nEnter 8 for question 8\nEnter 9 for question 9\nEnter 10 for question 10");
            var answer = int.Parse(Console.ReadLine());

            // while (true)
            // {
                if (answer == 1)
                {
                    Question.Answer();
                }
                if (answer == 2)
                {
                    Question2.Answer();
                }
                if (answer == 3)
                {
                    Question3.Answer();
                }
                if (answer == 4)
                {
                    Question4.Answer(); 
                }
                if (answer == 5)
                {
                    Question5.Answer();  
                }
                if (answer == 6)
                {
                    Question6.Answer();
                }
                if (answer == 7)
                {
                    Question7.Answer();
                }
                if (answer == 8)
                {
                    Question8.Answer(); 
                }
                if (answer == 9)
                {
                    Question9.Answer();   
                }
                if (answer == 10)
                {
                    Question10.Answer();            
                
                }
               
           // }      
                
               


        }
    }
}
