using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.Character
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 182)]
    public partial class Character_Command_ResourceNodeBeaconCalldownRequest
    {
        public Vector3 Position;
    }
}