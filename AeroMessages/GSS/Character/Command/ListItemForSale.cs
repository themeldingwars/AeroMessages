using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ListItemForSale, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V67)]
    public partial class ListItemForSale
    {
        public ulong Unk1;
        public ulong Unk2;
        public uint Unk3;
        public int Unk4;
        [AeroString] public string Unk5;
        public ulong Unk6;
        [AeroString] public string Unk7;
        public byte Unk8;
    }
}