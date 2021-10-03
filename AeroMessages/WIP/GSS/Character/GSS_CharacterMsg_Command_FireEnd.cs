/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 5
    TypeName: Character::CombatController
    MsgId: 119
    MsgName: FireEnd
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 5, 119)]
    public partial class Character_Command_FireEnd
    {
        public uint Time;
    }
}