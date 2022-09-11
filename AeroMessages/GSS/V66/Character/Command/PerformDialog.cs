using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 146)]
    public partial class PerformDialog
    {
        public uint Unk1;
        public ulong Unk2;
        public ulong Unk3;
        public uint Unk4;
        public byte Unk5;
        public uint Unk6;
        public byte Unk7;
        public uint Unk8;
        public ulong Unk9;
    }
}