using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaApp
{
    //class Triangle : Shape
    class Triangle : IShape
    {
        double _tBase;
        double _tHeight;
        public Triangle()
        {

        }
        public Triangle(double tBase, double tHeight)
        {
            _tBase = tBase;
            _tHeight = tHeight;
        }

        public double TBase { get => _tBase; set => _tBase = value; }
        public double THeight { get => _tHeight; set => _tHeight = value; }

        //public override void CalculateArea()
        //{
        //    this.Area = 0.5 * _tBase * _tHeight;
        //}
        public double CalculateArea()
        {
            return 0.5 * _tBase * _tHeight;
        }
    }
}
