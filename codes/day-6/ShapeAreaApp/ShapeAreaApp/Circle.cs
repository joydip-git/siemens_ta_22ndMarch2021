using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaApp
{
    //class Circle : Shape
    class Circle:IShape
    {
        double _radius;

        public Circle()
        {

        }
        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Radius { get => _radius; set => _radius = value; }

        //public override void CalculateArea()
        //{
        //    this.Area = Math.PI * _radius * _radius;
        //}

        public double CalculateArea()
        {
            return Math.PI * _radius * _radius; 
        }
    }
}
