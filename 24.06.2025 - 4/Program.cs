namespace _24._06._2025___4
{
    internal class Program
    {
        public static string GetNumbers(string input)
        {
            if (input == null)
                return input;
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 58)
                {
                    result += input[i];
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Testcase0:");
            string[] inputs = { "3 + 2 = 6", "3 s 2 = 6", "2 * 3 = 6", "* 3 = 6", null, " ", "" };
            string [] expectedResults = { "326", "326", "236", "36", null, "", "" };
         
            for (int i = 0; i < expectedResults.Length; i++)
            {
                string receivedResults = GetNumbers(inputs[i]);
                Console.WriteLine($"Testcase{i}:");
                if (receivedResults == expectedResults[i])
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }
           
            string input = "3 + 2 = 6";
            string expectedResult = "326";
            string receivedResult = GetNumbers(input);
            if (expectedResult == receivedResult) {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }
/*
            Console.WriteLine("Testcase1:");
            input = "3 s 2 = 6";
            expectedResult = "326";
            receivedResult = GetNumbers(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.WriteLine("Testcase2:");
            input = "2 * 3 = 6";
            expectedResult = "236";
            receivedResult = GetNumbers(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }


            Console.WriteLine("Testcase3:");
            input = "* 3 = 6";
            expectedResult = "36";
            receivedResult = GetNumbers(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.WriteLine("Testcase4:");
            input = null;
            expectedResult = null;
            receivedResult = GetNumbers(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.WriteLine("Testcase5:");
            input = " ";
            expectedResult = "";
            receivedResult = GetNumbers(input);
            if (expectedResult == receivedResult)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.WriteLine("Testcase6:");
            input = "";
            expectedResult = "";
            receivedResult = GetNumbers(input);
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
