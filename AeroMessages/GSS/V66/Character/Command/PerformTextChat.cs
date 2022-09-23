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
        public byte HaveTargetName;
        [AeroIf(nameof(HaveTargetName), 1)]
        [AeroString] public string TargetName;

        public byte Unk3; // This seems like a type indicator for Unk4

        // 009f25a0
        public byte HaveUnk4;
        [AeroIf(nameof(HaveUnk4), 1)]
        public ChatUnk4Data Unk4; // Binary data
    }

    [AeroBlock]
    public struct ChatUnk4Data
    {
        [AeroArray(typeof(ushort))]
        public byte[] Data;
    }
}