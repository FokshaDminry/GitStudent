using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test
{
    class Vehicle 
    {
        public string _NameVehicle { get; set; }
        public double _MaxSpeed { get; set; }
        public int _MaxPassengers { get; set; }
        public int _MaxLoadCapacity { get; set; }
        public FileInfo file;
        public delegate void SeveHandler(string massege);
        public event SeveHandler? Messege; 
        public Vehicle(string Name, double MaxSpeed, int MaxPassengers, int MaxLoadCapacity)
        {
            _NameVehicle = Name;
            _MaxSpeed = MaxSpeed;
            _MaxPassengers = MaxPassengers;
            _MaxLoadCapacity = MaxLoadCapacity;
            file = new FileInfo(@"D:\Проекты\OOP-Test\OOP-Test\Vehicle.txt");
        }


        public void PrintAllInfo()
        {
            if (file.Exists)
            {
                using (StreamReader stream = file.OpenText())
                {
                   Console.Write(stream.ReadToEnd());
                }
            }
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name Vehicle: {_NameVehicle}");
            Console.WriteLine($"Max Speed : {_MaxSpeed}");
            Console.WriteLine($"Max Passengers: {_MaxPassengers}");
            Console.WriteLine($"Max Load Capacity: {_MaxLoadCapacity}");
        }

        public virtual void Save()
        {
            if (file.Exists)
            {
                using (StreamWriter stream = file.AppendText())
                {
                    stream.WriteLine($"Name Vehicle: { _NameVehicle}");
                    stream.WriteLine($"Max Speed : {_MaxSpeed}");
                    stream.WriteLine($"Max Passengers: {_MaxPassengers}");
                    stream.WriteLine($"Max Load Capacity: {_MaxLoadCapacity}");
                    stream.WriteLine($"--------------------------------");
                }
                Messege?.Invoke($"Save ok!");
            }
        }

    }
}
