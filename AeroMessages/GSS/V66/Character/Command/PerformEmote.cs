using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 142)]
    public partial class PerformEmote
    {
        public uint Time;

        [AeroSdb("dbcharacter::EmoteRecord", "id")]
        public ushort EmoteId;
    }
}