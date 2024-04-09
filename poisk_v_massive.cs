using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем начальный массив строк
        string[] initialArray = { "apple", "banana", "cat", "dog", "elephant", "fox" };

        // Выводим начальный массив
        Console.WriteLine("Initial array:");
        PrintArray(initialArray);

        // Получаем новый массив строк длиной не более 3 символов
        string[] newArray = FilterArray(initialArray);

        // Выводим новый массив
        Console.WriteLine("\nNew array with strings of length <= 3:");
        PrintArray(newArray);
    }

    // Метод для фильтрации массива строк
    static string[] FilterArray(string[] array)
    {
        int count = 0;
        // Определяем количество строк, которые удовлетворяют условию
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив с учетом найденного количества строк
        string[] result = new string[count];
        int index = 0;
        // Заполняем новый массив строками, удовлетворяющими условию
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                result[index++] = str;
            }
        }

        return result;
    }

    // Метод для вывода массива строк в консоль
    static void PrintArray(string[] array)
    {
        foreach (string str in array)
        {
            Console.WriteLine(str);
        }
    }
}
