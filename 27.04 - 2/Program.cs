/*Завдання 2: Влаuстивість з приватним set
Створи клас User, у якому є властивість Username.
Set встановлює імена не більше як 8 літер, якщо більше то обрізає до 8*/
namespace _27._04___2
{
    public class User
    {
        public string username;
        public User(string username)
        {
            this.Username = username;
        }
        public string Username {
            get
            {
                return username;
            }
            private set
            {
                if (value.Length > 8)
                {
                    username = value.Substring(0, 8);
                }
                else
                {
                   username = value;
                }
            }
                
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            User FirstExample = new User("Fourfournvc");
            Console.WriteLine(FirstExample.Username);

            User SecondExample = new User("Phild");
            Console.WriteLine(SecondExample.Username);
            
        }
    }
}
