using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Generic
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 0, 106)]
    public partial class Generic_Event_PlaySoundId
    {   
        // Sdb table 14, record_id column?
        // Looks like there are variations of the message
        // Record id works for some messages but not all.
        public uint Id_UInt;

        [AeroArray(4)]
        public byte[] Unk1;

        [AeroArray(8)]
        public byte[] Unk2;
    }
}