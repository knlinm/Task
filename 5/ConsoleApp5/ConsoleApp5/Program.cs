using System;

namespace fifthTask
{
    public static class TaskExtensions
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string SurName = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            Console.WriteLine($"Mənim adım {name}, soyadım {SurName}, yaşım isə {age}-dir");
        }
    }
}