/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 151
    MsgName: CallForHelp
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Command_CallForHelp
    {
        public uint Time;
    }
}