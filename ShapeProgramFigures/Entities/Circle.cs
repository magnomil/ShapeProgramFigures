using System;
using System.Collections.Generic;
using ShapeProgramFigures.Entities.Enuns;

namespace ShapeProgramFigures.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        
        public Circle (double radius, Color color): base(color)
        {
            Radius = radius;
        }


        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
