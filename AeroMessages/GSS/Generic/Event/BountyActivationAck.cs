using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.BountyActivationAck, GssVersion.V1, GssVersion.V67)]
    public partial class BountyActivationAck
    {
        public uint BountyDefId;
        public byte Success;
        public byte Reason; // [0-17]
        public byte Unk3; // Row / type?
        public uint Unk4;

        [AeroSdb("clientmissions::Mission","id")]
        //[AeroSdb("clientmissions::MissionObjective","mission_id")]
        public uint MissionId;

        public byte Unk5;
        public ulong Unk6;
        [AeroString] public string Name;
    }
}