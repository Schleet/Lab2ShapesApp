using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Sphere : Shape3D
    {
        public Sphere(Vector3 position) : this(position, 0) { }

        private float radius;
        public Sphere(Vector3 center, float radius)
        {
            Center = center;
            this.radius = radius;
        }

        public override Vector3 Center { get; }
        //public override float Circumference => 2 * MathF.PI * (radius);
        public override float Area => MathF.PI * (radius * radius);

        public override float Volume => (float)(4.0f / 3f * Math.PI * radius * radius * radius);

        public override string ToString()
        {
            return $"Sphere @({Center.X:0.0}, {Center.Y:0.0}): r = {radius:0.0}";
        }

    }
}