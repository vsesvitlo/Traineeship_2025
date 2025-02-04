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
*/
namespace _31._01._2025___381_task_2_version
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstPart = "";
            string secondPart = "";
            int ns = 0;
            int ew = 0;
            Console.WriteLine("Please, enter: direction (North/South/East/West)" +
            "enter the numbers from 1 to 9 for steps");
            string transform = Console.ReadLine();
            while (transform != "Treasure!")
            {
                firstPart = "";
                secondPart = "";
                if (transform != "Treasure!")
                {
                    for (int i = 0; i < transform.Length; i++)
                    {
                        if (transform[i] == 32)
                        {
                            firstPart += transform.Substring(0, i);
                            secondPart += transform.Substring(i + 1, 1);
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
                }
                else
                {
                    break;
                }
                Console.WriteLine("Please, enter: direction (North/South/East/West)" +
                "enter the numbers from 1 to 9 for steps");
                transform = Console.ReadLine();
            }
            string result = ew.ToString() + " " + ns.ToString();
            Console.WriteLine(result);

        }
    }
}
