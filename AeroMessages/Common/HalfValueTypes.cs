using System.Numerics;
using Aero.Gen.Attributes;
using Bitter;

namespace AeroMessages.Common
{
    [AeroBlock]
    public struct HalfFloat
    {
        public ushort Value;
        
        public static implicit operator float(HalfFloat d)
        {
            HalfLookup.FloatUIntMapLookup.UInt =
                HalfLookup.Mantissa[HalfLookup.Offset[d.Value >> 10] + (d.Value & 0x3ff)] +
                HalfLookup.Exponent[d.Value >> 10];
            return HalfLookup.FloatUIntMapLookup.Float;
        }

        public static implicit operator HalfFloat(float d)
        {
            HalfLookup.FloatUIntMapLookup.Float = d;
            uint u = HalfLookup.FloatUIntMapLookup.UInt;
            return new HalfFloat
            {
                Value = (ushort)(HalfLookup.Base[(u >> 23) & 0x1ff] + ((u & 0x007fffff) >> HalfLookup.Shift[u >> 23]))
            };
        }
    }
    
    [AeroBlock]
    public struct HalfVector2
    {
        public HalfFloat X;
        public HalfFloat Y;
        
        public static implicit operator Vector2(HalfVector2 d)
        {
            return new()
            {
                X = d.X,
                Y = d.Y
            };
        }

        public static implicit operator HalfVector2(Vector2 d)
        {
            return new()
            {
                X = d.X,
                Y = d.Y
            };
        }
    }
    
    [AeroBlock]
    public struct HalfVector3
    {
        public HalfFloat X;
        public HalfFloat Y;
        public HalfFloat Z;
        
        public static implicit operator Vector3(HalfVector3 d)
        {
            return new()
            {
                X = d.X,
                Y = d.Y,
                Z = d.Z
            };
        }

        public static implicit operator HalfVector3(Vector3 d)
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
    public struct HalfVector4
    {
        public HalfFloat X;
        public HalfFloat Y;
        public HalfFloat Z;
        public HalfFloat W;
        
        public static implicit operator Vector4(HalfVector4 d)
        {
            return new()
            {
                X = d.X,
                Y = d.Y,
                Z = d.Z,
                W = d.W
            };
        }

        public static implicit operator HalfVector4(Vector4 d)
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
    public struct HalfQuaternion
    {
        public HalfFloat X;
        public HalfFloat Y;
        public HalfFloat Z;
        public HalfFloat W;
        
        public static implicit operator Quaternion(HalfQuaternion d)
        {
            return new()
            {
                X = d.X,
                Y = d.Y,
                Z = d.Z,
                W = d.W
            };
        }

        public static implicit operator HalfQuaternion(Quaternion d)
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