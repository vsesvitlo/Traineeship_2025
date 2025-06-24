namespace _24._06._2025___2
{
    internal class Program
    {
        public static string Capitalize(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToUpper(input[0]) + input.Substring(1);
        }
 

        static void Main(string[] args)
        {
            Console.Write("Testcase0:");
            string input = "";
            string expectedResult = "";
            string receivedResult = Capitalize(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            
             Console.Write("Testcase1:");
            input = "drrrra";
            expectedResult = "Drrrra";
            receivedResult = Capitalize(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase2:");
            input = "a drrrra";
            expectedResult = "A drrrra";
            receivedResult = Capitalize(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase3:");
            input = null;
            expectedResult = null;
            receivedResult = Capitalize(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }


            Console.Write("Testcase4:");
            input = "null";
            expectedResult = "Null";
            receivedResult = Capitalize(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }


            Console.Write("Testcase5:");
            input = "a d r r r r a";
            expectedResult = "A d r r r r a";
            receivedResult = Capitalize(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase6:");
            input = " a d r r r r a";
            expectedResult = " a d r r r r a";
            receivedResult = Capitalize(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Testcase6:");
            input = " ";
            expectedResult = " ";
            receivedResult = Capitalize(input);
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
