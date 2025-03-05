/*            // a/b 
            // Testcase1: in: 2,1  out: 2
            // Testcase2: in: 0,1  out: 0
            // Testcase3: in: 1,0  out: double.PositiveInfinity
            // Testcase4: in: -1,0  out: double.NegativeInfinity
            // Testcase5: in: 0,0  out: double.Nan

 

            Console.Write("\n\nTestcase 4: ");
            input1 = new List<int>();
            input1.AddRange(new int[] { 1,2,3 });
            output1 = new List<int>();
            output1.AddRange(new int[] { 2, 3 });
            realResult = FilterMoreThanAverage(input1);
            isTheSame = true;
            for (int i = 0; i < realResult.Count; i++)
            {
                if (realResult[i] != output1[i])
                    isTheSame = false;
            }
            if (isTheSame)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("False");
                Console.Write($"Expected:");
                output1.ForEach((n) => { Console.Write($"{n} "); return; });
                Console.WriteLine();
                Console.Write($"Received:");
                if (realResult == null)
                {
                    Console.Write("null");
                }
                else
                    realResult.ForEach((n) => { Console.Write($"{n} "); return; });
            }
        }

        public static List<int> FilterMoreThanAverage(List<int> list)
        {
            if (list == null)
                return list;

            double median = 0;
            double forMediana = 0;

            foreach (int i in list)
            {
                median += i;
            }
            median = median / list.Count;
            forMediana = median;
            for (int k = list.Count - 1; k >= 0; k--)
            {

                if (forMediana > list[k])
                {
                    list.RemoveAt(k);
                }

            }
            return list;
        }
    }

}
*/
namespace _05._03___1
{
    internal class Program
    {
        public static double Division(int a, int b)
        {
            if (b == 0 && a > 0)
            {
                return double.PositiveInfinity;
            }
            else if (b == 0 && a < 0){
                return double.NegativeInfinity;
            }
            else if (a == 0 && b == 0)
            {
                return double.NaN;
            }
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("TestCase1:");
            int inputA = 2;
            int inputB = 0;
            double expectedOutput = double.PositiveInfinity;
            double recievedOutput = Division(inputA, inputB);
            if (recievedOutput == expectedOutput)
            {
                Console.WriteLine("Ok");
            }
            else 
            {
                Console.WriteLine("False");
            }

            Console.WriteLine("TestCase2:");
            inputA = 2;
            inputB = 1;
            expectedOutput = 2;
            recievedOutput = Division(inputA, inputB);
            if (recievedOutput == expectedOutput)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.WriteLine("TestCase3:");
            inputA = -1;
            inputB = 0;
            expectedOutput = double.NegativeInfinity;
            recievedOutput = Division(inputA, inputB);
            if (recievedOutput == expectedOutput)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.WriteLine("TestCase4:");
            inputA = 0;
            inputB = 0;
            expectedOutput = double.NaN;
            recievedOutput = Division(inputA, inputB);
            if (recievedOutput != expectedOutput)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("False");
            }


            Console.WriteLine("TestCase5:");
            inputA = 0;
            inputB = 1;
            expectedOutput = 0;
            recievedOutput = Division(inputA, inputB);
            if (recievedOutput == expectedOutput)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
