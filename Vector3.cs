using System;

namespace OSP {
    public class Vector3 {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3() {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Vector3(double x, double y, double z) {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector3 operator +(Vector3 a, Vector3 b) {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vector3 operator *(Vector3 v, double s) {
            return new Vector3(v.X * s, v.Y * s, v.Z * s);
        }

        public static Vector3 operator /(Vector3 v, double s) {
            return new Vector3(v.X / s, v.Y / s, v.Z / s);
        }

        public double Length {
            get {
                return Math.Sqrt(X * X + Y * Y + Z * Z);
            }
        }

        public Vector3 Normalized() {
            return this / Length;
        }

        public void Normalize() {
            this /= Length;
        }
    }
}
