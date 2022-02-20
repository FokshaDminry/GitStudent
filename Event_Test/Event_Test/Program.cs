using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Event_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.PropertyChanged += (_, _) => Console.WriteLine($"Chenge Save");
            Console.WriteLine("Enter Name: ");
            person.FIO = Console.ReadLine();
            Console.WriteLine("Enter Date Of Bith: ");
            person.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Palace Of Bith: ");
            person.PlaceOfBirth = Console.ReadLine();
            Console.WriteLine("Enter Passport Number: ");
            person.PassportNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Person : INotifyPropertyChanged
    {
        private String _FIO;
        private DateTime _DateOfBirth;
        private String _PlaceOfBirth;
        private Int32 _PassportNumber;
        public event PropertyChangedEventHandler PropertyChanged;

        public String FIO
        {
            get { return _FIO; }
            set { _FIO = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FIO)));
            }
        }
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set
            {
                _DateOfBirth = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DateOfBirth)));
            }
        }
        public String PlaceOfBirth
        {
            get { return _PlaceOfBirth; }
            set
            {
                _PlaceOfBirth = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PlaceOfBirth)));

            }
        }
        public Int32 PassportNumber
        {
            get { return _PassportNumber; }
            set
            {
                _PassportNumber = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PassportNumber)));

            }
        }
    }
}
