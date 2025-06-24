namespace _24._06._2025___3
{
    internal class Program
    {
        public static string Reverse(string input)
        {
            return new string(input.Reverse().ToArray());
        }

        static void Main(string[] args)
        {
            Console.Write("Testcase0:");
            string input = "";
            string expectedResult = "";
            string receivedResult = Reverse(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase1:");
            input = " 0";
            expectedResult = "0 ";
            receivedResult = Reverse(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase2:");
            input = " ";
            expectedResult = " ";
            receivedResult = Reverse(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase3:");
            input = "abc";
            expectedResult = "cba";
            receivedResult = Reverse(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase4:");
            input = "abcdcba";
            expectedResult = "abcdcba";
            receivedResult = Reverse(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase5:");
            input = "Abcdcba";
            expectedResult = "abcdcbA";
            receivedResult = Reverse(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase6:");
            input = "AbcdcbA1";
            expectedResult = "1AbcdcbA";
            receivedResult = Reverse(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            Console.Write("Testcase7:");
            input = " Abcdcba";
            expectedResult = "abcdcbA ";
            receivedResult = Reverse(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase8:");
            input = "  Abcdcba";
            expectedResult = "abcdcbA  ";
            receivedResult = Reverse(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }


            Console.Write("Testcase9:");
            input = "Abcdcba  ";
            expectedResult = "  abcdcbA";
            receivedResult = Reverse(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase10:");
            input = null;
            expectedResult = null;
            receivedResult = Reverse(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }


            Console.Write("Testcase11:");
            input = "null";
            expectedResult = "llun";
            receivedResult = Reverse(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
