/*4. Створи інтерфейс ISerializable з методом Serialize() 
 * і Deserialize(string data). Реалізуй його в класі User.
*/namespace _21._05._2025___4
{
    internal class Program
    {
        interface ISerializable
        {
            void Serialize();
            void Deserialize();
        }
        class User : ISerializable
        {

            void ISerializable.Serialize()
            {
                Console.WriteLine("Serializing");
            }

            public void Serialize()
            {
                ISerializable s = new User();
                s.Serialize();
            }
            void ISerializable.Deserialize()
            {
                Console.WriteLine("Deserializing");
            }

            public void Deserialize()
            {
                ISerializable s = new User();
                s.Deserialize();
            }
        }
        static void Main(string[] args)
        {
            ISerializable user = new User();
            user.Serialize();
      
        }
    }
}
