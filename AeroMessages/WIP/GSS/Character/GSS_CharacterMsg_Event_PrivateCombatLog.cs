/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 92
    MsgName: PrivateCombatLog
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_PrivateCombatLog
    {
        [AeroArray(4)]
        public byte[] Unk1;

        [AeroArray(typeof(ushort))]
        public byte[] Data; // Multiple variations, often gametime towards the end of a row.
    }
}