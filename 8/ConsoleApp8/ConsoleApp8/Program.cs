using System;

namespace eighthTask
{
    public static class TaskExtensions
    {
        static void Main(string[] args)
        {
            Console.Write("Düzbucaqlının eni: ");
            int width;
            bool firstInput = int.TryParse(Console.ReadLine(), out width);
            Console.Write("Düzbucaqlının uzunluğu: ");
            int length;
            bool secondInput = int.TryParse(Console.ReadLine(), out length);

            if(firstInput && secondInput)
            {
                Console.WriteLine($"Düzbucaqlının perimetri {(width + length) * 2}-dir");
                Console.WriteLine($"Düzbucaqlının sahəsi {width * length}-dir");
            }
            else
            {
                Console.WriteLine("Düzgün rəqəm daxil edin!!!");
            }
        }
    }
}