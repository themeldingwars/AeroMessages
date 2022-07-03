using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 28, 84)]
    public partial class AbilityFailed
    {
        [AeroSdb("apt::AbilityData", "id")]
        public uint AbilityId;

        [AeroArray(4)]
        public byte[] Unk;
    }
}