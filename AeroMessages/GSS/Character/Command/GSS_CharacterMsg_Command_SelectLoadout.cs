using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 150)]
    public partial class Character_Command_SelectLoadout
    {
        public uint LoadoutId;
        public byte Unk;
    }
}