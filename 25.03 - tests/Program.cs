//https://leetcode.com/problems/longest-common-prefix/description/
namespace _25._03___tests
{
    internal class Program
    {
        public static string Comparing(IEnumerable<string> source)
        {
            string result = "";
            int count = 0;
          int shortSize = source.ElementAt(0).Length;
          for(int k = 0; k < source.Count(); k++)
            {
                if (shortSize > source.ElementAt(k).Length)
                {
                   shortSize = source.ElementAt(k).Length;
                }
             
            }
            for (int j = 0; j < shortSize; j++)
                {
                for (int i = 0; i < source.Count(); i++)
                {
                    if  (source.ElementAt(0).ElementAt(j) == source.ElementAt(i).ElementAt(j))
                    {
                        count++;
                        
                    }
                    else{

                    }

                }
                if (count == source.Count())
                {
                    result += source.ElementAt(0).ElementAt(j);
                }
                count = 0;
            }
            
            return result;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("TestCase 1");
            string[] input1 = {
                "flower","flow","flight"
            };
            string expectedOutput1 = "fl";
            string receivedOutpur1 = Comparing(input1);
            if (receivedOutpur1 != expectedOutput1)
            {
                Console.WriteLine(false);
                Console.WriteLine($"Expected {expectedOutput1}");
                Console.WriteLine($"Recieved {receivedOutpur1}");
            }
            else 
            { 
                Console.WriteLine(true);
            }
            Console.WriteLine("TestCase 2");
            input1 = new string[]{
                "dog","racecar","car"
            };
            expectedOutput1 = "";
            receivedOutpur1 = Comparing(input1);
            if (receivedOutpur1 != expectedOutput1)
            {
                Console.WriteLine(false);
                Console.WriteLine($"Expected {expectedOutput1}");
                Console.WriteLine($"Recieved {receivedOutpur1}");
            }
            else
            {
                Console.WriteLine(true);
            }
            Console.WriteLine("TestCase 3");
            input1 = new string[]{
                "dog","door","doctor"
            };
            expectedOutput1 = "do";
            receivedOutpur1 = Comparing(input1);
            if (receivedOutpur1 != expectedOutput1)
            {
                Console.WriteLine(false);
                Console.WriteLine($"Expected {expectedOutput1}");
                Console.WriteLine($"Recieved {receivedOutpur1}");
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}
