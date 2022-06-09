using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 210)]
    public partial class Character_Combat_RequestTeleport
    {
        public uint PosX;
        public uint PosY;
    }
}