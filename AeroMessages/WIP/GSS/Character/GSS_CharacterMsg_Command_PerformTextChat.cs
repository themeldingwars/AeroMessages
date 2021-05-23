/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 145
    MsgName: PerformTextChat
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Command_PerformTextChat
    {
        [AeroString]
        public string Message;
        public byte Channel; // Might be a ushort

        // Remaining bytes are used in whispers (8) and friends chat (14)
        // Not sure about their contents.
        //[AeroArray(-1)]
        //public byte[] Unk;
    }
}