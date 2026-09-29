using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.ListItemForSale, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class ListItemForSale
    {
        public ulong RequestId;
        public ulong ItemGuid;
        public uint ItemSdbId;
        public int Quantity;
        [AeroString] public string Unk5;
        public long Price;
        [AeroString] public string Unk7;
        public byte Duration;
    }
}