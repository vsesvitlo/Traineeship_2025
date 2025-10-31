using System.Globalization;

namespace _22._10._2025
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

                int forMin = 0;
                
               for(int k = 0; k < first.Length; k++)
                {
                    for (int a = k; a < first.Length; a++)
                    {
                        if (first[k] > first[a])
                        {
                            forMin = first[k];
                            first[k] = first[a];
                            first[a] = forMin;

                        }
                    }
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


