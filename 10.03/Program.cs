namespace _10._03
{
    internal class Program
    {
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

        public static void Main(string[] args) {
          

            Console.Write("Testcase 1: ");
            List<int> input1 = new List<int>();  // input
            input1.AddRange(new int[] { 2, 3, 4, 5 });
            List<int> output1 = new List<int>();  // expected output
            output1.AddRange(new int[] { 4, 5 });
            List<int> realResult = FilterMoreThanAverage(input1); // received output
            bool isTheSame = true;
            for (int i = 0; i < realResult.Count; i++)
            {
                if (realResult[i] != output1[i])
                    isTheSame = false;
            }
            if (isTheSame) // if expected == received output
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

            Console.Write("\n\nTestcase 2: ");
            input1 = new List<int>();
            input1.AddRange(new int[] { 1, 2 });
            output1 = new List<int>();
            output1.AddRange(new int[] { 2 });
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


            Console.Write("\n\nTestcase 3: ");
            input1 = null;
            output1 = null;
            realResult = FilterMoreThanAverage(input1);
            if (realResult == output1)
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
            Console.Write("\n\nTestcase 4: ");
            input1 = new List<int>();
            input1.AddRange(new int[] { 1, 2, 3 });
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


    }
}
}
