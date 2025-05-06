/*Завдання 3: Індексатор за індексом
Створи клас Week, який зберігає масив із 7 днів тижня.
Реалізуй індексатор, щоб звертатися до дня за числовим індексом (0–6).*/
namespace _27._04___3
{
    public class Week
    {
        private string[] week = new string[7];
        public string this[int index]
        {
            get
            {
                return week[index];
            }
            set
            {
                week[index] = value;
            }
            /*if (index < 0 || index >= elements.Length)
            {
                throw new IndexOutOfRangeException("Індекс поза межами масиву.");
            }
            elements[index] = value;
        }*/
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            week[0] = "Sunday";
            week[1] = "Monday";
            week[2] = "Tuesday";
            week[3] = "Wednesday";
            week[4] = "Thursday";
            week[5] = "Friday";
            week[6] = "Saturday";
          

            Console.WriteLine(week[0]);
            Console.WriteLine(week[1]);
        }
    }
}
