// 0. Ідея яка повинна бути фунція (+ 3
// 1. Заготовка функції із дефолтним поверненням (double Div(double a, double b)
// 2. Зробити набір тестів
// 3. Розробити функцію

namespace _18._06._2025___1
{
    internal class Program
    {
        static public int Sum3(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            int a = 8;
            int b = 18;
            int c = 2;

            int expectedResult = 28;
            int receivedResult = Sum3(a, b, c);
            Console.Write("Testcase 0:");
            if (expectedResult == receivedResult) {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Wrong");
            }

            Console.Write("Testcase 1:");
             a = 0;
             b = 0;
             c = 0;

            expectedResult = 0;
            receivedResult = Sum3(a, b, c);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Wrong");
            }


            Console.Write("Testcase 2:");
            a = -5;
            b = 7;
            c = -2;

            expectedResult = 0;
            receivedResult = Sum3(a, b, c);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }
    }
}
