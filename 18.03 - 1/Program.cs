namespace _18._03___1
{
    internal class Program
    {
        static public bool YearCheck(int year) {
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else 
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(YearCheck(year));
        }
    }
}
