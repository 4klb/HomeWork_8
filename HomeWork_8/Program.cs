using System;
using System.Globalization;

namespace HomeWork_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            var numbersService = new NumbersService();
            try
            {
                Console.WriteLine("Введите два числа(деление)");
                string firstIncomingNumber = Console.ReadLine();
                string secondIncomingNumber = Console.ReadLine();
                int result = numbersService.NumbersDivider(firstIncomingNumber, secondIncomingNumber);
                Console.WriteLine(result);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.WriteLine();

            //Задание 2
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            try
            {
                for (int i = 0; i < array.Length + 1; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Обработка массива завершена");
            }
        }
    }
}

