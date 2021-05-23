/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 205
    MsgName: UnslotAllModulesRequest
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Command_UnslotAllModulesRequest
    {
        public ulong ItemGUID;
    }
}