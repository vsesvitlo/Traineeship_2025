//https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/

namespace _21._03___1
{
    internal class Program
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int count = 0;
            for (int i = 0, j = 1; i < numbers.Length; i++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    count++;
                }

            }

            int[] result = new int[count];

                for (int i = 0, j = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {


                    }

                }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
