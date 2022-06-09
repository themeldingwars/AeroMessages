using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.Vehicle
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 28, 84)]
    public partial class Vehicle_Event_AbilityFailed
    {
        [AeroSdb("apt::AbilityData", "id")]
        public uint AbilityId;

        [AeroArray(4)]
        public byte[] Unk;
    }
}