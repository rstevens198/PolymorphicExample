using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    // the abstract class hierarachy
    abstract class Shape
    {
        public Shape(String name = "NoName")
        { petName = name; }

        public string petName { get; set; }

        // A single virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Inside Shape.Draw()");
        }
    }
}
