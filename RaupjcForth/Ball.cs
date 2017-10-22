using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using RaupjcForth.Helpers;

namespace RaupjcForth
{
    public class Ball : Sprite
    {
        /// <summary >
        /// Defines current ball speed in time .
        /// </ summary >
        private float _speed;

        public float Speed
        {
            get => _speed;
            set => _speed = value > 1 ? 1 : value;
        }
        public float BumpSpeedIncreaseFactor { get; set; }

        /// <summary >
        /// Defines ball direction .
        /// Valid values ( -1 , -1) , (1 ,1) , (1 , -1) , ( -1 ,1).
        /// Using Vector2 to simplify game calculation . Potentially
        /// dangerous because vector 2 can swallow other values as well .
        /// OPTIONAL TODO : create your own , more suitable type
        /// </ summary >
        private Vector2 _direction;

        public Direction Direction
        {
            get => _direction.GetDirection();
            set => _direction = value.GetVector();
        }
        public Ball(int size, float speed, float
            defaultBallBumpSpeedIncreaseFactor) : base(size, size)
        {
            Speed = speed;
            BumpSpeedIncreaseFactor = defaultBallBumpSpeedIncreaseFactor;
            // Initial direction
            Direction = Direction.SouthWest;
        }
    }
}
