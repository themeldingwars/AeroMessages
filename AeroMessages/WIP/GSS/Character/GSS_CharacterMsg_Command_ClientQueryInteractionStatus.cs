/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 186
    MsgName: ClientQueryInteractionStatus
META_END
 */
using Aero.Gen.Attributes;
using AeroMessages.Common;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Command_ClientQueryInteractionStatus
    {
       public EntityId Entity;
       public byte Unk;
    }
}