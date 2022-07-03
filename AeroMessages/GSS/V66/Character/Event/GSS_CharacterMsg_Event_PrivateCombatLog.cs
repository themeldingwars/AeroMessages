using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 92)]
    public partial class PrivateCombatLog
    {
        [AeroArray(4)]
        public byte[] Unk1;

        [AeroArray(typeof(ushort))]
        public byte[] Data; // Multiple variations, often gametime towards the end of a row.
    }
}