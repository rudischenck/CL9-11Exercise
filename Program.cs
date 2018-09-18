using System;

namespace CL9_18Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completed = false;
            while(!completed)
            {
                try 
                {
                    Vehicle vehicle = new Vehicle();

                    Console.Write("What is the color of your vehicle? ");
                    vehicle.Color = Console.ReadLine();

                    Console.Write("How much horsepower does your vehicle have? ");
                    vehicle.Horsepower = int.Parse(Console.ReadLine());

                    Console.Write("How much fuel can your vehicle hold? ");
                    vehicle.FuelCapacity = double.Parse(Console.ReadLine());

                    vehicle.OutPutToFile();
                    Console.WriteLine("A file has been created.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid input.");
                    continue;
                }
                completed = true;
            }
        }
    }
}
