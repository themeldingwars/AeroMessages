using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.BagInventoryUpdate, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)] // Not sure controller
    public partial class BagInventoryUpdate
    {
        [AeroString] public string Data;
    }
}