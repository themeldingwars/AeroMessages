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
        public byte Unk1;
        public byte Unk2;
        [AeroArray(typeof(byte))] public DevReqObjectData[] Unk3;
        [AeroArray(typeof(byte))] public float[] Unk4;
        [AeroArray(typeof(byte))] public float[] Unk5;
        [AeroArray(typeof(byte))] public uint[] Unk6;
    }

    [AeroBlock]
    public struct DevReqObjectData
    {
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
    }
}