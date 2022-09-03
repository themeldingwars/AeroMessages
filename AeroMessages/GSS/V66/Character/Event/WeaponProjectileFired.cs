using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 95)]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 11, 95)]
    public partial class WeaponProjectileFired
    {
        public ushort ShortTime;
        public QuantisedVector3 Aim;
        public byte HaveMoreData;
        [AeroIf(nameof(HaveMoreData), 1)]
        public HalfVector3 MoreData; // Not sure, 3x2
    }
}