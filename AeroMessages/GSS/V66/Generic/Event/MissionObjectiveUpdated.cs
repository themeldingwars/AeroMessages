using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 64)]
    public partial class MissionObjectiveUpdated
    {
        // Its a bit weird that its using 8 bytes for the mission id but yeah

        [AeroSdb("clientmissions::Mission","id")]
        //[AeroSdb("clientmissions::MissionObjective","mission_id")]
        public ulong MissionId;

        public uint Unk1;

        [AeroString]
        public string TextObjectiveTitle;

        [AeroString]
        public string TextObjectiveProgress;

        public byte Unk2; // Some special type

        public float Unk3; // Progress as Percentage
    }
}