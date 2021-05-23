/*
META_BEGIN
    MsgType: GSS
    FromServer: False
    TypeCode: 2
    TypeName: Character::BaseController
    MsgId: 210
    MsgName: RequestTeleport
META_END
 */
using Aero.Gen.Attributes;
namespace AeroMessages.GSS.Character
{
    [Aero]
    public partial class Character_Combat_RequestTeleport
    {
        public uint PosX;
        public uint PosY;
    }
}