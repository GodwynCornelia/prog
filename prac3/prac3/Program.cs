using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace practise3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                list.Add(random.Next(1, 101));
            }

            Console.WriteLine("Начальная коллекция:");
            PrintCollection(list);

            list.Add("Hello, world!");

            Console.WriteLine("\nПосле добавления строки:");
            PrintCollection(list);

            Console.Write("Введите элемент для удаления: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int element))
            {
                if (list.Contains(element))
                {
                    list.Remove(element);
                    Console.WriteLine($"\nЭлемент {element} удален.");
                }
                else
                {
                    Console.WriteLine($"\nЭлемент {element} не найден в коллекции.");
                }
            }
            else
            {
                Console.WriteLine("\nНеверный ввод.");
            }

            Console.WriteLine("\nКоллекция после удаления элемента:");
            PrintCollection(list);

            Console.WriteLine($"\nКоличество элементов в коллекции: {list.Count}");

            Console.Write("\nВведите элемент для поиска: ");
            input = Console.ReadLine();
            if (int.TryParse(input, out element))
            {
                int index = list.IndexOf(element);
                if (index != -1)
                {
                    Console.WriteLine($"Элемент {element} найден на индексе {index}.");
                }
                else
                {
                    Console.WriteLine($"Элемент {element} не найден.");
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод.");
            }
        }

        static void PrintCollection(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

