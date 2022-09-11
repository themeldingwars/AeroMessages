using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 113)]
    public partial class ForcedMovement
    {
        public ForcedMovementData Data;   
        public ushort ShortTime;
    }
}