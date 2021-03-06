﻿using FunWithInterfaces.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces.Models
{
    public class Circle : Shape, IDraw3D
    {
        public Circle() { }
        public Circle(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the circle", PetName);
        }

        #region IDraw3D Members
        void IDraw3D.Draw()
        {
            { Console.WriteLine("Drawing Circle in 3D!"); }
        }
        #endregion
    }
}
