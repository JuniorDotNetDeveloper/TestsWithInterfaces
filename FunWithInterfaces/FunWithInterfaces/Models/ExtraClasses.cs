using FunWithInterfaces.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithInterfaces.Models
{
    #region Extra classes for examples
    // Not deriving from Shape, but still injecting a name clash.
    public class SuperImage : IDraw, IDrawToPrinter, IDraw3D
    {
        void IDraw.Draw()
        {  /* Basic drawing logic. */ }
        void IDrawToPrinter.Draw()
        {  /* Printer logic. */}
        void IDraw3D.Draw()
        {  /* 3D support. */}
    }

    class Spear : IPointy
    {
        #region IPointy Members
        byte IPointy.Points
        {
            get { return 1; }
        }
        #endregion
    }

    class Fork : IPointy
    {
        #region IPointy Members
        byte IPointy.Points
        {
            get { return 4; }
        }
        #endregion
    }

    class PitchFork : IPointy
    {
        #region IPointy Members
        byte IPointy.Points
        {
            get { return 3; }
        }
        #endregion

    }
    #endregion
}

