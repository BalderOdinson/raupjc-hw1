using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaupjcForth
{
    public class CollisionDetector
    {
        public static bool Overlaps(IPhysicalObject2D a, IPhysicalObject2D b)
        {
            return 
                (a.X <= b.X + b.Width && a.X >= b.X || a.X + a.Width >= b.X && a.X + a.Width <= b.X + b.Width || !(a.X > b.X ^ a.X + a.Width < b.X + b.Width)) &&
            (a.Y <= b.Y + b.Height && a.Y >= b.Y || a.Y + a.Height >= b.Y && a.Y + a.Height <= b.Y + b.Height || !(a.Y > b.Y ^ a.Y + a.Height < b.Y + b.Height));
        }
    }
}
