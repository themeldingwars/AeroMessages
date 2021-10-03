/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 138
    MsgName: ActivateConsumable
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 138)]
    public partial class CharacterCombatControllerActivateConsumable
    {
        public uint Time;

        [AeroSdb("dbitems::RootItem", "sdb_id")]
        public uint ItemSdbId;
    }
}