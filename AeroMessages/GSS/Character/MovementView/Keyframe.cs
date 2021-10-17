/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 12
    TypeName: Character::MovementView
    MsgId: 3
    MsgName: Keyframe
META_END
 */
using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.MovementView
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 12, 3)]
    public partial class Keyframe
    {
        public MovementData Movement;
    }
}