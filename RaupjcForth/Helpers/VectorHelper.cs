using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace RaupjcForth.Helpers
{
    public static class VectorHelper
    {
        public static Direction GetDirection(this Vector2 vector)
        {
            foreach (var enumValue in typeof(Direction).GetEnumValues())
            {
                if (((Direction)enumValue).GetVector() == vector)
                    return (Direction)enumValue;
            }
            return default(Direction);
        }

        public static Vector2 GetVector(this Direction direction)
        {
            var fi = direction.GetType().GetField(direction.ToString());
            return fi.GetCustomAttributes(typeof(DirectionAttribute), false) is DirectionAttribute[] attributes && attributes.Length > 0 ? new Vector2(attributes[0].X, attributes[0].Y) : new Vector2();
        }
    }
}
