/*6. Реалізуй програму, яка додає до масиву новий елемент, 
 * не створюючи новий масив вручну (використай List<T> для зручності).*/
namespace _01._03__arrays_lists_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                a += 1;
                arr[i] = a;
                //Console.WriteLine(a);
            }
            List<int>list = arr.ToList();
            //Console.WriteLine(arr.GetType());
            list.Add(111);
            list.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(list.GetType());
        }
    }
}
