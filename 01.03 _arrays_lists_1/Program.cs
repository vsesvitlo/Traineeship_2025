/*1. Створи масив цілих чисел із 5 елементів. Заповни його значеннями від 1 до 5.
 * Потім перетвори цей масив у список і виведи всі елементи списку в консоль.*/
using _12._09._2025;

namespace _01._03__arrays_lists_1
{
    internal class Program
    {
      internal static int[] newA = new int[2];
        static void Main(string[] args)
        {
            //Array[] arr = new Array[5];
            int[] arr = new int[5];
            int a = 0;
            int[] b = Program1.ChangeArray.arr3;
            for (int i = 0; i < b.Length; i++)
            {
                a += 1;
                arr[i] = a;
                //Console.WriteLine(a);
            }
            arr.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
    public class Door
    {
        public int[] DoorShut() { 
        return Program.newA;
        }

    }
}
