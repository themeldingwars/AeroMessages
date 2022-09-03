using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 91)]
    public partial class PublicCombatLog
    {
        // Yeah, this is how the parser reads it...
        public int HaveData;
        [AeroIf(nameof(HaveData), 1)]
        [AeroArray(typeof(ushort))]
        public byte[] Data; // Multiple variations, often gametime towards the end of a row.
    }
}