using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 251, 22)]
    public partial class TrailRequest
    {
        public uint Id;
        public byte Unk2;
        public Vector3 Origin;
        public Vector3 Destination;
    }
}