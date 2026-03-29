using CW5.Variant03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public class Task1
    {
        public struct Employee : IEmployee
        {
            //pole
            private string _name;
            private string _surname;
            private int _age;
            private double _salary;
            private int _id;
            private int _count = 0;
            //svoistvo
            public string Name => _name;
            public string Surname => _surname;
            public int Age => _age;
            public double Salary => _salary;
            public int ID => _id;
            //konstruktor
            public Employee(string name, string surname, int age, double salary)
            {
                _name = name;
                _surname = surname;
                _age = age;
                _salary = salary;
                _count++;
                _id = 100000 + _count;
            }
            //method
            public void CelebrateBirthday()
            {
                _age++;
            }
            public void Promote(double value)
            {
                _salary += value;
            }
            public double GetPerspective()
            {
                return Math.Sqrt(100 - Age) * Salary * 1.05;
            }
        }
    }
}
