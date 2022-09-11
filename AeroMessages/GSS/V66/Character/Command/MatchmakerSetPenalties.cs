using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, 2, 92)]
    public partial class MatchmakerSetPenalties
    {
        public uint Unk1;
        public byte Unk2;
        public uint Unk3;
        public byte Unk4;
    }
}