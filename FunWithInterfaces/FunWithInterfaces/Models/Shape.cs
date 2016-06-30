using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces.Models
{
    public abstract class Shape
    {
        // Shapes can be assigned a friendly pet name.
        protected string petName;

        // Constructors.
        public Shape() { petName = "NoName"; }
        public Shape(string s) { petName = s; }

        // Draw() is now completely abstract (note semicolon).
        public abstract void Draw();

        public string PetName
        {
            get { return petName; }
            set { petName = value; }
        }
    }
}
