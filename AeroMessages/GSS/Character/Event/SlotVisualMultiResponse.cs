using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.SlotVisualMultiResponse, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class SlotVisualMultiResponse
    {
        public int LoadoutId;
        public uint ConfigId; // Assumption. If so, 0: PvE, 1: PvP

        [AeroArray(typeof(byte))]
        public LoadoutConfig_Visual[] Visuals;

        public sbyte Result; // 1 = Success, 0 = Failure
    }
}