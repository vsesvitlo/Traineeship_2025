namespace _12._03___zeroos_massive_sorting
{
    internal class Program
    {
        public static int[] MoveZeroes(int[] nums)
        {
            int size = nums.Length;
            int[] nums2 = new int[size];
            for (int i = 0, j = nums.Length - 1; i < nums.Length && j >= 0; i++, j--)
            {
                if (nums[i] != 0)
                {
                    nums2[i] = nums[i];
                }
                else
                {
                    nums2[j] = nums[i];
                    i++;
                }
            }
           return nums2;
        }
            static void Main(string[] args)
            {
            int[] nums = { 1, 2, 0, 3, 4, 5, 0 };
            int[] nums2 = MoveZeroes(nums);
            for (int i = 0; i < nums2.Length; i++) {
                Console.WriteLine(nums2[i]);
            }

        }
    }
}
