using ShapeProgramFigures.Entities.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProgramFigures.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }
        public Color Color { get; }

        public Shape (Color color)
        {
            Color = color;
        }




        public abstract double Area();
    }
    
}

    
