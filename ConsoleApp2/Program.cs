using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // 1. Создание объекта и вывод ToShortString()
        Magazine mag = new Magazine();
        Console.WriteLine("=== ToShortString() ===");
        Console.WriteLine(mag.ToShortString());

        // 2. Проверка индексатора
        Console.WriteLine("\n=== Проверка индексатора ===");
        Console.WriteLine($"Weekly: {mag[Frequency.Weekly]}");
        Console.WriteLine($"Monthly: {mag[Frequency.Monthly]}");
        Console.WriteLine($"Yearly: {mag[Frequency.Yearly]}");

        // 3. Установка свойств и вывод ToString()
        mag.Name = "Научные открытия";
        mag.Frequency = Frequency.Weekly;
        mag.ReleaseDate = new DateTime(2024, 3, 20);
        mag.Circulation = 5000;
        Console.WriteLine("\n=== ToString() после изменения свойств ===");
        Console.WriteLine(mag.ToString());

        // 4. Добавление статей
        mag.AddArticles(
            new Article(new Person("Иван", "Петров"), "Искусственный интеллект", 4.8),
            new Article(new Person("Мария", "Сидорова"), "Квантовые вычисления", 4.9)
        );
        Console.WriteLine("\n=== ToString() после добавления статей ===");
        Console.WriteLine(mag.ToString());

        // 5. Сравнение времени работы с массивами
        Console.WriteLine("\n=== Сравнение массивов ===");
        int size = 100000;

        // Одномерный массив
        Article[] singleArray = new Article[size];
        Stopwatch watch = Stopwatch.StartNew();
        for (int i = 0; i < size; i++) singleArray[i] = new Article();
        watch.Stop();
        Console.WriteLine($"Одномерный массив: {watch.ElapsedMilliseconds} мс");

        // Прямоугольный массив
        Article[,] rectArray = new Article[100, 1000];
        watch.Restart();
        for (int i = 0; i < 100; i++)
            for (int j = 0; j < 1000; j++)
                rectArray[i, j] = new Article();
        watch.Stop();
        Console.WriteLine($"Прямоугольный массив: {watch.ElapsedMilliseconds} мс");

        // Ступенчатый массив
        Article[][] jaggedArray = new Article[100][];
        for (int i = 0; i < 100; i++) jaggedArray[i] = new Article[1000];
        watch.Restart();
        for (int i = 0; i < 100; i++)
            for (int j = 0; j < 1000; j++)
                jaggedArray[i][j] = new Article();
        watch.Stop();
        Console.WriteLine($"Ступенчатый массив: {watch.ElapsedMilliseconds} мс");
    }
}