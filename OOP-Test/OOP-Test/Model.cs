using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Test
{
    class Model : Vehicle
    {
        public string _ModelName { get; set; }
        public int _Weight { get; set; }
        public DateTime _DateOfMan { get; set; }

        public Model(string Name, int Weight, DateTime DateOfMan, string NameV, double MaxSpeed, int MaxPassengers, int MaxLoadCapacity)
            : base(NameV, MaxSpeed, MaxPassengers, MaxLoadCapacity)
        {
            _ModelName = Name;
            _Weight = Weight;
            _DateOfMan = DateOfMan; 
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Model Name: {_ModelName}");
            Console.WriteLine($"Weight: {_Weight}");
            Console.WriteLine($"Date Of Manufacture: {_ModelName}");
            
        }

        public override void Save()
        {
            using(StreamWriter stream = file.AppendText())
            {
                stream.WriteLine($"Model: ");
                stream.WriteLine($"Model Name: {_ModelName}");
                stream.WriteLine($"Weight: {_Weight}");
                stream.WriteLine($"Date Of Manufacture: {_DateOfMan}");
                stream.WriteLine($"---------------------------");
            }
            base.Save();

        }
    }
}
