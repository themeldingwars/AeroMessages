using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 28, 85)]
    public partial class PublicCombatLog
    {
        public int HaveData;
        [AeroIf(nameof(HaveData), 1)]
        [AeroArray(typeof(ushort))]
        public byte[] Data;
    }
}