using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 64)]
    public partial class Generic_Event_MissionObjectiveUpdated
    {
        [AeroSdb("clientmissions::Mission","id")]
        //[AeroSdb("clientmissions::MissionObjective","mission_id")]
        public uint MissionId;

        [AeroArray(8)]
        public byte[] Unk1;

        [AeroString]
        public string TextObjectiveTitle;

        [AeroString]
        public string TextObjectiveProgress;

        [AeroArray(5)]
        public byte[] Unk2;
    }
}