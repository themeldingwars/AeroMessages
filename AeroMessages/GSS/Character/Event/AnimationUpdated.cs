using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.AnimationUpdated, GssCharacterView.ObserverView, GssVersion.V1, GssVersion.V67)] // Not sure controller
    public partial class AnimationUpdated
    {
        public ushort Unk1;
        public byte Unk2;
    }
}