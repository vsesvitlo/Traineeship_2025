/*Капітан Флінт закопав скарб на Острові скарбів. 
 * Він залишив опис, як знайти скарб.
 * Опис складається з рядків виду: North 5, 
 * де перше слово - одне з North, South, East, West,
 * а друге число - кількість кроків, яку потрібно пройти в цьому напрямку. 
 * Напишіть програму, яка за описом шляху до скарбу визначає 
 * точні координати скарбу, вважаючи, що початок координат 
 * знаходиться на початку шляху, вісь OX спрямована на схід,
 * вісь OY - на північ. Програма отримує на вхід послідовність 
 * рядків зазначеного виду, а введення завершується рядком зі 
 * словом Treasure!. Програма має вивести два цілих числа в один рядок 
 * з пропуском між ними - координати скарбу.

Вхідні дані:

North 5
East 3
South 1
Treasure!
Вихідні дані:

3 4
*/namespace _29._01._2025___381__flint_problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Please, enter the 1 - for North, " +
                "2 - for East, 3 - for West, 4 - for South");
            string firstPart = Console.ReadLine();
            int firstPartInt = int.Parse(firstPart);
            Console.WriteLine("Please, enter the numbers from 1 to 9 for steps");
            string secondPart = Console.ReadLine();
            int secondPartInt = int.Parse(firstPart);*/
            Console.WriteLine("Please, enter: how many steps do you plan to make");
            string steps = Console.ReadLine();
            int stepsForCalc = int.Parse(steps);
            string[] strings = new string[stepsForCalc];
            string firstPart = "";
            string secondPart = "";
            int ns = 0;
            int ew = 0;
            for (int a = 0; a < strings.Length; a++)
            {
                Console.WriteLine("Please, enter: direction (North/South/East/West)" +
                "enter the numbers from 1 to 9 for steps");
                string transform = Console.ReadLine();
                strings[a] = transform;
                //Console.WriteLine(transform);
                firstPart = "";
                secondPart = "";
                for (int i = 0; i < transform.Length; i++)
                {
                    if (transform[i] == 32)
                    {
                        firstPart += transform.Substring(0, i);
                       // Console.WriteLine(firstPart);
                        secondPart += transform.Substring(i+1, 1);
                       // Console.WriteLine(secondPart);
                    }
                }
                int secondPartInt = int.Parse(secondPart);

                if (firstPart == "North")
                {
                    ns += secondPartInt;
                    
                }
                else if (firstPart == "South")
                {
                    ns -= secondPartInt;
                   
                }
                else if (firstPart == "East")
                {
                    ew += secondPartInt;
                    
                }
                else if (firstPart == "West")
                {
                    ew -= secondPartInt;
                   
                }
                else
                {
                Console.WriteLine("Please, enter: direction (North/South/East/West)" +
               "enter the numbers from 1 to 9 for steps");
                }
               
            }
           // ns = Math.Abs(ns);
           // ew = Math.Abs(ew);
            string result = ew.ToString() + " " + ns.ToString();
            Console.WriteLine("Treasure!");
            Console.WriteLine (result);
         
        }
    }
}
