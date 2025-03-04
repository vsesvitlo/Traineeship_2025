/*Створи список цілих чисел, потім видали з нього всі елементи, 
 * які менші за середнє арифметичне всіх чисел у списку.*/
namespace _02._03__arrays_lists_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<int> listNew = new List<int>();
            var rand = new Random();
            double median = 0;
            int forMediana = 0;
            for (int i = 0; i < 10; i++)
            {
                list.Add(rand.Next(1, 99));

            }

            foreach (int i in list)
            {
                Console.WriteLine(i);
                median += i;
            }
            median = median / list.Count;
            forMediana = (int)Math.Floor(median);
            for (int k = list.Count - 1; k >= 0; k--)
            {

               if (forMediana > list[k])
               {
                 list.RemoveAt(k);
               }

            }
            for(int l = 0; l < list.Count; l++)
            {
                Console.WriteLine(list[l]);
            }
        }
    }
}
