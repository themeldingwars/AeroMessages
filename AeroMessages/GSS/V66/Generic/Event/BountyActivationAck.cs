using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 71)]
    public partial class BountyActivationAck
    {
        public uint BountyId; // Unsure how this id works
        public byte Unk1;
        public byte Unk2;
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