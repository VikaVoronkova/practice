using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1.Number num1 = new Task1.Number(5);
            Task1.Number num2 = new Task1.Number(-2);
            Task1.Number num3 = new Task1.Number(0);
            Console.WriteLine("---Число---");
            Console.WriteLine(num1.Real);
            Console.WriteLine(num2.Real);
            Console.WriteLine(num3.Real);

            Console.WriteLine("---Модуль---");
            Console.WriteLine(num1.Abs);
            Console.WriteLine(num2.Abs);
            Console.WriteLine(num3.Abs);

            Console.WriteLine("---Знак---");
            Console.WriteLine(num1.Sign);
            Console.WriteLine(num2.Sign);
            Console.WriteLine(num3.Sign);

            num1.Sum(num2);
            Console.WriteLine(num1.Real);

            num1.Div(num3);
            Console.WriteLine(num1.Real);
        }
    }
}
