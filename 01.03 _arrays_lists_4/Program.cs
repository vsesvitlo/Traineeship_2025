/* 4. Створи список чисел, заповни його випадковими значеннями 
 * від 10 до 99 (5 елементів), 
 * видали всі парні числа, а потім виведи оновлений список.*/
namespace _01._03__arrays_lists_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> list = new List<int>();
            var rand = new Random();
            int a = 0;
            for (int i = 0; i < 5; i++) {
                //Console.Write("{0,8:N0}", rand.Next(10, 99);
                //i = rand.Next(10, 99);
                list.Add(rand.Next(10, 99));
                //Console.WriteLine(list[i]);
               
            }



            for (int i = 0; i < list.Count; i++) {
                a = Convert.ToInt32(list[i]);
                // Console.WriteLine(list[i].GetType());
                if (a % 2 == 0)
                {
                    list.RemoveAt(i);
                }
                else
                {
                    Console.WriteLine(list[i]);
                }         
            }  
        }
    }
}
