using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class SpeedComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Car c1 = (Car)x;
            Car c2 = (Car)y;
            return c1.Speed - c2.Speed;
        }
    }
}
