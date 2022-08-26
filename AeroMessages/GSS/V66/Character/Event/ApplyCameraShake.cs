using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 162)] // Not sure controller
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