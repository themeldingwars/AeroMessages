using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 71)]
    public partial class Generic_Event_BountyActivationAck
    {
        public uint BountyId; // Unsure how this id works

        [AeroArray(7)]
        public byte[] Unk1;

        [AeroSdb("clientmissions::Mission","id")]
        //[AeroSdb("clientmissions::MissionObjective","mission_id")]
        public uint MissionId;

        [AeroArray(9)]
        public byte[] Unk2;

        [AeroString]
        public string Name;

    }
}