using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Triangle : Formas
    {
        private double Base { get; set; }
        private double Height { get; set; }

        public Triangle(double Base, double Height, string Color) : base(Color)
        {
            this.Base = Base;
            this.Height = Height;
            this.Color = Color;
        }

        public double GetBase() => Base;
        public double GetHeight() => Height;
        public override double Area() => GetBase() * GetHeight() / 2;
    }
}
