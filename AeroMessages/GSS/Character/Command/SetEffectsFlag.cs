using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.SetEffectsFlag, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class SetEffectsFlag
    {
        public byte Flag; // Effect flag being set, 1 = flashlight (only value seen)
        public byte Flashlight; // New state, copied into ObserverView.EffectsFlags
    }
}