using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }
        // since Draw() is abstract we now must put in a override method
        public override void Draw()
        {
            throw new NotImplementedException();)
            {
                Console.WriteLine("Drawing {0} the Cirlce", petName);
            }
        }
    }
}
