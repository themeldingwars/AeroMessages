using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 98)]
    public partial class Trail
    {
        [AeroArray(5)]
        public byte[] Unk;

        [AeroArray(typeof(byte))]
        public Vector3[] Points;
    }
}