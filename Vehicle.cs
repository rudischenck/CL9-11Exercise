using System;
using System.IO;

namespace CL9_18Exercise
{
    public class Vehicle
    {
        public string Color { get; set; } = null;
        public int Horsepower { get; set; } = 0;
        public double FuelCapacity {get; set;} = 0;

        public void OutPutToFile() 
        {
            using(StreamWriter sw = new StreamWriter("vehicle.txt"))
            {
                sw.WriteLine(this.Color);
                sw.WriteLine(this.Horsepower);
                sw.WriteLine(this.FuelCapacity);
            }
        }
    }
}