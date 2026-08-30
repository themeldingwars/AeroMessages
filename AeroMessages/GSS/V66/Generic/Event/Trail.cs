using Aero.Gen.Attributes;
using Aero.Protocol;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.Trail, GssVersion.V1, GssVersion.V67)]
    public partial class Trail
    {
        public uint Unk1;
        public byte Unk2; // 0, 1 or 2

        [AeroArray(typeof(byte))]
        public Vector3[] Points;
    }
}