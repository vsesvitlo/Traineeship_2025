namespace _10._03___1
{
    internal class Program
    {
        public static int DigitSum(int a)
        {
            int result = 0;
            string forConverting = Convert.ToString(a);

            for(int i = 0; i < forConverting.Length; i++)
            {
                int forSumming = int.Parse(forConverting[i] + "");
                result += forSumming;
                
            }
            return result;
        }
        static void Main(string[] args)
        {
            int showSum = DigitSum(255);
            Console.WriteLine(showSum);
        }
    }
}
