using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Circle : Formas
    {
        private const double PI = 3.1416;
        private double Radius { get; set; }

        public Circle(double Radius, string Color) : base(Color)
        {
            this.Radius = Radius;
            this.Color = Color;
        }

        public double GetRadius() => Radius;
        public override double Area() => PI * GetRadius() * GetRadius();
    }
}
