namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int wheels;
            bool input = false;

            do
            {
                Console.WriteLine("Enter the amount of tires for the vehicle you want to create:");

                input = int.TryParse(Console.ReadLine(), out wheels);

            } while (input == false);

            var vehicle = VehicleFactory.GetVehicle(wheels);
            vehicle.Drive();
        }
    }
}
