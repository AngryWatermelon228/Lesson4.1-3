using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания 1-2");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:


                    (string firstName, string lastName, string patronimic)[] array = {
                ("Настя","Пупкина","Васильевич"),
                ("Андрей","Пупкин","Васильевич"),
                ("Генадий","Пупкин","Васильевич"),
                ("Алексей","Пупкин","Васильевич")
            };

                    for (var i = 0; i < array.Length; i++)
                        Console.WriteLine(GetFullName(array[i].firstName, array[i].lastName, array[i].patronimic));






                    static string GetFullName(string firstName, string lastName, string patronymic) =>
                        $"{firstName} {lastName} {patronymic}";
                    break;
                case 2:
                    Console.WriteLine("Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке.Ввести данные с клавиатуры и вывести результат на экран");
                    Console.WriteLine();
                    Console.WriteLine("Введите числа через пробел");
                    string? str = Console.ReadLine();
                    var words = str.Split();
                    int sum = default;
                    for (int i = 0; i < words.Length; sum += int.Parse(words[i++])) ;
                    Console.WriteLine(sum);
                    break;


            }
            Console.ReadLine();
        }
    }
}