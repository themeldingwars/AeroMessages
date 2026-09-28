using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Command
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Command, GssCharacterCommand.FillBuyOrder, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class FillBuyOrder
    {
        public ulong RequestId;
        public ulong ItemGuid;
        public uint ItemSdbId;
        public int Quantity;
        public long PricePerUnit;
    }
}