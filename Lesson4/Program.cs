using System;

namespace Урок_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            var input = Console.ReadLine().AsSpan();

            if (!int.TryParse(input, out var monthNumber))
            {
                Console.WriteLine("Ошибка");
                return;
            }

            if (monthNumber < 1 || monthNumber > 12)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                return;
            }

            var season = monthNumber switch
            {
                12 or <= 2 => YearSeason.Winter,
                <= 5 => YearSeason.Spring,
                <= 7 => YearSeason.Summer,
                _ => YearSeason.Autumn
            };
            Console.WriteLine($"Сезон {season}");
            Console.ReadLine();
        }

        private enum YearSeason
        {
            Winter, Spring, Summer, Autumn
        }


    }

}
