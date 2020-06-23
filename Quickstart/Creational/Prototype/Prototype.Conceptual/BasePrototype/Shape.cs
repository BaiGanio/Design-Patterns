using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Conceptual
{
    abstract class Shape
    {
        private readonly int _x;
        private readonly int _y;
        private readonly string _color;

        public Shape() { }

        // A fresh object is initialized with values from the existing object.
        public Shape(Shape source) : this()
        {
            _x = source._x;
            _y = source._y;
            _color = source._color;
        }

        internal abstract Shape Clone();
    }
}
