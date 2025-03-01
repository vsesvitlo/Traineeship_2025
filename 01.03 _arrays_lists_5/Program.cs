/*5. Напиши код, який знаходить максимальне та 
 * мінімальне значення у списку чисел.*/
namespace _01._03__arrays_lists_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> list = new List<int>();
           list.AddRange(new int [] { 9, 8, 444, 1 });
           Console.WriteLine(list.Min());
           Console.WriteLine(list.Max());
        }
    }
}
