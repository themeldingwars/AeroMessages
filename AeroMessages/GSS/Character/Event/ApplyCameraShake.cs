using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.ApplyCameraShake, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)] // Not sure controller
    public partial class ApplyCameraShake
    {
        public ulong Unk1;
        public uint Unk2;
        public float Unk3;
        public float Unk4;
        public uint Unk5;
        public uint Unk6;
    }
}