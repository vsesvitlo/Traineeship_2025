using System.Globalization;

namespace _21._10._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 3, 8, 1, 2, 4, 9 };
            Sorter sorter = new SelectionSorter();
            sorter.Sort(arr);
        }
        abstract class Sorter
        {
            public abstract void Sort(int[] first);
            public void ReturnResult(int[] result)
            {
                for (int a = 0; a < result.Length; a++)
                {
                    Console.WriteLine(result[a]);
                }

            }
        }
        class SelectionSorter : Sorter
        {
            public override void Sort(int[] first)
            {
                
                
                for(int a = 0; a < first.Length; a++)
               {
                    int storage = first[a];
                    int min = a;
                    for (int k = a; k < first.Length; k++)
                    {
                        if (storage > first[k])
                        {
                            min = k;
                            storage = first[k];
                        }
                    }
                    
                    storage = first[a];
                    first[a] = first[min];
                    first[min] = storage;
                }
                


                for (int j = 0; j < first.Length; j++)
                {
                   Console.WriteLine(first[j]);
                }
                //Console.WriteLine(storage);
            }
        }
    }
}


