using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 28, 89)]
    public partial class ForcedMovementCancelled
    {   
        [AeroSdb("apt::BaseCommandDef", "id")]
        public uint CommandId;
        public ushort ShortTime;
    }
}