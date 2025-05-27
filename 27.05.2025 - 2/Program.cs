namespace _27._05._2025___2
{
    delegate void ForSum();
    internal class Program
    {
        public static void Sum() {
        Console.WriteLine("Enter please the n - quantity of enterings");
        int n = int.Parse( Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter please the sumNum - number");
                int sumNum = int.Parse(Console.ReadLine());
                result += sumNum;
                Console.WriteLine(result);
            }
        }
        public static int sum = 0;
        public static void Calc()
        {
            Console.WriteLine("Enter please the sumNum - number");
            int sumNum = int.Parse(Console.ReadLine());
            sum += sumNum;
                Console.WriteLine(sum);
            
        }
       // += Calc

        static void Main(string[] args)
        {
            ForSum example = Sum;
            example.Invoke();
            ForSum example1 = Calc;
            example1.Invoke();
        }
    }
}
