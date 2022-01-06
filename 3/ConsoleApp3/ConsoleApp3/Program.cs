using System;

namespace thirdTask
{
    public static class TaskExtensions
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Rəqəm daxil edin: ");
            string userInput = Console.ReadLine();
            bool Input = Int32.TryParse(userInput, out num);

            if (Input)
            {
                Console.WriteLine(num * 2);
            }
            else
            {
                Console.WriteLine("Düzgün rəqəm daxil edin!!!");
            }
            
        }
    }
}