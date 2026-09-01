using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.MissionStatusChanged, GssVersion.V1, GssVersion.V67)]
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