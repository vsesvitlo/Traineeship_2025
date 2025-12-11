/*Завдання 2. Ігровий персонаж
Створіть абстрактний клас GameCharacter з методом PerformAction(), який:
Обирає зброю (абстрактний метод).
Виконує атаку (абстрактний метод).
Виводить результат бою.
Створіть класи Warrior і Mage*/


namespace _04._11._2025___1
{
   public abstract class GameCharacter()
    {
        public void PerformAction()
        {

        }
    }
    public class Warrior: GameCharacter
    {

    }
    public class Mage : GameCharacter
    {

    }

    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
