using System;

namespace forthTask
{
    public static class TaskExtensions
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci rəqəm: ");
            int firstNumber;
            bool firstInput = int.TryParse(Console.ReadLine(), out firstNumber);
            Console.Write("Ikinci rəqəm: ");
            int secondNumber;
            bool secondInput = int.TryParse(Console.ReadLine(),out secondNumber);

            if(firstInput && secondInput)
            {
                Console.WriteLine(firstNumber*secondNumber);
            }
            else
            {
                Console.WriteLine("Düzgün rəqəm daxil edin");
            }
        }
    }
}