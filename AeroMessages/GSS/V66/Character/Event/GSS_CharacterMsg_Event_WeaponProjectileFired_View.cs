using Aero.Gen.Attributes;
using AeroMessages.Common;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 11, 95)]
    public partial class WeaponProjectileFired_View
    {
        public ushort ShortTime;
        public QuantisedVector3 Aim;
        public byte Unk;
    }
}