using System;

namespace sixthTask
{
    public static class TaskExtensions
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci hesablama rəqəmini daxil edin: ");
            Int32 firstNum;
            bool firstInput = Int32.TryParse(Console.ReadLine(), out firstNum);
            Console.Write("Hesablama simvolunu daxil edin: ");
            char symbol;
            bool symbolInput = char.TryParse(Console.ReadLine(), out symbol);
            Console.Write("Ikinci hesablama rəqəmini daxil edin: ");
            Int32 secondNum;
            bool secondInput = Int32.TryParse(Console.ReadLine(), out secondNum);


            if (firstInput && secondInput)
            {
                if (symbol == '*' || symbol == '/' || symbol == '+' || symbol == '-')
                {
                    if (symbol == '*')
                    {
                        Int32 result = firstNum * secondNum;
                        Console.Write(result);
                    }
                    else if(symbol == '/')
                    {
                        Int32 result = firstNum / secondNum;
                        Console.Write(result);
                    }
                    else if (symbol == '+')
                    {
                        Int32 result = firstNum + secondNum;
                        Console.Write(result);
                    }
                    else if (symbol == '-')
                    {
                        Int32 result = firstNum - secondNum;
                        Console.Write(result);
                    }

                }
                else
                {
                    Console.WriteLine("Düzgün simvol daxil edin");
                }
            }


            else
            {
                Console.WriteLine("Düzgün rəqəm daxil edin");
            }
        }
    }
}