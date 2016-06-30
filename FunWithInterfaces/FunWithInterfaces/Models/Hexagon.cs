using FunWithInterfaces.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces.Models
{
    public class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            // Recall the Shape class defined the PetName property.
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }

        #region IPointy Members
        public byte Points
        {
            get { return 6; }
        }
        #endregion

        #region IDraw3D Members
        // Using explicit method implementation we are able
        // to provide distinct Draw() implementations.
        void IDraw3D.Draw()
        {
             Console.WriteLine("Drawing Hexagon in 3D!"); 
        }

        #endregion
    }
}
