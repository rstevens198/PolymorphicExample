using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ThreeDCircle : Circle
    {
        // hide the petName property above me
        public new string PetName { get; set; }

        // here is an example of Shadowing
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D circle");
        }
    }
}
