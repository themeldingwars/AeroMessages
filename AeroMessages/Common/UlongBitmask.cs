using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aero.Gen.Attributes;

namespace AeroMessages.Common
{
    // I hate this :<
    [AeroBlock]
    public struct Ulong5ByteBitmask<T> where T : Enum
    { 
        [AeroArray(5)]
        public byte[] Bytes;
    
        public static implicit operator T(Ulong5ByteBitmask<T> d)
        {
            ulong test = 0;
            test |= (ulong)d.Bytes[0] << 32;
            test |= (ulong)d.Bytes[1] << 24;
            test |= (ulong)d.Bytes[2] << 16;
            test |= (ulong)d.Bytes[3] << 8;
            test |= d.Bytes[4];
                
            return Unsafe.As<ulong, T>(ref test);
        }

        // TODO: Improve this
        public static implicit operator Ulong5ByteBitmask<T>(T b)
        {
            var data = new Ulong5ByteBitmask<T>();
            data.Bytes = new byte[5];
            var value = Unsafe.As<T, ulong>(ref b);

            var bytesResult = MemoryMarshal.Cast<ulong, byte>(new ulong[] { value });
            data.Bytes[0] = bytesResult[0];
            data.Bytes[1] = bytesResult[1];
            data.Bytes[2] = bytesResult[2];
            data.Bytes[3] = bytesResult[3];
            data.Bytes[4] = bytesResult[4];

            return data;
        }
    }
}