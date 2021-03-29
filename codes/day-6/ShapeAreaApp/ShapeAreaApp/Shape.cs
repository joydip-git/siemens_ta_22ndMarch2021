using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaApp
{
    abstract class Shape
    {
        double area;
        public Shape()
        {

        }

        public double Area { get => area; protected set => area = value; }

        public abstract void CalculateArea();
    }
}
