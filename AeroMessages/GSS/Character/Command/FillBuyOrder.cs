using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.FillBuyOrder, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class FillBuyOrder
    {
        public ulong Unk1;
        public ulong Unk2;
        public uint Unk3;
        public int Unk4;
        public ulong Unk5;
    }
}