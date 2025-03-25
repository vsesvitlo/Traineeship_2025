/*13. Створи список цілих чисел, перетвори його у список рядків,
а потім виведи всі елементи списку, об'єднавши їх в один рядок через кому.
*/
namespace _25._03___13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> list = new List<int> { 1, 3, 7, 9};
           List<string> list2 = new List<string> { };
            for (int i = 0; i < list.Count; i++) {
                list2.Add(Convert.ToString(list[i]));
            }
            string result = "";
            for (int i = 0; i < list2.Count; i++) { 
                result += list2[i] + ", ";
            }
            result = result.Substring(0, result.Length - 2);
            Console.WriteLine(result);

        }
    }
}
