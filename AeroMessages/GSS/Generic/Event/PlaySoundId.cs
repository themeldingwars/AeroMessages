using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssMessage.PlaySoundId, GssVersion.V1, GssVersion.V67)]
    public partial class PlaySoundId
    {
        // Sdb table 14, record_id column?
        // Looks like there are variations of the message
        // Record id works for some messages but not all.
        public long Unk1; // An int64?
        public ulong Unk2;
    }
}