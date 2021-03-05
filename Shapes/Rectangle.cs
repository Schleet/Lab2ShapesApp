using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape2D
    {
        private bool isSquare = false;
        private Vector2 size;
        private Vector2 center;
        public override Vector3 Center => new Vector3(center.X, center.Y, 0);
        public override float Area => (size.X * size.Y);
        public override float Circumference => (size.X + size.Y * 2);
        public Rectangle(Vector2 center, Vector2 size)
        {
            this.center = center;
            this.size = size;

            if (size.X == size.Y)
            {
                isSquare = true;
            }
            else
            {
                isSquare = false;
            }           
        }
        public Rectangle(Vector2 center, float width)
        {
            this.center = center;
            this.size.X = width;
            this.size.Y = width;
            isSquare = true;
        }
        public override string ToString()
        {
            if (isSquare)
            {
                return $"Rectangle @({center.X:0.0}, {center.Y:0.0}): is a square";
            }
            else
            {
                return $"Rectangle @({center.X:0.0}, {center.Y:0.0}): w = {this.size.X:0.0} h = {this.size.Y:0.0}";
            }
        }
    }
}
