using System.Numerics;
using Aero.Gen.Attributes;

namespace AeroMessages.Common
{
    [AeroBlock]
    public struct QuantisedFloat
    {
        public ushort Value;
        
        public static implicit operator float(QuantisedFloat d)
        {
            var result = (1.0f / 32767f) * d.Value;
            if (result >= 0) {
                result = (result -1f) * -1f; 
            }

            return result;
        }

        public static implicit operator QuantisedFloat(float d)
        {
            ushort result = (ushort)(32767 * d);
            return new QuantisedFloat { Value = result};
        }
    }
    
    [AeroBlock]
    public struct QuantisedVector2
    {
        public QuantisedFloat X;
        public QuantisedFloat Y;
        
        public static implicit operator Vector2(QuantisedVector2 d)
        {
            return new()
            {
                X = d.X,
                Y = d.Y
            };
        }

        public static implicit operator QuantisedVector2(Vector2 d)
        {
            return new()
            {
                X = d.X,
                Y = d.Y
            };
        }
    }
    
    [AeroBlock]
    public struct QuantisedVector3
    {
        public QuantisedFloat X;
        public QuantisedFloat Y;
        public QuantisedFloat Z;
        
        public static implicit operator Vector3(QuantisedVector3 d)
        {
            return new()
            {
                X = d.X,
                Y = d.Y,
                Z = d.Z
            };
        }

        public static implicit operator QuantisedVector3(Vector3 d)
        {
            return new()
            {
                X = d.X,
                Y = d.Y,
                Z = d.Z
            };
        }
    }
    
    [AeroBlock]
    public struct QuantisedVector4
    {
        public QuantisedFloat X;
        public QuantisedFloat Y;
        public QuantisedFloat Z;
        public QuantisedFloat W;
        
        public static implicit operator Vector4(QuantisedVector4 d)
        {
            return new()
            {
                X = d.X,
                Y = d.Y,
                Z = d.Z,
                W = d.W
            };
        }

        public static implicit operator QuantisedVector4(Vector4 d)
        {
            return new()
            {
                X = d.X,
                Y = d.Y,
                Z = d.Z,
                W = d.W
            };
        }
    }
    
    [AeroBlock]
    public struct QuantisedQuaternion
    {
        public QuantisedFloat X;
        public QuantisedFloat Y;
        public QuantisedFloat Z;
        public QuantisedFloat W;
        
        public static implicit operator Quaternion(QuantisedQuaternion d)
        {
            return new()
            {
                X = d.X,
                Y = d.Y,
                Z = d.Z,
                W = d.W
            };
        }

        public static implicit operator QuantisedQuaternion(Quaternion d)
        {
            return new()
            {
                X = d.X,
                Y = d.Y,
                Z = d.Z,
                W = d.W
            };
        }
    }
}