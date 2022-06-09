using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 5, 124)]
    public partial class Character_Command_UseScope
    {
        public uint Time;
        public byte InScope;
    }
}