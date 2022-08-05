using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 251, 22)]
    public partial class TrailRequest
    {
        [AeroArray(5)]
        public byte[] Unk;

        public Vector3 Position1;
        public Vector3 Position2;
    }
}