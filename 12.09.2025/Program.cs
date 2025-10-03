/*Завдання 1. Алгори}тм сортування
Створіть абстрактний клас Sorter з методом Sort(), який:
Завантажує дані (абстрактний метод).
Виконує сортування (абстрактний метод).
Виводить результат.
Створіть класи BubbleSorter та QuickSorter похідні від базового*/
using _01._03__arrays_lists_1;
using System.Collections.Immutable;

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
            int[] arr = new int[] { 5, 3, 8 , 2};
            Sorter sorter = new BubbleSorter();
            sorter.Sort(arr);
            Sorter sorterQ = new QuickSorter();
            sorterQ.Sort(arr);
        }
        abstract class Sorter {
            public abstract void Sort(int[] first);
        }
        class BubbleSorter : Sorter
        {
            public override void Sort(int[] first) {
                for (int i = 0; i < first.Length; i++)
                {
                    int a = 0;
                    int b = 0;
                    int c = 0;
                    for (int k = 1, j = 0; k < first.Length; k++, j++)
                    {
                        a = (int)first.GetValue(j);
                        b = (int)first.GetValue(k);

                        if (a > b)
                        {
                            c = a;
                            first[k] = a;
                            a = b;
                            first[j] = b;
                        }
                    }
                }
                for (int x = 0; x < first.Length; x++)
                {
                    Console.WriteLine(first[x]);
                }

            }
            //public abstract int Compare(int x, int y);

        }
        class QuickSorter : Sorter
        {
            public override void Sort(int[] first)
            {
                int pivot = first[first.Length - 1];
                for(int i = 0; i < first.Length; i++)
                {
                    if (first[i] > pivot)
                    {
                        for(int j = 0; j < pivot; j++)
                        {

                        }
                    }
                    else
                    {
                        for (int k = pivot; k >= 0; k--)
                        {

                        }
                    }
                }
            }
        }
    }
}
