using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
using System.Numerics;
using static Aero.Gen.Attributes.AeroIfAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 145)]
    public partial class PerformTextChat
    {
        [AeroString] public string Message;
        public byte Channel;

        // 009fe600
        public byte HaveUnk1;
        [AeroIf(nameof(HaveUnk1), 1)]
        public ulong Unk1;

        // 009e5820
        public byte HaveUnk2;
        [AeroIf(nameof(HaveUnk2), 1)]
        [AeroString] public string Unk2;

        public byte Unk3;

        // 009f25a0
        public byte HaveUnk4;
        [AeroIf(nameof(HaveUnk4), 1)]
        public ChatUnk4Data Unk4;
    }

    [AeroBlock]
    public struct ChatUnk4Data
    {
        [AeroArray(typeof(ushort))]
        public byte[] Data;
    }
}