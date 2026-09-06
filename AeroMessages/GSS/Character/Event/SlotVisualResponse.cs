using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.SlotVisualResponse, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class SlotVisualResponse
    {
        public int LoadoutId;
        public uint ConfigId; // Assumption. If so, 0: PvE, 1: PvP

        [AeroSdb("dbitems::LoadoutSlot", "id")]
        public byte SlotIdx; // Assumption

        public uint VisualSdbId; // Assumption
        public sbyte Result; // Assumption. 1 = Success, 0 = Failure
    }
}