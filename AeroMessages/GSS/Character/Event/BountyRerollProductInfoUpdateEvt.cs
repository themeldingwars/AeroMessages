using Aero.Gen.Attributes;
using Aero.Protocol;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, GssCharacterMessage.BountyRerollProductInfoUpdateEvt, GssCharacterView.BaseController, GssVersion.V1, GssVersion.V74)]
    public partial class BountyRerollProductInfoUpdateEvt
    {
        [AeroArray(typeof(byte))] public BountyRerollProductInfoData[] Data;
    }

    [AeroBlock]
    public struct BountyRerollProductInfoData
    {
        public uint Category; // BountyCategory value as uint
        public uint Cost;
        public uint UpdatedAt; // a newer value replaces the stored entry
    }
}