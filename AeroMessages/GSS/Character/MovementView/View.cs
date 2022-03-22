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

namespace AeroMessages.GSS.Character
{
    [Aero(true)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 12, 1)]  // update
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 12, 3)] // view keyframe
    public partial class Keyframe
    {
        private MovementData Movement; 
    }
}