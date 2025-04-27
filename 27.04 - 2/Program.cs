/*Завдання 2: Властивість з приватним set
Створи клас User, у якому є властивість Username.
Set встановлює імена не більше як 8 літер, якщо більше то обрізає до 8*/
namespace _27._04___2
{
    public class User
    {
        public string username;
        public User(string username)
        {
            this.username = username;
        }
        public string Username {
            get
            {
                return username;
            }
            set
            {
                if (username.Length > 8)
                {
                    username = username.Substring(0, 8);
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
            FirstExample.Username = "F"; //??
            Console.WriteLine(FirstExample.Username);

            User SecondExample = new User("Phild");
            SecondExample.Username = "Phild";
            Console.WriteLine(SecondExample.Username);// difference betweeen Usernsme and username ??
        }
    }
}
