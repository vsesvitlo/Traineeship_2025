/*Input:

'alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta'

Output:

'alpha beta gamma delta'*/

namespace _28._12._2024___remove_duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = Kata.RemoveDuplicateWords("alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta");
            Console.WriteLine(result);
        }
    }
    public static class Kata
    {
        public static string RemoveDuplicateWords(string s)
        {
            string results = "";
            string[] data = s.Split(' ');
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if (data[i] != data[j])
                    {
                        results += data[i];
                        Console.WriteLine(results);
                    }
                }
            }


            return results;

        }
    }
}
