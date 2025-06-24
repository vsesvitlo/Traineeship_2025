namespace _18._06._2025___2
{
    internal class Program
    {

        public static string ReduceDoubles(string a)
        {
            if (a == null)
                return null;

            string result = "";
            foreach (char c in a)
            {
                if (!result.Contains(c))
                {
                    result += c;
                }
            }
            return result;
        }


        static void Main(string[] args)
        {
            Console.Write("Testcase0:");
            string ex1 = "aa";
            string expectedResult = "a";
            string receivedResult = ReduceDoubles(ex1);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase1:");
             ex1 = "aa bb u";
             expectedResult = "a bu";
             receivedResult = ReduceDoubles(ex1);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase2:");
            ex1 = "a1ah77";
            expectedResult = "a1h7";
            receivedResult = ReduceDoubles(ex1);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }


            Console.Write("Testcase3:");
            ex1 = null;
            expectedResult = null;
            receivedResult = ReduceDoubles(ex1);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase4:");
            ex1 = "null";
            expectedResult = "nul";
            receivedResult = ReduceDoubles(ex1);
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
