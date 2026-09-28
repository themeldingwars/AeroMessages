using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.GSS.Character;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.BountyListActiveAck, GssVersion.V1, GssVersion.V74)]
    public partial class BountyListActiveAck
    {
        public byte Success;
        public BountyCategory Category; // 0 = all
        [AeroString(typeof(ushort))] public string JSON;
    }
}