//int[] num = new int[] {3, 9, 6, 2, 2, 1, 5, 7,1};
//int{} result = new int[]{3,9,10,6,8}

using System.Xml.XPath;

namespace _05._02._2025___task_for_385
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 3, 9, 6, 2, 2, 1, 5, 7, 1 };
            int result = 0;
            for (int i = 0; i < num.Length - 1; i++)
            {
                /*result = num[i];
                num[i] = num[i + 1];
                while ((result + num[i] <= 10) && (num[i] + num[i + 1]) <= 10)
                {
                    result = num[i] + num[i + 1];
                }
                */
                
                if ((result + num[i] <= 10) && (num[i] + num[i+1]) <= 10) { 
               //  while((result + num[i] <= 10))
                    {
                        
                        

                    }
                    //result += num[i];
                    
                   result = num[i] + num[i + 1];

                 }
                 else
                {
                 result = num[i];

                } 
                
                /*while (result <= 10)
                {
                    result = num[i] + num[i + 1];
                }*/
                Console.WriteLine(result);

                result = 0;
               
            }
        }
    }
}
