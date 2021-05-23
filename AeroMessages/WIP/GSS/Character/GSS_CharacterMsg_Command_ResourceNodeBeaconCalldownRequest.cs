/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 182
    MsgName: ResourceNodeBeaconCalldownRequest
META_END
 */
using Aero.Gen.Attributes;
using System.Numerics;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Command_ResourceNodeBeaconCalldownRequest
    {
        public Vector3 Position;
    }
}