using System;

namespace seventhTask
{
    public static class TaskExtensions
    {
        static void Main(string[] args)
        {
            Console.Write("Rəqəm daxil edin: ");
            int number;
            string userInput = Console.ReadLine();
            bool input = int.TryParse(userInput, out number);


            if (input)
            {
                Console.WriteLine($"{Math.Pow(number, 3.00)}");
            }
            else
            {
                Console.WriteLine("Düzgün rəqəm daxil edin!!!");
            }
        }
    }
}