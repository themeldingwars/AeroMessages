using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using AeroMessages.Common;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 61)]
    public partial class DevRequestObjectPositions
    {
        public byte Show; // Seems to ignore stuff if 0 and will not print log unless 1.
        public byte Unk2;
        [AeroArray(typeof(byte))] public Vector3[] Positions;
        [AeroArray(typeof(byte))] public float[] Unk4;
        [AeroArray(typeof(byte))] public float[] Unk5;
        [AeroArray(typeof(byte))] public uint[] Unk6; // Presumably this would have been resource types?
    }
}