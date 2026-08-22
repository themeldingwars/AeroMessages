using Aero.Gen.Attributes;
using static Aero.Gen.Attributes.AeroMessageIdAttribute;

namespace AeroMessages.GSS.V66.Character.Event
{
    [Aero]
    [AeroMessageId(MsgType.GSS, MsgSrc.Message, 5, 86)] // TookDebugWeaponHit
    public partial class TookDebugWeaponHit // TookDebugWeaponHitPublic has the same parser
    {
        public TookDebugWeaponHitData Data;
    }
}