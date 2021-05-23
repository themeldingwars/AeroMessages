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
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Command_PerformEmote
    {
        public uint Time;

        [AeroSDB("dbcharacter::EmoteRecord", "id")]
        public ushort EmoteId;
    }
}