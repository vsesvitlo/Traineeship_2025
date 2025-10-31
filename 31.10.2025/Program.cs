using System.Globalization;

namespace _31._10._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 6, 5, 1, 2, 4, 9 };
            Sorter sorter = new InsertionSorter();
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
        class InsertionSorter : Sorter
        {
            public override void Sort(int[] first)
            {
                int forMin = 0;

              for(int a = 0; a < first.Length; a++)
                {
                    for (int b = first.Length - 1; b >= a; b--)
                    {
                        if (first[a] > first[b])
                        {
                            forMin = first[a];
                            first[a] = first[b];
                            first[b] = forMin;

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


