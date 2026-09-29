using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.LevelUpEvent, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.LevelUpEvent, GssCharacterView.ObserverView, GssVersion.V74, GssVersion.V74)]
    public partial class LevelUpEvent
    {
        public uint FrameId;
        public byte NewLevel;
        public byte NumberOfLevelsAdvanced;
        [AeroArray(typeof(byte))]
        public byte[] RareReplacementLevels; // levels whose dbcharacter::LoadoutRareReplacements rows apply
    }
}