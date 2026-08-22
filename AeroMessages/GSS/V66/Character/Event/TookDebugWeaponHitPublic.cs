using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 2, 85)] // TookDebugWeaponHitPublic
    public partial class TookDebugWeaponHitPublic // TookDebugWeaponHit has the same parser
    {
        public TookDebugWeaponHitData Data;
    }
}