using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using AeroMessages.GSS.Character;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.BountyActivationAck, GssVersion.V1, GssVersion.V74)]
    public partial class BountyActivationAck
    {
        public uint BountyDefId;
        public byte Success;
        public byte Reason; // [0-17]
        public BountyCategory Category;
        public BountyType BountyType;

        [AeroSdb("clientmissions::Mission","id")]
        //[AeroSdb("clientmissions::MissionObjective","mission_id")]
        public uint MissionId;

        public byte IsRare;
        public long ExpirationTime; // unix seconds, -1 = never
        [AeroString] public string Name;
    }
}