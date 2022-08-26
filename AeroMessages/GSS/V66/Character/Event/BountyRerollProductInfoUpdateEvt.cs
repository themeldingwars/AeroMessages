using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 185)] // Not sure controller
    public partial class BountyRerollProductInfoUpdateEvt
    {
        [AeroArray(typeof(byte))] public BountyRerollProductInfoData[] Data;
    }

    [AeroBlock]
    public struct BountyRerollProductInfoData
    {
        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
    }
}