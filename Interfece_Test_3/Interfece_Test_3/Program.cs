using System;
using System.Collections.Generic;
using System.Linq;

namespace Interfece_Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Square> squares = new List<Square>();
            for (int i = 0; i < 50; i++)
            {
                squares.Add(new Square(random.Next(1, 15), random.Next(1, 15)));
            }
            foreach (var item in squares.OrderBy( s => s))
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    class Square : IComparable
    {
        int _A { get; set; }
        int _B { get; set; }

        public Square(int A, int B)
        {
            _A = A;
            _B = B;
        }
        public int CompareTo(object? o)
        {
            if (o is Square square)
            {
                return _A * _B - square._A * square._B;
            }
            else
            {
                throw new ArgumentException("Некорректное значение параметра");
            }
        }
        public override string ToString()
        {
            return $"{_A * _B}";

        }
    }
}
