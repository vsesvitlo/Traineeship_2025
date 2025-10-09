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
            int[] arr = new int[] { 5, 3, 8, 1, 2, 4, 9};
            Sorter sorter = new BubbleSorter();
            //sorter.Sort(arr);
            //sorter.ReturnResult(arr);
            Sorter sorterQ = new QuickSorter();
            sorterQ.Sort(arr);
           // sorterQ.ReturnResult(arr);

        }
        abstract class Sorter {
            public abstract void Sort(int[] first);
            public void ReturnResult(int[] result)
            {
                for(int a = 0; a < result.Length; a++)
                {
                    Console.WriteLine(result[a]);
                }

            }
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

            }
            //public abstract int Compare(int x, int y);

        }
        class QuickSorter : Sorter
        {
            public override void Sort(int[] first)
            {
                int pivot = first[first.Length - 1];
                int[] newAr = new int[first.Length];
                int k = newAr.Length - 1;
                int j = 0;
                int count1 = 0;
                int count2 = 0;
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] < pivot)
                    {
                        count1++;

                        if( j < newAr.Length)
                        {
                            newAr[j] = first[i];
                            j++;
                        }
                    }
                    else
                    {
                        count2++;
                       if ( k >= 0)
                        {
                            newAr[k] = first[i];
                            k--;
                        }
                    }
                }
                int[] new1arr = new int[count1];
                int[] new2arr = new int[count2];
                //Array.Copy(newAr, new1arr, count1);
                Array.Copy(newAr, count1+1 , new2arr, 0, count2);
    

                for (int d = 0; d < new1arr.Length; d++)
                {
                    //Console.WriteLine(new1arr[d]);
                }
                for (int e = 0; e < new2arr.Length; e++)
                {
                   Console.WriteLine(new2arr[e]);
                }
            }
           
        }
    }
}
