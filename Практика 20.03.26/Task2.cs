using CW5.Variant00;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Task2
    {
        public class Number : INumber
        {
            // поле
            protected double _elem;

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
            public virtual double Abs
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
            public virtual void Sum(INumber other)
            {
                if (other == null) return;
                _elem += other.Real;
            }
            public virtual void Sub(INumber other)
            {
                if (other == null) return;
                _elem -= other.Real;
            }
            public virtual void Mul(INumber other)
            {
                if (other == null) return;
                _elem *= other.Real;
            }
            public virtual void Div(INumber other)
            {
                if (other == null) return;
                if (other.Real == 0) return;
                _elem /= other.Real;
            }
            public virtual void Neg()
            {
                _elem = -_elem;
            }
        }
        public class ComplexNumber : Number, IComplexNumber //сначала родитель
        {
            double _imag;

            public double Imaginary => _imag;
            public int ISign
            {
                get
                {
                    return Math.Sign(_imag);
                }
            }
            public override double Abs => Math.Sqrt(_elem * _elem + _imag * _imag);

            public ComplexNumber(double elem, double imag = 0) : base(elem)
            {
                _imag = imag;
            }
            public ComplexNumber(INumber other) : base(other.Real)
            {
                if (other is ComplexNumber cnum)
                {
                    _imag = cnum.Imaginary;
                }
                else
                {
                    _imag = 0;
                }
            }
        }
    }
}
