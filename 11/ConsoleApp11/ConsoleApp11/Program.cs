using System;

namespace taskEleven
{
    public static class Task
    {
        static void Main(string[] args)
        {
            Console.Write("Əməliyyat rəqəmi: ");
            int number;
            bool input = int.TryParse(Console.ReadLine(),out number);

            if (input)
            {
                Console.WriteLine($"{(8*number+45)/25-9}");
            }
            else
            {
                Console.Write("Əməliyyat rəqəmini düzgün daxil edin");
            }
        }
    }
}