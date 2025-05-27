/*чотири операції, в один делегат, викликати делегат*/

namespace _27._05._2025
{
    delegate void Mathematical(int x, int y);

    internal class Program
    {
        public static void Sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }
        public static void Min(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
        }
        public static void Mult(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
        }
        public static void Del(int a, int b)
        {
            int result = a / b;
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Mathematical example1 = Sum;
            //example1.Invoke(20, 2);
            example1 += Min;
            //example1.Invoke(20, 6);
            example1 += Mult;
            //example1.Invoke(1, 3);
            example1 += Del;
            example1.Invoke(21, 3);
        }
    }
}
