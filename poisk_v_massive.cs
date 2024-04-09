using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Задаем начальный массив строк
        string[] initialArray = ["Rammstein", "Пёс", "GorrilaZ", "Цой", "Алиса", "Nightwish", "ДДТ"];

        // Выводим начальный массив
        Console.WriteLine("Рок группы и исполнители:");
        PrintArray(initialArray);

        // Получаем новый массив строк длиной не более 3 символов
        string[] newArray = FilterArray(initialArray);

        // Выводим новый массив
        Console.WriteLine("\nРок группы и исполнители из 3-х букв:");
        PrintArray(newArray);

        // Метод для фильтрации массива строк
        string[] FilterArray(string[] array)
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
        void PrintArray(string[] array)
        {
            foreach (string str in array)
            {
                Console.WriteLine(str);
            }
        }
    }
}