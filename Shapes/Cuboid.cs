using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cuboid : Shape3D
    {
        public Vector3 center;
        public Vector3 size;

        public Cuboid(Vector3 center, Vector3 size)
        {
            this.center = center;
            this.size = size;

            if (size.X == size.Y && size.Y == size.Z)
            {
                IsCube = true;
            }
            else
            {
                IsCube = false;
            }
        }

        public Cuboid(Vector3 center, float width)
        {
            this.center = center;
            this.size = new Vector3(width);

            IsCube = true;       
        }
        public override float Volume => (size.X * size.Y * size.Z);
        public override Vector3 Center => (size / 2);
        public override float Area => 2 * (size.X + size.Y + size.Z);
        public bool IsCube { get; }
        public override string ToString()
        {
            if (IsCube)
            {
                return $"Cuboid @({center.X:0.0}, {center.Y:0.0}, {center.Z:0.0}): is a cube";
            }
            else
            {
                return $"Cuboid @({center.X:0.0}, {center.Y:0.0}, {center.Z:0.0}): w = {this.size.X:0.0} h = {this.size.Y:0.0} d = {this.size.Z:0.0}";
            }
        }

    }
}
