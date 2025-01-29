/*
4. Напиши три різні методи: приймає текст і виводить його на екран, 
приймає текст і виводить довжину тексту на екран, 
приймає текс і виводить тільки перші 3 символи.
Створи один делегат, який викликає всі ці методи.
*/namespace _29._01._2025___hometask___4
{
    internal class Program
    {

        delegate void Transite(string a);
        public static void ShowAll(string i)
        {
            Console.WriteLine(i);
        }
        public static void HowLong(string i)
        {
            int result = i.Length;
            Console.WriteLine(result);
        }
        public static void FirstThree(string i)
        {
            string result = i.Substring(0, 3);
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Transite example1 = new Transite(ShowAll);
            example1 += HowLong;
            example1 += new Transite(FirstThree);
            string a = "Abcdef";
            example1.Invoke(a);
           
        }
    }
}
