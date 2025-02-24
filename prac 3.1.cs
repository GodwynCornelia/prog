using System;
using System.Collections.Generic;
using System.Linq;

public class CollectionExample
{
    public static void Main(string[] args)
    {
        // a) Создание обобщенной коллекции List<float>
        List<float> floatList = new List<float>() { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f };

        // Вывод коллекции на консоль
        Console.WriteLine("Исходная коллекция List<float>:");
        PrintCollection(floatList);

        // b) Удаление из коллекции n элементов
        Console.Write("Введите количество элементов для удаления: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Ошибка: Введено некорректное количество элементов. Удаление пропущено.");
            n = 0;
        }
        Console.WriteLine($"\nУдаление {n} элементов из коллекции.");
        RemoveNElements(floatList, n);
        Console.WriteLine("Коллекция после удаления:");
        PrintCollection(floatList);

        // c) Добавление других элементов
        Console.WriteLine("\nДобавление элементов в коллекцию.");
        floatList.Add(6.6f); // Добавление одного элемента
        floatList.Add(0.7f);
        floatList.Add(0.3f);

        Console.WriteLine("Коллекция после добавления:");
        PrintCollection(floatList);

        // d) Создание второй коллекции Stack<float> и заполнение ее данными из первой коллекции
        Stack<float> floatStack = new Stack<float>(floatList);

        // e) Вывод второй коллекции на консоль
        Console.WriteLine("\nСодержимое Stack<float>:");
        PrintCollection(floatStack);

        // f) Найдите во второй коллекции заданное значение
        Console.Write("Введите значение для поиска в Stack<float>: ");
        if (!float.TryParse(Console.ReadLine(), out float searchValue))
        {
            Console.WriteLine("Ошибка: Некорректное значение для поиска. Поиск пропущен.");
            searchValue = 0; // Default value to avoid compilation error
        }
        Console.WriteLine($"\nПоиск значения {searchValue} в Stack<float>.");
        bool found = FindValue(floatStack, searchValue);
        Console.WriteLine($"Значение {searchValue} {(found ? "найдено" : "не найдено")} в Stack<float>.");
    }

    // Метод для вывода коллекции на консоль
    public static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (T item in collection)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Метод для удаления n элементов из List<float> с проверкой на допустимость
    public static void RemoveNElements(List<float> list, int n)
    {
        if (n > list.Count)
        {
            Console.WriteLine("Предупреждение: Попытка удалить больше элементов, чем есть в списке.  Удалены все элементы.");
            list.Clear(); // Удаляем все элементы, если n больше размера списка
        }
        else
        {
            list.RemoveRange(0, n); // Удаляем n элементов, начиная с индекса 0
        }
    }

    // Метод для поиска значения в Stack<float>
    public static bool FindValue(Stack<float> stack, float value)
    {
        return stack.Contains(value); // Используем Contains для поиска значения
    }
}