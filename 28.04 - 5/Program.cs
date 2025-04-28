/*Завдання 5: Індексатор за ключем
Створи клас StudentGrades, який зберігає словник оцінок.
Реалізуй індексатор 
для доступу до оцінок за назвою предмета
(наприклад, grades["Math"] = 95).*/
namespace _28._04___5
{
    public class StudentGrades
    {
        public Dictionary<string, int> grade = new Dictionary<string, int>();
        public int this[string key] //???
        {
        get { 
                return grade[key]; 
            }
        set { 
                grade[key] = value; 
            }
 }
 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> grades = new Dictionary<string, int>();//??

            grades["Math"] = 95;
            grades["English"] = 90;
            grades["Art"] = 86;

            foreach (KeyValuePair<string, int> subject in grades)
            {
                Console.WriteLine($"Subject: {subject.Key}, Grade: {subject.Value}");
            }
        }
    }
}
