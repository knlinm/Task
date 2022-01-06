using System;

namespace taskTwelve
{
    public static class Task
    {
        static void Main(string[] args)
        {
            Console.Write("Ədəd: ");
            int firstNumber;
            bool firstInput = int.TryParse(Console.ReadLine(), out firstNumber);
            Console.Write("Faiz: ");
            int secondNumber;
            bool secondInput = int.TryParse(Console.ReadLine(), out secondNumber);

            if (firstInput && secondInput)
            {
                Console.WriteLine($"{firstNumber} ədədinin {secondNumber} faizi {firstNumber * secondNumber / 100}dir");
            }
            else
            {
                Console.WriteLine("Düzgün rəqəm daxil edin");
            }
        }
    }
}