using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 114)]
    public partial class ForcedMovementCancelled
    {

        [AeroSdb("apt::BaseCommandDef", "id")]
        public uint CommandId;

        public ushort ShortTime;
    }
}