using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 5, 123)]
    public partial class Character_Command_SelectFireMode
    {
        public uint Time;
        public byte FireMode;
    }
}