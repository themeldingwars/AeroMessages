using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 182)]
    public partial class ResourceNodeBeaconCalldownRequest
    {
        public Vector3 Position;
    }
}