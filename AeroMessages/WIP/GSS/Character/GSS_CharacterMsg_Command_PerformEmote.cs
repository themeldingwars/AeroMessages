/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 142
    MsgName: PerformEmote
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 142)]
    public partial class Character_Command_PerformEmote
    {
        public uint Time;

        [AeroSdb("dbcharacter::EmoteRecord", "id")]
        public ushort EmoteId;
    }
}