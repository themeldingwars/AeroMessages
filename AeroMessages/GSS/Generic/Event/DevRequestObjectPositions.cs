using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.DevRequestObjectPositions, GssVersion.V1, GssVersion.V74)]
    public partial class DevRequestObjectPositions
    {
        public byte IsFinal; // 0: more chunks follow, 1: final chunk and log the count
        public byte Unk2;
        [AeroArray(typeof(byte), Chunked = true)] public Vector3[] Positions;
        [AeroArray(typeof(byte), Chunked = true)] public float[] Unk4;
        [AeroArray(typeof(byte), Chunked = true)] public float[] Unk5;
        [AeroArray(typeof(byte), Chunked = true)] public uint[] Unk6; // Presumably this would have been resource types?
    }
}