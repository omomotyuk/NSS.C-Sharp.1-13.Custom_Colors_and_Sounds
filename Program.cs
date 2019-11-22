using System;
using System.Collections.Generic;
using System.Linq;

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
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} vehicle is going {direction} direction.");
        }
        public virtual void Stop()
        {
            Console.WriteLine("It takes some time for any vehicle to make a complete stop.");
        }
    }

    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank() { }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives: Drrrrr!");
        }
    }

    public class Zero : Vehicle
    {
        public double BatteryKwh { get; set; }

        public void ChargeBattery() { }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives: Zoooom!");
        }
    }

    public class Tesla : Vehicle
    {
        public double BatteryKwh { get; set; }

        public void ChargeBattery() { }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives: Zzzzzz!");
        }
    }

    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank() { }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna drives: Shhhhh!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The all directions are open for {MainColor} Cessna in the air. And {direction} direction too.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls to a stop after rolling a mile down the runway.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Move all common properties in your vehicles to a new Vehicle class

            // 2. Create an instance of each vehicle
            var ram = new Ram();
            var zero = new Zero();
            var tesla = new Tesla();
            var cessna = new Cessna();

            List<Vehicle> vehicles = new List<Vehicle> { ram, zero, tesla, cessna };

            // 3. Define a different value for each vehicle's properties

            // ram
            ram.MainColor = "Red";
            ram.MaximumOccupancy = 6;
            ram.FuelCapacity = 20.0;

            // zero
            zero.MainColor = "Green";
            zero.MaximumOccupancy = 2;
            zero.BatteryKwh = 25.0;

            // tesla
            tesla.MainColor = "Blue";
            tesla.MaximumOccupancy = 4;
            tesla.BatteryKwh = 54.0;

            // cessna
            cessna.MainColor = "White";
            cessna.MaximumOccupancy = 2;
            cessna.FuelCapacity = 30.0;

            // 4. Create a Drive() method in the Vehicle class
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Drive();
                Console.Write("\n");
            }

            // 5. Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e. "The blue Ram drives past. RRrrrrrummbbble!")

            // 6. Create a Turn(string direction) mathod, and a Stop() method on Vehicle. Define a basic implementation of each

            // 7. Override all three of those methods on some of the vehicles. For example, the Stop() method for a plane would be to output the message "The white Cessna rolls to a stop after rolling a mile down the runway."

            // 8. Make your vehicle instances perform all three behaviors.
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.Turn("left");
                vehicle.Stop();
                Console.Write("\n");
            }
        }
    }
}