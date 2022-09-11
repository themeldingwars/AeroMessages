using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 147)]
    public partial class SetDialogTag
    {
        [AeroString] public string Unk1;
        public uint Unk2;
        public byte Unk3;
        public byte Unk4;
    }
}