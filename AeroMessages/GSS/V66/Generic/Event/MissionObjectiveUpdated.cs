using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.MissionObjectiveUpdated, GssVersion.V1, GssVersion.V67)]
    public partial class MissionObjectiveUpdated
    {
        // Its a bit weird that its using 8 bytes for the mission id but yeah

        [AeroSdb("clientmissions::Mission","id")]
        //[AeroSdb("clientmissions::MissionObjective","mission_id")]
        public ulong MissionId;

        public uint ObjectiveIdx;

        [AeroString]
        public string TextObjectiveTitle;

        [AeroString]
        public string TextObjectiveProgress;

        public byte Status; // Some special type (2 => completed)

        public float Unk3; // Progress as Percentage
    }
}