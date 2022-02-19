using System;
using System.Collections.Generic;

namespace List_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<string> palece = new List<string>() { "Moskva", "Piter", "Kiev", "New-Yourk", "Tiraspol", "Odessa", "Paris", "London" };
            List<string> name = new List<string>() { "Ernest Hemingway", "Erich Remarque", "Friedrich Nietzsthe", "Franz Kafka", "Immanuel Kant", "Anthny Burgess", "Gabriel Garcia Marquez", "Hermann Hesse" };
            List<string> work = new List<string>() { "Driver", "Programmer", "Lawyer", "Economist", "Builder", "Pilot", "Manager", "Writer"};
            Dictionary<Person, string> people = new Dictionary<Person, string>();
            Person person = new Person();
            for (int i = 0; i < 8; i++)
            {
                people.Add(new Person
                {
                    _FIO = name[i],
                    _DateOfBirth = DateTime.Parse($"1971-01-01").AddYears(i),
                    _PlaceOfBirth = palece[i],
                    _PassportNumber = 12345 + i
                }, work[i]);
            }

            Console.WriteLine("Enter Name: ");
            person._FIO = Console.ReadLine();
            Console.WriteLine("Enter Date Of Bith: ");
            person._DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Palace Of Bith: ");
            person._PlaceOfBirth = Console.ReadLine();
            Console.WriteLine("Enter Passport Number: ");
            person._PassportNumber = Convert.ToInt32(Console.ReadLine());

            foreach (var item in people)
            {
                if (item.Key.GetHashCode() == person.GetHashCode())
                {
                    Console.WriteLine(item.Value);
                }
            }
                

        }
    }
    class Person
    {
        public String _FIO { get; set; }
        public DateTime _DateOfBirth { get; set; }
        public String _PlaceOfBirth { get; set; }
        public int _PassportNumber { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj is Person)
            {
                var person = (Person)obj;
                return _FIO == person._FIO && _DateOfBirth == person._DateOfBirth && _PassportNumber == person._PassportNumber && _PlaceOfBirth == person._PlaceOfBirth;
            }
            else
            {
                return false;
            }

        }
        public override int GetHashCode()
        {
            return this._FIO.GetHashCode() + this._DateOfBirth.GetHashCode() + this._PlaceOfBirth.GetHashCode() + this._PassportNumber.GetHashCode();
        }
    }
}
