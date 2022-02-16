using System;
using System.Collections;

namespace Interfece_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles vehicle = new Vehicles();
            foreach (var item in vehicle)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    class Vehicles : IEnumerable
    {
        Vehicle[] _vehicle = new Vehicle[4]
        {
            new Vehicle ("Car", 4, 250, 400 ),
            new Vehicle ("Bike", 2, 350, 50 ),
            new Vehicle ("Bicyсle", 2, 50, 20 ),
            new Vehicle ("Bus", 30, 150, 500 ),
        };
        IEnumerator IEnumerable.GetEnumerator() => (IEnumerator)GetEnumerator;
        IEnumerator GetEnumerator => new IVehicleEnumirable(_vehicle);
    }

    class IVehicleEnumirable : IEnumerator
    {
        Vehicle[] _vehicles;
        int position = -1;
        public IVehicleEnumirable(Vehicle[] vehicles)
        {
            _vehicles = vehicles;
        }
        public object Current
        {
            get { if (position == -1 || position >= _vehicles.Length)
                    throw new ArgumentException();
                return _vehicles[position];
            }
        }

        public bool MoveNext()
        {
            if (position < _vehicles.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset() => position = -1;
    }

    class Vehicle 
    {
        string _NameVehicle { get; set; }
        double _MaxSpeed { get; set; }
        int _MaxPassengers { get; set; }
        int _MaxLoadCapacity { get; set; }
        public Vehicle(string NameVehicle, double Speed, int passengers, int MaxLoad)
        {
            _NameVehicle = NameVehicle;
            _MaxSpeed = Speed;
            _MaxPassengers = passengers;
            _MaxLoadCapacity = MaxLoad;
        }
        public override string ToString()
        {
            return $"Name: {_NameVehicle}, Max Speed: {_MaxSpeed}, Max Passenger: {_MaxPassengers}, Max Load Capacity: {_MaxLoadCapacity}";
        }
    }

}
