/*Створіть делегат Operation, який приймає два числа і повертає число.
 * Напишіть методи Add (додавання) і Multiply (множення).
 * Використайте делегат для виклику цих методів.
*/

namespace _26._02
{
    internal class Program
    {
        delegate int Operation(int a, int b);

        static int Multiply(int e, int f)
        {
            int result = e * f;
            return result;
        }
        static void Main(string[] args)
        {
            Operation Add = (int x, int y) => x + y;
            Operation Mult = Multiply;
            Console.WriteLine(Mult(7,8));
            Console.WriteLine(Mult.Invoke(3,5));
        }
    }
}
