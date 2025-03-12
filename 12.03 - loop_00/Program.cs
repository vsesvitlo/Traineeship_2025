namespace _12._03___loop_00
{
    internal class Program
    {
        public static int[] MoveZeroes(int[] nums)
        {
            int size = nums.Length;
            int[] nums2 = new int[size];
            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums2[j] = nums[i];
                    j++;
                }
                
            }
            return nums2;
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 0, 3, 4, 5, 0 };
            int[] nums2 = MoveZeroes(nums);
            for (int i = 0; i < nums2.Length; i++)
            {
                Console.WriteLine(nums2[i]);
            }

        }
    }
}
