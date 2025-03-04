/*3. Напиши програму, яка додає новий елемент
 * у середину масиву цілих чисел (масив має мати парну кількість елементів).
*/namespace _01._03__arrays_lists_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4 };
            int[] ints2 = new int[5];
            int k = 88;
          
            for (int j = 0, i = 0; j < ints2.Length; j++, i++)
            {
                    ints2[j] = ints[i];
                    if (j == ints.Length / 2)
                    {
                        i--;
                        ints2[j] = k;
                    }
                    else if(i == ints.Length)
                    {
                        ints2[j] = ints[ints.Length - 1];
                    }
                    
                Console.WriteLine(ints2[j]);
            }
        }
    }
}
