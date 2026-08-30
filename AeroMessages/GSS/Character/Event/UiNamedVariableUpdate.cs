using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.UiNamedVariableUpdate, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class UiNamedVariableUpdate
    {
        public uint Unk1;
        public float Unk2;
    }
}