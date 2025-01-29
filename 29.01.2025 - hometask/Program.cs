/*1. Створи делегат, який приймає рядок і нічого не повертає. 
Створити функцію яка виводить текст в консоль. 
Використати делегат для того щоб покласти функцію в в делегат і викликати його. 

*/


namespace _29._01._2025___hometask
{
    internal class Program
    {
        delegate void TakeNoReturn (string n);
        public static void Show(string a)
        {
            Console.WriteLine(a);
            
        }
        static void Main(string[] args)
        {
            TakeNoReturn text = new TakeNoReturn(Show);
            text.Invoke("Aaaa");
        }
    }
}
