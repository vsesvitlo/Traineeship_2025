/*клас в якому 2 поля: імя вік
є властивість вік - може бути від 0 до 150 років, 
якщо менше 0 то встановити 0, якщо більше 150 то встановити 150*/
using System.Xml.Linq;

namespace _25._04._2025___1
{
   
public class User
    {
        string name;
        int age;

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public int GetAge()
        {
            if (age < 0)
            {
                return 0;
            }
            else if (age >= 150)
            {
                return 150;
            }
            else
            {
                return age;
            }
        }
        public int Age{
            get
            {
                return age;
            }
            set
            {
                if (age < 0)
                {
                    age = 0;
                }
                else if (age >= 150)
                {
                    age = 150;
                }
                else
                {
                    age = value;
                }
              
            }
        }
       
    }
    public class HelloWorld
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("");
        }
    }
}

