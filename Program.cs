using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Task1
{
    internal class Program
    {
        static public char[] GenerateArray() // Отдельный метод отвечающий за генерацию массива
        {
            Random random = new Random(); // Класс для генерации случайных элементов

            string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // Строка для заполнения массива символами         
            char[] chars = new char[random.Next(10, 100)]; // Генерация массива - размер массива случайный от 10 до 100 символов

            Console.WriteLine(); // Разделение строки

            for (int i = 0; i <= (chars.Length - 1); i++) // Наполнение массива символами с помощью цикла
            {
                var index = random.Next(symbols.Length); // Выбираем случайный индекс символа из строки symbols
                chars[i] = symbols[index]; // По индексу присваиваем символ массиву и так пока цикл не завершится
                Console.Write(chars[i]);
            }
            
            Console.Write(" - сгенерированный массив");

            return chars; // Возвращаем полученный массив
        }
        static void Main(string[] args)
        {
            Console.Write("Введите любое слово или набор символов для сравнения с массивом: ");
            string? stringSymbol = Console.ReadLine(); // Строка которую вы вводите для сравнения с массивом

            char[] array1 = GenerateArray(); // Присваеваем готовый массив в новую переменную

            Console.WriteLine(); // Разделение строки

            for (int i = 0; i <= (stringSymbol?.Length - 1); i++) // Проходимся по каждому символу в строке stringSymbol
            {
                for (int j = 0; j <= (array1.Length - 1); j++) // Проходимся по каждому символу в массиве
                {
                    if (stringSymbol?[i] == array1[j]) // Сравниваем символ из строки stringSymbol с символом в массиве
                    {
                        Console.WriteLine($"{stringSymbol?[i]} - данный символ есть в массиве и он находится под индексом {j}, "); // Если символ из строки stringSymbol и символ из массива равны то выводим это символ
                    }
                }       
            }
        }
    }
}
