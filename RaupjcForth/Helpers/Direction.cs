using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Design;

namespace RaupjcForth.Helpers
{
    public enum Direction
    {
        [Direction(X = 1, Y = -1)]
        NorthEast,
        [Direction(X = 1, Y = 1)]
        SouthEast,
        [Direction(X = -1, Y = 1)]
        SouthWest,
        [Direction(X = -1, Y = -1)]
        NorthWest
    }
}
