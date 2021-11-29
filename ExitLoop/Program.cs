using System;

namespace ExitLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите команду: ");
                string userInput = Console.ReadLine();

                if(userInput.ToLower() == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Вы ввели - \"{userInput}\", пожалуйста введите exit");
                }
            }
        }
    }
}
