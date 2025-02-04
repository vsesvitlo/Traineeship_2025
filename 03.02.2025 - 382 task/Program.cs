/*Напишіть програму, на вхід якої даються чотири числа a, b, c і d, 
 * кожне у своєму рядку. Програма повинна вивести фрагмент таблиці 
 * множення для всіх чисел відрізка [a; b] на всі числа відрізка [c; d]. 
 * Числа a, b, c і d є натуральними і не перевищують 10, a ≤ b, c ≤ d. 
 * Дотримуйтесь формату виведення як у вихідних даних.
 * Для поділу елементів всередині рядка використовуйте 
 * \t - символ табуляції. Зауважте, що лівим стовпчиком і
 *  верхнім рядком виводяться самі числа із заданих відрізків.

Вхідні дані:

1
4
2
5
Вихідні дані:

	2	3	4	5
1	2	3	4	5
2	4	6	8	10
3	6	9	12	15
4	8	12	16	20
*/

namespace _03._02._2025___382_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = 4;
            int[] data = new int[z];
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Enter, please the 4 numbers  " +
                "from 1 to 9, a <= b, c <= d");
                string enters1 = Console.ReadLine();
                int forCalc1 = int.Parse(enters1);
                data[i] = forCalc1;
            }
            int a = data[0];
            int b = data[1];
            int c = data[2];
            int d = data[3];
            int k = 0;
            int l = 0;

            int m = 0;
            Console.Write("\t");
            for (int r = c; r <= d; r++)
            {
                l = r;
                Console.Write(l);
              
                Console.Write("\t");
            }
            Console.WriteLine();
            for (int e = a; e <= b; e++)
            {
                k = e;
                Console.Write(k);
                Console.Write("\t");
                
                for (int f = c; f <= d; f++)
                {
                    l = f;
                    m = k * l;
                    
                   //Console.Write(l);
                    
                    Console.Write(m);
                    Console.Write("\t");

                }

                Console.WriteLine();
            }
        }
    }
}
