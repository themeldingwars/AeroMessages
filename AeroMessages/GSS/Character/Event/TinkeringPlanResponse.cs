using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.TinkeringPlanResponse, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class TinkeringPlanResponse
    {
        [AeroString] public string ErrorKey;
        public uint SdbId;
        public sbyte Success;
        public ulong OriginalGearItem;
        public ulong NewGearItem;
        public sbyte IsCritical;
    }
}