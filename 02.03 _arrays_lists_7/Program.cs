/*7. Напиши програму, яка заповнює список із 10 
 * елементів випадковими числами від 1 до 50, 
 * а потім створює масив, 
 * що містить тільки унікальні значення зі списку.*/namespace _02._03__arrays_lists_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> ();
            var rand = new Random();
            int count = 0;
            int countUnique = 0;
            for (int i = 0; i < 10; i++)
            {
                list.Add(rand.Next(1, 50));
                //Console.WriteLine(list[i]);
            }
            List<int> unique  = list.Distinct().ToList();
            count = unique.Count(); 
            int[] newArr = new int[count];
            unique.ToArray().CopyTo (newArr, 0);
            foreach (int k in unique)
            {
                Console.WriteLine(k);
            }
            
            /*foreach (int j in list) {
                if (j == j)
                {
                    count++;
                    countUnique = 10 - count;
                    
                }
                
            }
            Console.WriteLine(countUnique);
            int [] unique = new int [countUnique];
            foreach (int j in unique) 
            { 
                for (int k = 0; k < count; k++)
                {
                    if (j != j)
                    {
                      unique[k] = j;
                    }
                     Console.WriteLine(unique[k]);   
                }
                
            }*/
        }
    }
}
