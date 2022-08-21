using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 83)]
    public partial class ListItemForSale
    {
        public ulong Unk1;
        public ulong Unk2;
        public uint Unk3;
        public uint Unk4; // Unsure about type
        [AeroString] public string Unk5;
        public ulong Unk6;
        [AeroString] public string Unk7;
        public byte Unk8;
    }
}