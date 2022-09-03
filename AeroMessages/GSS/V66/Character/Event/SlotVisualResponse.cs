using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 155)]
    public partial class SlotVisualResponse
    {   
        public int LoadoutId;
        public uint ConfigId; // Assumption. If so, 0: PvE, 1: PvP

        [AeroSdb("dbitems::LoadoutSlot", "id")]
        public byte SlotIdx; // Assumption

        public uint VisualSdbId; // Assumption
        public byte Result; // Assumption. 1 = Success, 0 = Failure
    }
}