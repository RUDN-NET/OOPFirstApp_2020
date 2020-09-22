using System;

namespace OOPFirstApp
{
    class Complex
    {
        private double _Re;
        private double _Im;

        public double Re
        {
            get
            {
                return _Re;
            }
            set
            {
                _Re = value;
            }
        }

        public double ReadOnlyRe => _Re;

        public double Im
        {
            get => _Im;
            set => _Im = value;
        }

        public double Abs // Свойство только для чтения - блок set отсутствует
        {
            get
            {
                return Math.Sqrt(_Re * _Re + _Im * _Im);
            }
        }

        //public double Arg
        //{
        //    get => Math.Atan2(_Im, _Re);
        //}

        public double Arg => Math.Atan2(_Im, _Re); // Сокращённая запись свойства только для чтения

        public void Print()
        {
            Console.WriteLine("{0}+i{1}", _Re, _Im);
        }

        public Complex Add(Complex y)
        {
            var z = new Complex();
            z._Re = _Re + y._Re;
            z._Im = _Im + y._Im;

            return z;
        }

        public double GetAbs()
        {
            return Math.Sqrt(_Re * _Re + _Im * _Im);
        }

        public double GetArg()
        {
            return Math.Atan2(_Im, _Re);
        }

        public static Complex operator +(Complex x, Complex y)
        {
            var z = new Complex();
            z._Re = x._Re + y._Re;
            z._Im = x._Im + y._Im;

            return z;
        }

        public static Complex operator -(Complex x, Complex y)
        {
            var z = new Complex();
            z._Re = x._Re - y._Re;
            z._Im = x._Im - y._Im;

            return z;
        }
    }
}