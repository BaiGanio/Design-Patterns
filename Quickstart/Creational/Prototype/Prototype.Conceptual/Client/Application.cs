using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Conceptual
{
    class Application
    {
        private readonly List<Shape> _shapes;

        public Application()
        {
            var rectangle = new Rectangle { Width = 10, Height = 20 };
            _shapes.Add(rectangle);
        }
    }
}
