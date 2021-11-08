using System;
using System.Collections.Generic;
using System.Text;

namespace Teckning
{
    public class Teckning
    {
        public virtual double Area()
        {
            return 0;
        }

    }
    public class Cirkel : Teckning
    {
        public double _radius { get; set; }
        private double _pi = 3.14;
        public Cirkel()
        {
            this._radius = 4;
        }
        public override double Area()
        {

            return _radius * _radius * _pi;
        }

    }
    public class Triangle : Teckning
    {
        double _height { get; set; }
        double _base { get; set; }

        public Triangle()
        {
            this._height = 10;
            this._base = 15;
        }
        public override double Area()
        {
            return (_height * _base) / 2;
        }
    }
    public class Rectangle : Teckning
    {
        double _height { get; set; }
        double _base { get; set; }

        public Rectangle()
        {
            this._height = 4;
            this._base = 10;
        }
        public override double Area()
        {

            return _height * _base;

        }
    }
}
