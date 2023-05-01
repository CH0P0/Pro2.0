using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Rectangle : Formas
    {
        private double Width { get; set; }
        private double Length { get; set; }

        public Rectangle(double Width, double Length, string Color) : base(Color)
        {
            this.Width = Width;
            this.Length = Length;
            this.Color = Color;
        }

        public double GetWidth() => Width;
        public double GetLength() => Length;
        public override double Area() => GetLength() * GetWidth();
    }
}
