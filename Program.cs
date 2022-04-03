using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение просит пользователя ввести результат его экзамена
            //результат экзамена - это одна буква от A до F
            //A - Outstanding
            //B - Superior
            //C - Good
            //D - Satisfactory
            //E - Low Pass
            //F - Failure
            
            Console.WriteLine("Enter your exam result:");
            char userInput = Convert.ToChar(Console.ReadLine().ToUpper());

            if(userInput == 'A')
            {
                Console.WriteLine("Outstanding!");
            }
            if (userInput == 'B')
            {
                Console.WriteLine("Superior!");
            }
            if (userInput == 'C')
            {
                Console.WriteLine("Good!");
            }
            if (userInput == 'D')       
            {
                Console.WriteLine("Satisfactory.");
            }
            if (userInput == 'E')
            {
                Console.WriteLine("Low Pass.");
            }
            if (userInput == 'F')
            {
                Console.WriteLine("Low Pass.");
            }
        }
    }
}
