
/*інтерфейс який має два методи: час поїзди, вартість
класи: корабель, потяг, автомобіль*/
namespace _22._05._2025__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
        }
    }
    interface ITester
    {
        TimeSpan Timer();
        double Price();

    }
    public class Train : ITester
    {
        double distance;
        int quantity;
        double pricePerKmTrain;

        public double Price()
        {
            double result = (distance * pricePerKmTrain) / Convert.ToInt32(quantity);
            return result;
        }

        public TimeSpan Timer()
        {
            TimeSpan result = new TimeSpan(); //Convert.ToInt32(distance / speed)
            return result;
        }
    }
    public class Ship : ITester
    {
        double distance;
        int quantity;
        double pricePerKmShip;
        public double Price()
        {
            double result = (distance * pricePerKmShip) / Convert.ToInt32(quantity);
            return result;
        }

        public TimeSpan Timer()
        {
            TimeSpan result = new TimeSpan(); //Convert.ToInt32(distance / speed)
            return result;
        }
    }

    public class Auto : ITester
    {
        double distance;
        double pricePerKmCar;

        public double Price()
        {
            double result = distance * pricePerKmCar;
            return result;
        }

        public TimeSpan Timer()
        {
            TimeSpan result = new TimeSpan(); //Convert.ToInt32(distance / speed)
            return result;
        }
    }

}

