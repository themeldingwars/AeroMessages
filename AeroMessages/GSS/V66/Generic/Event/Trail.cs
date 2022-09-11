using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 98)]
    public partial class Trail
    {
        public uint Unk1;
        public byte Unk2;

        [AeroArray(typeof(byte))]
        public Vector3[] Points;
    }
}