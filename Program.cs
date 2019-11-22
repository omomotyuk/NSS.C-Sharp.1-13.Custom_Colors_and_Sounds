using System;

namespace _1_13.Custom_Colors_and_Sounds
{
    public class Vehicle : Object
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine("Vroom!");
        }
    }

    public class Ram : Vehicle
    {
        public double Fuel { get; set; }
        public void ChargeBattery() { }
    }

    public class Zero : Vehicle
    {
        public double BatteryKwh { get; set; }
        public void ChargeBattery() { }
        public override void Drive()
        {
            Console.WriteLine("Zoooom!");
        }
    }

    public class Tesla : Vehicle
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank() { }
        public override void Drive()
        {
            Console.WriteLine("zzzzzZZZZZzzzzz!");
        }
    }

    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Move all common properties in your vehicles to a new Vehicle class.
            // 2. Create an instance of each vehicle.
            // 3. Define a different value for each vehicle's properties.
            // 4. Create a Drive() method in the Vehicle class.
            // 5. Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e. "The blue Ram drives past. RRrrrrrummbbble!").
            // 6. Create a Turn(string direction) mathod, and a Stop() method on Vehicle. Define a basic implementation of each.
            // 7. Override all three of those methods on some of the vehicles. For example, the Stop() method for a plane would be to output the message "The white Cessna rolls to a stop after rolling a mile down the runway."
            // 8. Make your vehicle instances perform all three behaviors.

            var ram = new Ram();
            var zero = new Zero();
            var tesla = new Tesla();
            var cessna = new Cessna();

            zero.MainColor = "White";
            tesla.MaximumOccupancy = 5;

            ram.Drive();
            zero.Drive();
            tesla.Drive();
            cessna.Drive();
        }
    }
}