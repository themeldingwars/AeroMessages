using System;
using Aero.Gen.Attributes;

namespace AeroMessages.Common
{
    // Read up to 2 bytes, if the first bit is set in the first will read a second, use Length to get the
    [AeroBlock]
    public struct Vlq16
    {
        [Flags]
        public enum HasMore : byte
        {
            Yes = 0x80
        }

        public HasMore LengthByte1;

        [AeroIf(nameof(LengthByte1), AeroIfAttribute.Ops.HasFlag, HasMore.Yes)]
        public byte LengthByte2;
        
        // Be careful if doing this style, it can break the inspector, should be fine for array or string lengths, but not in ifs
        public int Length => (LengthByte2 != 0 ? (LengthByte2 | ((byte) LengthByte1 ^ 0x80) << 8) : (int) LengthByte1);
    }
}