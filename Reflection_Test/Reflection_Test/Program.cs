using System;
using System.Reflection;


namespace Reflection_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //получение типа объекта Square
            Assembly asm = Assembly.LoadFrom("Reflection_Test.dll");
            Type type = asm.GetType("Reflection_Test.Square");
            if (type is not null)
            {
                //получение прототипа объкта
                var obj = Activator.CreateInstance(type);
                // получаем и устанавливаем свойства объекта
                PropertyInfo property = type.GetProperty("_A");
                PropertyInfo property1 = type.GetProperty("_B");
                property?.SetValue(obj, 7);
                property1?.SetValue(obj, 5);
                // вызов метода без параметров
                MethodInfo method = type.GetMethod("S", BindingFlags.Instance | BindingFlags.Public);
                object result = method.Invoke(obj, new object[] { });
                Console.WriteLine(result);
                // вызов метода с параметрами
                MethodInfo method1 = type.GetMethod("P", BindingFlags.Instance | BindingFlags.Public);
                object result2 = method1.Invoke(obj, new object[] { 5, 7 });
                Console.WriteLine(result2);
            }
        }
    }
    public class Square
    {
        public int _A { get; set; }
        public int _B { get; set; }
        public int _C { get; set; } = 8;

        public int S() => _A * _B;
        public int P(int A, int B)
        {
            _A = A;
            _B = B;
            return _A + _A + _B + _B;
        }
    }
}
