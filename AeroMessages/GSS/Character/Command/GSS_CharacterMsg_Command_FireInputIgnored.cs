using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 5, 117)]
    public partial class Character_Command_FireInputIgnored
    {
        public uint Time;
        public byte Ignored;
    }
}