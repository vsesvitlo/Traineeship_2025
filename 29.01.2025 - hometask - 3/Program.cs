/*
 3. Створи делегат для перевірки парності числа.
Реалізуй метод, який приймає ціле число і повертає true, якщо воно парне.
Використай делегат для виклику цього методу з різними числами.
 */
namespace _29._01._2025___hometask___3
{
    internal class Program
    {
        delegate bool CheckIsDouble(int n);
        public static bool Check(int n)
        {
            bool result = false;
            if (n % 2 == 0)
            {
                result = true;
            }
            return result;
        }
        static void Main(string[] args)
        {
            CheckIsDouble check = new CheckIsDouble(Check);
            //check.Invoke(6);
            Console.WriteLine(check(7));
        }
    }
}
