/*
META_BEGIN
    MsgType: GSS
    FromServer: True
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 164
    MsgName: ExitingAttachment
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Event_ExitingAttachment
    {
        // Guessing
        [AeroArray(3)]
        public ushort[] PackedAim;
    }
}