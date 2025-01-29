
/*2. Реалізуй делегат для обчислення суми двох чисел.
Напиши метод, який приймає два числа і повертає їх суму.
Використай делегат, щоб викликати цей метод.
*/
namespace _29._01._2025___hometask___2
{
    internal class Program
    {
        delegate int ForSum(int x,int y);
        public static int Sum (int a, int b) { 
            return a + b; 
        }
        static void Main(string[] args)
        {
            ForSum calc = new ForSum(Sum);
           // calc.Invoke(3, 7);
            Console.WriteLine(calc(3, 6));
        }
    }
}
