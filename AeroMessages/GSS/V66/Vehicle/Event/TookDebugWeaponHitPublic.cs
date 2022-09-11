using Aero.Gen.Attributes;
using System.Numerics;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;
namespace AeroMessages.GSS.V66.Vehicle.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 30, 87)]
    public partial class TookDebugWeaponHitPublic
    {
        public TookDebugWeaponHitData Data;
    }
}