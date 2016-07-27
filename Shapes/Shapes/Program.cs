using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****");

            // new code
            // Maek an array of shape compatible objects
            Shape[] myShaped = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth") };

            // Loop over each item and interact with the polymorphic interface
            foreach(Shape s in myShaped)
            {
                s.Draw();
            }

            Console.ReadLine();

            // this is code from the last push
            //Hexagon hex = new Hexagon("Beth");
            //hex.Draw();
            //Circle cir = new Circle("Cindy");
            ////Calls base class implementation
            //cir.Draw();
            //Console.ReadLine();
        }
    }
}
