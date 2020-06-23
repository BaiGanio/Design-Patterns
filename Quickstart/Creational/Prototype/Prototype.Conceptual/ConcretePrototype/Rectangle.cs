using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Conceptual
{
    class Rectangle : Shape
    {
        private readonly double _width;
        private readonly double _height;

        public Rectangle()
        {
        }

        public Rectangle(Rectangle source) 
            : base(source)
        {
            _width = source._width;
            _height = source._height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        internal override Shape Clone()
        {
            return new Rectangle(this);
        }
    }
}
