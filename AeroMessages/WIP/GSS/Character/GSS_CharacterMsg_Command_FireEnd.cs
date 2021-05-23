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
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Command_FireEnd
    {
        public uint Time;
    }
}