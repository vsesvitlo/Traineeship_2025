using System.Globalization;

namespace _09._10._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 3, 8, 1, 2, 4, 9 };
            Sorter sorter = new SelectionSorter();
            
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
                
            }
        }
    }
}
