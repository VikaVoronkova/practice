using CW5.Variant00;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Task1
    {
        public struct Number : INumber
        {
            // поле
            private double _elem;

            //конструктор
            public Number(double elem)
            {
                _elem = elem;
            }
            // свойства
            public double Real
            {
                get
                {
                    return _elem;
                }

            }
            public double Abs
            {
                get
                {
                    return Math.Abs(_elem);
                }
            }
            public int Sign
            {
                get
                {
                    return Math.Sign(_elem);
                }
            }
            //методы 
            public void Sum(INumber other)
            {
                _elem += other.Real;
            }
            public void Sub(INumber other)
            {
                _elem -= other.Real;
            }
            public void Mul(INumber other)
            {
                _elem *= other.Real;
            }
            public void Div(INumber other)
            {
                if (other.Real == 0) return;
                _elem /= other.Real;
            }
            public void Neg()
            {
                _elem = -_elem;
            }
        }
    }
}