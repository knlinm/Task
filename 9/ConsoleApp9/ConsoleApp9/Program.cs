using System;

namespace ninthTask
{
    public static class TaskExtensions
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci bucaq: ");
            int first;
            bool firstInput = int.TryParse(Console.ReadLine(), out first);
            Console.Write("Ikinci bucaq: ");
            int second;
            bool secondInput = int.TryParse(Console.ReadLine(),out second);

            if(firstInput && secondInput)
            {
                Console.WriteLine($"Üçüncü bucaq: {180 - (first + second)}");
            }
            else
            {
                Console.WriteLine("Düzgün rəqəm daxil edin!!!");
            }

        }
    }
}