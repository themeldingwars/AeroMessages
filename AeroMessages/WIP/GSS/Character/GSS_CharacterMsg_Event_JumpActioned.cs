/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 8
    TypeName: Character::ObserverView
    MsgId: 101
    MsgName: JumpActioned
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_JumpActioned
    {
        public ushort ShortTime;
    }
}