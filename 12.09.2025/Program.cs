/*Завдання 1. Алгоритм сортування
Створіть абстрактний клас Sorter з методом Sort(), який:
Завантажує дані (абстрактний метод).
Виконує сортування (абстрактний метод).
Виводить результат.
Створіть класи BubbleSorter та QuickSorter похідні від базового*/
namespace _12._09._2025
{
   internal class Program1
    {
        internal class ChangeArray
        {
           public static int[] arr3 = new int[10];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        abstract class Sorter {
            public void Sort() {

            }
            public abstract int Compare(int x, int y);

        }
    }
}
