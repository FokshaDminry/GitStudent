using System;

namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Tomas Mann", "19.03.1998", "USA", "PU337877");
            Person person0 = new Person("Tomas Mann", "19.03.1998", "USA", "PU337877");
            Person person1 = new Person("Lars Fon Trier", "19.03.1986", "USA", "PU253894");
            
            if (person.Equals(person0))
            {
                Console.WriteLine("Ok!");
            }
            if (person != person1)
            {
                Console.WriteLine("Ok!");
            }
            if (person.GetHashCode() == person0.GetHashCode())
            {
                Console.WriteLine("Ok!");
            }
        }
    }
    class Person
    {
        public String _FIO { get; set; }
        public String _DateOfBirth { get; set; }
        public String _PlaceOfBirth { get; set;}
        public String _PassportNumber { get; set; }

        public Person(String FIO, String DateOfBirth, String PalaceOfBirth, String PassportNumber)
        {
            _FIO = FIO;
            _DateOfBirth = DateOfBirth;
            _PlaceOfBirth = PalaceOfBirth;
            _PassportNumber = PassportNumber;
        }
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
