/*public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
*/

namespace _24._06._2025
{
    internal class Program
    {
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Testcase0:");
            int a = 0;
            bool expectedResult = true;
            bool receivedResult = IsEven(a);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase1:");
            a = 1;
            expectedResult = false;
            receivedResult = IsEven(a);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }


            Console.Write("Testcase2:");
            a = 2;
            expectedResult = true;
            receivedResult = IsEven(a);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase3:");
            a = 3;
            expectedResult = false;
            receivedResult = IsEven(a);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase4:");
            a = 100;
            expectedResult = true;
            receivedResult = IsEven(a);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase5:");
            a = 1010;
            expectedResult = true;
            receivedResult = IsEven(a);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

           /* Console.Write("Testcase6:");
             a = null;
            expectedResult = null;
            receivedResult = IsEven(a);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase7:");
            a = NaN;
            expectedResult = NaN;
            receivedResult = expectedResult = IsEven(a);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }*/
        }
    }
    }
