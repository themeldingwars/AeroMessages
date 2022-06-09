using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 145)]
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