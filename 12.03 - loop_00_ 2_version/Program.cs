namespace _12._03___loop_00__2_version
{
    internal class Program
    {
        public static int[] MoveZeroes(int[] nums)
        {
            for (int i = 0, j = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] == 0)
                {
                    if (nums[j] != 0)
                    {
                        nums[i] = nums[j];
                        nums[j] = 0;
                        j++;
                    }
                    else
                    {
                        while (nums[j] == 0 && j < nums.Length - 1)
                        {
                            j++;

                        }
                        nums[i] = nums[j];
                        nums[j] = 0;

                    }

                }
                else
                {
                    j++;
                }
            }
            return nums;
        }
         static void Main(string[] args)
        {
            int[] nums = {4, 2, 4, 0, 0, 3, 0, 5, 1, 0};
            int[] nums2 = MoveZeroes(nums);
            for (int i = 0; i < nums2.Length; i++)
            {
                Console.WriteLine(nums2[i]);
            }
        }
    }
}
