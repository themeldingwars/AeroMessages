using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 65)]
    public partial class MissionStatusChanged
    {
        [AeroSdb("clientmissions::Mission","id")]
        //[AeroSdb("clientmissions::MissionObjective","mission_id")]
        public ulong MissionId;

        public byte Status; // Some special type, guess it has to be status
    }

    public enum MissionStatus : byte
    {
        Unk2 = 2,
        Unk3 = 3,
    }
}