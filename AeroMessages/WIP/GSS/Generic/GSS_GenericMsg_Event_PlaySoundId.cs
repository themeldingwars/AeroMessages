/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 0
    TypeName: Generic
    MsgId: 106
    MsgName: PlaySoundId
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Generic
{
    [Aero]
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