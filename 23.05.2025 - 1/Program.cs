namespace _23._05._2025___1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                int b = 0;
                int x = a / b;
            }
            catch (Exception e) 
            {
            Console.WriteLine(e);
                try
                {
                    int[] arr = { 1, 2 };
                    Console.WriteLine(arr[6]);
                }
                catch(Exception a)
                {
                    Console.WriteLine(a);
                }

            }
            finally
           {
                Console.WriteLine("Try and catch - done");
           }
        }
    }
}
