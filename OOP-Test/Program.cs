using System;

namespace OOP_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string NameVehicle;
            double MaxSpeed;
            int MaxPassengers;
            int MaxLoadCapacity;
            string NameModel;
            int Weight;
            Console.WriteLine("Enter Name of Vehicle: ");
            NameVehicle = Console.ReadLine();
            Console.WriteLine("Enter Max Speed: ");
            MaxSpeed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Max Passengers: ");
            MaxPassengers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Max Load Capacity: ");
            MaxLoadCapacity = Convert.ToInt32(Console.ReadLine());
            Vehicle vehicle = new Vehicle(NameVehicle, MaxSpeed, MaxPassengers, MaxLoadCapacity);
            Console.WriteLine("Enter Name of Model: ");
            NameModel = Console.ReadLine();
            Console.WriteLine("Enter Weight: ");
            Weight = Convert.ToInt32(Console.ReadLine());
            Model model = new Model(NameModel, Weight, DateTime.Now, NameVehicle, MaxSpeed, MaxPassengers, MaxLoadCapacity);
            model.Messege += ConsoleMessege;
            model.Save();
            model.PrintAllInfo();
            void ConsoleMessege(string messege) => Console.WriteLine(messege);
        }
    }
}
