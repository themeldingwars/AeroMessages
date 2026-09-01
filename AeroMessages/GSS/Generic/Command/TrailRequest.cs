using Aero.Gen.Attributes;
using Aero.Protocol;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Both, GssMessage.TrailRequest, GssVersion.V1, GssVersion.V67)]
    public partial class TrailRequest
    {
        public uint Id;
        public byte Unk2;
        public Vector3 Origin;
        public Vector3 Destination;
    }
}